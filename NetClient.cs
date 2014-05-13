using CoPilot.Interfaces.EventArgs;
using CoPilot.Interfaces.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoPilot.Interfaces
{
    public enum DownloadStatus
    {
        Complete,
        Fail
    }

    public interface NetClient
    {
        #region EVENTS

        event EventHandler<StateEventArgs> State;
        event EventHandler<ErrorEventArgs> Error;

        #endregion

        #region METHODS

        void TryLogin();
        Task Login();
        Task<Boolean> Progress(Uri url);
        Task<Response> BackupId(String name);
        Task<Response> Upload(Progress bar);
        Task<Response> Url(string id);
        Task<DownloadStatus> Preview(String id, Progress bar);
        Task<DownloadStatus> Download(String id, Progress bar);

        #endregion
    }
}
