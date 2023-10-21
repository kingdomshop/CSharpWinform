using LiveCharts;
using LiveCharts.Defaults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppStudy.Base;

namespace WpfAppStudy.Model
{
    class MonitorValueModel
    {
        public Action<MonitorValueState, string> ValueStateChanged;

        public string ValueId { get; set; }
        public string ValueName { get; set; }
        public string StroageAreaId { get; set; }
        public int StartAddress { get; set; }
        public string DataType { get; set; }
        public bool IsAlarm { get; set; }
        public double LoLoAlarm { get; set; }
        public double LowAlarm { get; set; }
        public double HighAlarm { get; set; }
        public double HiHiAlarm { get; set; }
        public string Unit { get; set; }
        public double _currentVlaue { get; set; }

        public double CurrentValue {
            get { return _currentVlaue; }
            set 
            {
                _currentVlaue = value;
                if (IsAlarm)
                {
                    string msg = ValueDesc;
                    MonitorValueState  state = MonitorValueState.OK;

                    if (value < LoLoAlarm)
                    {
                        msg += "极低";state = MonitorValueState.LoLo; 
                    }else if (value < LowAlarm)
                    {
                        msg += "过低"; state = MonitorValueState.Low;
                    }
                    else if (value > HighAlarm)
                    {
                        msg += "过高"; state = MonitorValueState.Low;
                    }
                    else if (value > HiHiAlarm)
                    {
                        msg += "极高"; state = MonitorValueState.Low;
                    }
                    ValueStateChanged(0, msg + "。当前值：" + value.ToString());
                    values.Add(new ObservableValue(value));
                }
            }
       }

        public string ValueDesc { get; set; }

        public ChartValues<ObservableValue> values { get; set; } = new ChartValues<ObservableValue>();
    }
}
