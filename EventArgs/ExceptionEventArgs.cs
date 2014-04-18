using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces.EventArgs
{
    public class ExceptionEventArgs : System.EventArgs
    {
        public Exception Exception { get; set; }
    }
}
