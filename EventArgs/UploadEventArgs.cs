using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces.EventArgs
{
    public class UploadEventArgs : System.EventArgs
    {
        public UploadDone UploadDone { get; set; }
    }
}
