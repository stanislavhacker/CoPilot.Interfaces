using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces.EventArgs
{
    public enum ErrorType
    {
        InvalidResponse,
        CreateFolderFail
    }

    public class ErrorEventArgs : System.EventArgs
    {
        public Exception Exception { get; set; }
        public ErrorType Type { get; set; }
    }
}
