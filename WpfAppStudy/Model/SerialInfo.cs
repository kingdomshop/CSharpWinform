using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppStudy.Model
{
    class SerialInfo
    {
        public string Name { get; set; } = "COM1";
        public int BaudRate { get; set; } = 9600;
        public int DataBit { get; set; } = 8;
    }
}
