using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppStudy.Base;
using WpfAppStudy.Model;

namespace WpfAppStudy.ViewModel
{
    class SystermMonitorViewModel
    {
        //ObservableCollection<T> 类    表示一个动态数据集合，在添加项、移除项或刷新整个列表时，此集合将提供通知。
        //WPF 提供 ObservableCollection<T> 类，它是实现 INotifyCollzectionChanged 接口的数据集合的内置实现。
        public ObservableCollection<LogModel> LogList { get; set; } = new ObservableCollection<LogModel>();

        public DeviceModel TestDevice { get; set; }
        public SystermMonitorViewModel()
        {
            InitLogInfo();

            TestDevice = new DeviceModel("冷却塔",true,true);
            TestDevice.MonitorList.Add(new MonitorValueModel
            {
               ValueName="液位",
               Unit ="m",
               CurrentValue=45
            });
            TestDevice.MonitorList.Add(new MonitorValueModel
            {
                ValueName = "入口压力",
                Unit ="Mpa",CurrentValue=34
            });
            TestDevice.MonitorList.Add(new MonitorValueModel
            {
                ValueName = "入口温度",
                Unit = "C",
                CurrentValue = 26
            });
            TestDevice.MonitorList.Add(new MonitorValueModel
            {
                ValueName = "出口压力",
                Unit = "Mpa",
                CurrentValue = 34
            });
            TestDevice.MonitorList.Add(new MonitorValueModel
            {
                ValueName = "出口温度",
                Unit = "C",
                CurrentValue = 34
            });
            TestDevice.WarningMessageList.Add(new WarningMessageModel { Message = $"冷却塔 1#液位极低，当前压力值为"});
        }

        private void InitLogInfo()
        {
            this.LogList.Add(new LogModel { RowNumber = 1, DeviceName = "设备1", LogInfo = "已经启动", Message = "无异常", LogType = LogType.Normal });
            this.LogList.Add(new LogModel { RowNumber = 2, DeviceName = "设备2", LogInfo = "已经启动", Message = "无异常", LogType = LogType.warn });
            this.LogList.Add(new LogModel { RowNumber = 3, DeviceName = "设备3", LogInfo = "已经启动", Message = "无异常", LogType = LogType.error });
            this.LogList.Add(new LogModel { RowNumber = 4, DeviceName = "设备4", LogInfo = "已经启动", Message = "无异常", LogType = LogType.Normal });
            this.LogList.Add(new LogModel { RowNumber = 5, DeviceName = "设备5", LogInfo = "已经启动", Message = "无异常", LogType = LogType.warn });
        }


       


       
    }
}
