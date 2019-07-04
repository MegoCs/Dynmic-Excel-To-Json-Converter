namespace ExcelToJsonFormatter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ftpUrlTxt = new System.Windows.Forms.TextBox();
            this.ftpPasswordTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testConnectionBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.browseFileBtn = new System.Windows.Forms.Button();
            this.filePathTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.convertFileBtn = new System.Windows.Forms.Button();
            this.uploadFileBtn = new System.Windows.Forms.Button();
            this.ftpUserNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sheetNameLabel = new System.Windows.Forms.Label();
            this.saveConnectionCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ftpUrlTxt
            // 
            this.ftpUrlTxt.Location = new System.Drawing.Point(125, 12);
            this.ftpUrlTxt.Name = "ftpUrlTxt";
            this.ftpUrlTxt.Size = new System.Drawing.Size(226, 20);
            this.ftpUrlTxt.TabIndex = 0;
            // 
            // ftpPasswordTxt
            // 
            this.ftpPasswordTxt.Location = new System.Drawing.Point(125, 64);
            this.ftpPasswordTxt.Name = "ftpPasswordTxt";
            this.ftpPasswordTxt.Size = new System.Drawing.Size(226, 20);
            this.ftpPasswordTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ftp-Url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ftp-Password";
            // 
            // testConnectionBtn
            // 
            this.testConnectionBtn.Location = new System.Drawing.Point(409, 12);
            this.testConnectionBtn.Name = "testConnectionBtn";
            this.testConnectionBtn.Size = new System.Drawing.Size(108, 23);
            this.testConnectionBtn.TabIndex = 3;
            this.testConnectionBtn.Text = "Test Connection";
            this.testConnectionBtn.UseVisualStyleBackColor = true;
            this.testConnectionBtn.Click += new System.EventHandler(this.TestConnectionBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(125, 133);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(279, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // browseFileBtn
            // 
            this.browseFileBtn.Location = new System.Drawing.Point(409, 99);
            this.browseFileBtn.Name = "browseFileBtn";
            this.browseFileBtn.Size = new System.Drawing.Size(108, 23);
            this.browseFileBtn.TabIndex = 4;
            this.browseFileBtn.Text = "Browse";
            this.browseFileBtn.UseVisualStyleBackColor = true;
            this.browseFileBtn.Click += new System.EventHandler(this.BrowseFileBtn_Click);
            // 
            // filePathTxt
            // 
            this.filePathTxt.Enabled = false;
            this.filePathTxt.Location = new System.Drawing.Point(125, 99);
            this.filePathTxt.Name = "filePathTxt";
            this.filePathTxt.Size = new System.Drawing.Size(279, 20);
            this.filePathTxt.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Excel File";
            // 
            // convertFileBtn
            // 
            this.convertFileBtn.Enabled = false;
            this.convertFileBtn.Location = new System.Drawing.Point(29, 133);
            this.convertFileBtn.Name = "convertFileBtn";
            this.convertFileBtn.Size = new System.Drawing.Size(87, 23);
            this.convertFileBtn.TabIndex = 5;
            this.convertFileBtn.Text = "Convert";
            this.convertFileBtn.UseVisualStyleBackColor = true;
            this.convertFileBtn.Click += new System.EventHandler(this.ConvertFileBtn_Click);
            // 
            // uploadFileBtn
            // 
            this.uploadFileBtn.Enabled = false;
            this.uploadFileBtn.Location = new System.Drawing.Point(409, 133);
            this.uploadFileBtn.Name = "uploadFileBtn";
            this.uploadFileBtn.Size = new System.Drawing.Size(108, 23);
            this.uploadFileBtn.TabIndex = 6;
            this.uploadFileBtn.Text = "Upload";
            this.uploadFileBtn.UseVisualStyleBackColor = true;
            this.uploadFileBtn.Click += new System.EventHandler(this.UploadFileBtn_Click);
            // 
            // ftpUserNameTxt
            // 
            this.ftpUserNameTxt.Location = new System.Drawing.Point(125, 38);
            this.ftpUserNameTxt.Name = "ftpUserNameTxt";
            this.ftpUserNameTxt.Size = new System.Drawing.Size(226, 20);
            this.ftpUserNameTxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ftp-UserName";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // sheetNameLabel
            // 
            this.sheetNameLabel.AutoSize = true;
            this.sheetNameLabel.Location = new System.Drawing.Point(409, 64);
            this.sheetNameLabel.Name = "sheetNameLabel";
            this.sheetNameLabel.Size = new System.Drawing.Size(63, 13);
            this.sheetNameLabel.TabIndex = 7;
            this.sheetNameLabel.Text = "SheetName";
            this.sheetNameLabel.Visible = false;
            // 
            // saveConnectionCheck
            // 
            this.saveConnectionCheck.AutoSize = true;
            this.saveConnectionCheck.Checked = true;
            this.saveConnectionCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.saveConnectionCheck.Location = new System.Drawing.Point(409, 38);
            this.saveConnectionCheck.Name = "saveConnectionCheck";
            this.saveConnectionCheck.Size = new System.Drawing.Size(108, 17);
            this.saveConnectionCheck.TabIndex = 10;
            this.saveConnectionCheck.Text = "Save Connection";
            this.saveConnectionCheck.UseVisualStyleBackColor = true;
            this.saveConnectionCheck.CheckedChanged += new System.EventHandler(this.SaveConnectionCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 172);
            this.Controls.Add(this.saveConnectionCheck);
            this.Controls.Add(this.sheetNameLabel);
            this.Controls.Add(this.convertFileBtn);
            this.Controls.Add(this.uploadFileBtn);
            this.Controls.Add(this.browseFileBtn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.testConnectionBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ftpUserNameTxt);
            this.Controls.Add(this.filePathTxt);
            this.Controls.Add(this.ftpPasswordTxt);
            this.Controls.Add(this.ftpUrlTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertion Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ftpUrlTxt;
        private System.Windows.Forms.TextBox ftpPasswordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button testConnectionBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button browseFileBtn;
        private System.Windows.Forms.TextBox filePathTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button convertFileBtn;
        private System.Windows.Forms.Button uploadFileBtn;
        private System.Windows.Forms.TextBox ftpUserNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label sheetNameLabel;
        private System.Windows.Forms.CheckBox saveConnectionCheck;
    }
}

