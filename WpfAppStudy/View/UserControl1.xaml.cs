using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAppStudy.DAL;

namespace WpfAppStudy.View
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public PlcDataAcess plc = new PlcDataAcess("192.168.12.30", 6000);
        public bool bo;
        public UserControl1()
        {
            InitializeComponent();
        }

        void getPlcData()
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                this.la.Content = "通讯中";
                this.la.Background = Brushes.Yellow;
            
                Thread th = new Thread(() =>
            {
                bo = plc.isCOnnect();
                //System.Windows.Threading.DispatcherObject 类：
                //从图中看WPF 中的使用到的大部分控件与其他类大多是继承 DispatcherObject 类，
                //它提供了用于处理并发和线程的基本构造。
                this.Dispatcher.Invoke(() =>
                {
                    if (bo)
                    {
                        this.la.Content = "已连接";
                        this.la.Background = Brushes.Green;
                    }
                    else
                    {
                        this.la.Content = "通讯异常";
                        this.la.Background = Brushes.Red;
                        this.la.HorizontalContentAlignment = HorizontalAlignment.Center;
                    }
                });   
            });

            th.Start();
        }
    }
}
