using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppStudy.Base
{
    class NotifyPropertyBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public void Set<T>(ref T filed, T value, [CallerMemberName] string propName = "")
        {
            if (EqualityComparer<T>.Default.Equals(value, filed)) return;
            filed = value;
            RaisePropertyChanged(propName);
        }
    }
}
