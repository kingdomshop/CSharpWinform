using ActProgType64Lib;
using ActUtlType64Lib;
using Org.BouncyCastle.Utilities.Encoders;
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
        public int bo;
        private ActProgType64Class lpcom_ReferencesProgType = new ActProgType64Class();

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

            lpcom_ReferencesProgType.ActCpuType = 0x1003; //cpu类型
            lpcom_ReferencesProgType.ActUnitType = 0x1002; //连接方式
            lpcom_ReferencesProgType.ActProtocolType = 0x005; //通讯协议
            lpcom_ReferencesProgType.ActHostAddress = "192.168.12.30"; //hostadress
            lpcom_ReferencesProgType.ActPassword = "";
            lpcom_ReferencesProgType.ActTimeOut = 10000; ;
            lpcom_ReferencesProgType.ActDestinationPortNumber = 1023;

            Thread th = new Thread(() =>
            {
                bo = lpcom_ReferencesProgType.Open();
                //System.Windows.Threading.DispatcherObject 类：
                //从图中看WPF 中的使用到的大部分控件与其他类大多是继承 DispatcherObject 类，
                //它提供了用于处理并发和线程的基本构造。
                this.Dispatcher.Invoke(() =>
                {
                    if (bo==0)
                    {
                        this.la.Content = "已连接";
                        this.la.Background = Brushes.Green;
                    }
                    else
                    {
                        this.la.Content = "0x"+bo.ToString("X");
                        this.la.Background = Brushes.Red;
                        this.la.HorizontalContentAlignment = HorizontalAlignment.Center;
                    }
                });   
            });

            th.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lpcom_ReferencesProgType.Close();
        }
    }
}
