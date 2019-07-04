using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToJsonFormatter
{
    [Serializable]
    public class ConnectionSettings
    {
        public string FtpUrl { get; set; }
        public string FtpUserName { get; set; }
        public string FtpPassword { get; set; }
        public bool SaveConnection { get; set; }
    }
}
