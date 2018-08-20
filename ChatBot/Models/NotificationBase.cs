using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.Models
{
    public class NotificationBase : INotifyPropertyChanged
    {
        private readonly Dictionary<string, PropertyChangedEventArgs> _argsCache = new Dictionary<string, PropertyChangedEventArgs>();

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyChange(string propertyName)
        {
            if (_argsCache != null)
            {
                if (!_argsCache.ContainsKey(propertyName))
                    _argsCache[propertyName] = new PropertyChangedEventArgs(propertyName);

                NotifyChange(_argsCache[propertyName]);
            }
        }

        private void NotifyChange(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}
