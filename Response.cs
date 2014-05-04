using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoPilot.Interfaces
{
    public class Response : INotifyPropertyChanged
    {
        /// <summary>
        /// Url
        /// </summary>
        private string url = "";
        public string Url
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
        /// Id
        /// </summary>
        public string id = "";
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
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
