using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces.EventArgs
{
    public class ProgressEventArgs : System.EventArgs
    {
        public Progress Progress { get; set; }
    }
}
