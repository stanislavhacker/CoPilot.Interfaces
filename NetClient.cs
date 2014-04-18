using CoPilot.Interfaces.EventArgs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CoPilot.Interfaces
{
    public interface NetClient
    {
        #region EVENTS

        event EventHandler<UploadEventArgs> UploadComplete;
        event EventHandler<ProgressEventArgs> UploadProgress;
        event EventHandler<ExceptionEventArgs> UploadError;

        event EventHandler<UriEventArgs> GetComplete;
        event EventHandler<ExceptionEventArgs> GetError;

        event EventHandler DeleteComplete;
        event EventHandler<ExceptionEventArgs> DeleteError;

        event EventHandler<StreamEventArgs> DownloadComplete;
        event EventHandler<ExceptionEventArgs> DownloadError;

        #endregion

        void Email(String email, String message);

        void Upload(String name, String contentType, Stream file);
        void Get(string url);
        void Download(Uri url);
        void Download(String id);
        void Delete(string url);
    }
}
