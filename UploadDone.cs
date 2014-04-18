using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces
{
    public class UploadDone
    {
        public String Status { get; set; }
        public String DownloadUrl { get; set; }
        public String DeleteUrl { get; set; }
        public String FileId { get; set; }
    }
}
