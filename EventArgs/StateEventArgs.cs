using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces.EventArgs
{
     public enum ConnectionStatus
     {
        Disconnected,
        Connected
     }

     public class StateEventArgs : System.EventArgs
     {
         public ConnectionStatus State { get; set; }
     }
}
