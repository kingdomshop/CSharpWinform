using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppStudy.Base;

namespace WpfAppStudy.Model
{
    class DeviceModel : NotifyPropertyBase
    {
        public String DeviceId { get; set; }
        public String DeviceName { get; set; }

        private bool _isRunning;

        private bool _isWarning;

        public DeviceModel() { }
        public DeviceModel(string deviceName, bool isRunning, bool isWarning)
        {
            DeviceName = deviceName;
            _isRunning = isRunning;
            _isWarning = isWarning;
        }

        public bool IsRunning
        {
            get { return _isRunning; }
            set
            {
                _isRunning = value;
                this.RaisePropertyChanged();
            }
        }

        public bool IsWarning
        {
            get { return _isWarning; }
            set
            {
                _isWarning = value;
                this.RaisePropertyChanged();
            }
        }

        public ObservableCollection<MonitorValueModel> MonitorList { get; set; } = new ObservableCollection<MonitorValueModel>();
        public ObservableCollection<WarningMessageModel> WarningMessageList { get; set; } = new ObservableCollection<WarningMessageModel>();

    }
}
