using System.ComponentModel;
using System.IO.Ports;
using Modbus.Device;

namespace WinFormsTop
{
    public partial class Form1 : Form
    {

        bool flag;
        Task task;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flag = true;
            SerialPort serialPort = new SerialPort("COM2", 9600, Parity.None, 8, StopBits.One);
            try
            {
                serialPort.Open();
                var master = Modbus.Device.ModbusSerialMaster.CreateRtu(serialPort);
                Task.Run(() =>
                {
                    while (flag)
                    {
                        ushort[] values = master.ReadHoldingRegisters(1, 10, 3);

                        this.Invoke(new Action(() =>
                        {
                            this.textBox1.Text = values[0].ToString();
                            this.textBox2.Text = values[1].ToString();
                            this.textBox3.Text = values[1].ToString();
                        }));
                    }
                });
            }
            catch
            {

            }
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            flag = false;
            task.Wait();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}