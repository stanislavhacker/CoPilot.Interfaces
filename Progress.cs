using CoPilot.Interfaces.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace CoPilot.Interfaces
{
    public enum ProgressPreferences 
    {
        AllowOnCelluralAndBatery,
        AllowOnWifiAndBatery,
        AllowOnWifiAndExternalPower
    }

    public class Progress : INotifyPropertyChanged
    {
        /// <summary>
        /// Preferences
        /// </summary>
        private ProgressPreferences preferences = ProgressPreferences.AllowOnWifiAndExternalPower;
        public ProgressPreferences Preferences
        {
            get
            {
                return preferences;
            }
            set
            {
                preferences = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Size
        /// </summary>
        private string size = "";
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// BytesTransferred
        /// </summary>
        private long bytesTransferred = 0;
        public long BytesTransferred
        {
            get
            {
                return bytesTransferred;
            }
            set
            {
                bytesTransferred = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// ProgressPercentage
        /// </summary>
        private double progressPercentage = 0;
        public double ProgressPercentage
        {
            get
            {
                return progressPercentage;
            }
            set
            {
                progressPercentage = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// TotalBytes
        /// </summary>
        private long totalBytes = 0;
        public long TotalBytes
        {
            get
            {
                return totalBytes;
            }
            set
            {
                totalBytes = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Selected
        /// </summary>
        private bool selected = false;
        public bool Selected
        {
            get
            {
                return selected;
            }
            set
            {
                selected = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Progress
        /// </summary>
        private bool inProgress = false;
        public bool InProgress
        {
            get
            {
                return inProgress;
            }
            set
            {
                inProgress = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Url
        /// </summary>
        private Uri url = null;
        public Uri Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Type
        /// </summary>
        private FileType type = FileType.Data;
        public FileType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Cancel
        /// </summary>
        private CancellationTokenSource cancel;
        public CancellationTokenSource Cancel
        {
            get
            {
                return cancel;
            }
            set
            {
                cancel = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// data
        /// </summary>
        private object data;
        public object Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
                RaisePropertyChanged();
            }
        }


        #region PROPERTY CHANGE

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// On property change
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        /// <summary>
        /// Raise proeprty change
        /// </summary>
        /// <param name="caller"></param>
        public void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        /// <summary>
        /// Call propertis change on all
        /// </summary>
        public void RaisePropertiesChanged()
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(string.Empty));
            }
        }

        #endregion

    }
}

