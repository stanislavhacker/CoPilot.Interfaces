using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces
{
    public class Progress
    {
        public String Status { get; set; }
        public String Eta { get; set; }
        public String Elapsed { get; set; }
        public Double Speed { get; set; }
        public Double UploadedBytes { get; set; }
        public Double TotalSize { get; set; }
        public Double Percent { get; set; }
    }
}

