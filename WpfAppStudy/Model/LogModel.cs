﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppStudy.Base;

namespace WpfAppStudy.Model
{
    class LogModel
    {
        public int RowNumber { get; set; }
        public string DeviceName { get; set; }
        public string LogInfo { get; set; }
        public string Message { get; set; }
        public LogType LogType { get; set; }
    }
}
