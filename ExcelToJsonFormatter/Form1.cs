using ExcelDataReader;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ExcelToJsonFormatter
{
    public partial class Form1 : Form
    {
        private string inFilePath;
        private List<string> outPutFileNames;
        private string outFilePath = @"C:\Json";

        public Form1()
        {
            InitializeComponent();
        }

        private void TestConnectionBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ftpUrlTxt.Text = "ftp://waws-prod-cy4-001.ftp.azurewebsites.windows.net";
                ftpUserNameTxt.Text = @"Test-AppService-notificationJob\$Test-AppService-notificationJob";
                ftpPasswordTxt.Text = "PAhqNq7pmn9KmwkEPEClWGfDaC8EbQvxvDGyxv2Qf2mHrcSYTF0Zcch7aet5";

                WebRequest request = WebRequest.Create(ftpUrlTxt.Text+"/JsonFiles");
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                request.Credentials = new NetworkCredential(ftpUserNameTxt.Text, ftpPasswordTxt.Text);
                using (FtpWebResponse resp = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show($"Connection Succeeded {resp.WelcomeMessage}");
                    browseFileBtn.Enabled = true;
                    convertFileBtn.Enabled = true;
                    uploadFileBtn.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection To Ftp Faild");
                browseFileBtn.Enabled = false;
                convertFileBtn.Enabled = false;
                uploadFileBtn.Enabled = false;
            }
        }

        private void BrowseFileBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathTxt.Text = openFileDialog1.FileName;
                inFilePath = openFileDialog1.FileName;
                convertFileBtn.Enabled = true;
                outPutFileNames = new List<string>();
            }
        }

        private void UploadFileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    foreach (var item in outPutFileNames)
                    {
                        Upload(item,ftpUrlTxt.Text,ftpUserNameTxt.Text,ftpPasswordTxt.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Upload(string fileName, string uploadUrl, string user, string pswd)
        {
            Stream requestStream = null;
            FileStream fileStream = null;
            FtpWebResponse uploadResponse = null;
            try
            {
                FtpWebRequest uploadRequest = (FtpWebRequest)WebRequest.Create(uploadUrl + @"/JsonFiles/" + Path.GetFileName(fileName));
                uploadRequest.Method = WebRequestMethods.Ftp.UploadFile;
                //Since the FTP you are downloading to is secure, send
                //in user name and password to be able upload the file
                ICredentials credentials = new NetworkCredential(user, pswd);
                uploadRequest.Credentials = credentials;
                //UploadFile is not supported through an Http proxy
                //so we disable the proxy for this request.
                uploadRequest.Proxy = null;
                //uploadRequest.UsePassive = false; <--found from another forum and did not make a difference
                requestStream = uploadRequest.GetRequestStream();
                fileStream = File.Open(fileName, FileMode.Open);
                byte[] buffer = new byte[1024];
                int bytesRead;
                while (true)
                {
                    bytesRead = fileStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                        break;
                    requestStream.Write(buffer, 0, bytesRead);
                }
                //The request stream must be closed before getting
                //the response.
                requestStream.Close();
                uploadResponse =
                  (FtpWebResponse)uploadRequest.GetResponse();
            }
            catch (UriFormatException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (uploadResponse != null)
                    uploadResponse.Close();
                if (fileStream != null)
                    fileStream.Close();
                if (requestStream != null)
                    requestStream.Close();
            }
        }

        private void ConvertFileBtn_Click(object sender, EventArgs e)
        {
            uploadFileBtn.Enabled = true;

        }

        private void ConvertExcelWithPathToJsonFilesAtPutPath(string inFilePath, string outFilePath,BackgroundWorker worker)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (FileStream inFile = File.Open(inFilePath, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(inFile, new ExcelReaderConfiguration()
                {
                    FallbackEncoding = Encoding.GetEncoding(1252)
                }))
                {
                    do
                    {
                        string fileName = $@"{outFilePath}\{reader.Name}.json";
                        outPutFileNames.Add(fileName);
                        progressBar1.Value = 0;
                        using (StreamWriter outFile = File.CreateText(fileName))
                        {
                            using (JsonTextWriter writer = new JsonTextWriter(outFile))
                            {
                                writer.Formatting = Formatting.Indented; //I likes it tidy
                                writer.WriteStartArray();
                                reader.Read();
                                IDictionary<int, string> dict = new Dictionary<int, string>();
                                int culmnsNumber = 0;
                                try
                                {
                                    for (culmnsNumber = 0; culmnsNumber < reader.FieldCount; culmnsNumber++)
                                    {
                                        dict.Add(culmnsNumber, reader[culmnsNumber].ToString());
                                    }
                                }
                                catch
                                {
                                }
                                int rows = reader.RowCount;
                                while (reader.Read())
                                {
                                    writer.WriteStartObject();
                                    for (int i = 0; i < culmnsNumber; i++)
                                    {
                                        writer.WritePropertyName(dict[i]);
                                        writer.WriteValue(reader[i]);
                                    }
                                    writer.WriteEndObject();
                                    worker.ReportProgress((reader.Depth / reader.RowCount) * 100, reader.Name);
                                }
                                writer.WriteEndArray();
                            }
                        }
                    } while (reader.NextResult());
                }
            }
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ConvertExcelWithPathToJsonFilesAtPutPath(inFilePath, outFilePath, sender as BackgroundWorker);
        }

        private void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            sheetNameLabel.Text = e.UserState.ToString();
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Task Completed");
        }
    }
}
