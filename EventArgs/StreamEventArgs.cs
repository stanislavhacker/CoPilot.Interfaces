using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces.EventArgs
{
    public class StreamEventArgs : System.EventArgs
    {
        public Stream Stream { get; set; }
    }
}
