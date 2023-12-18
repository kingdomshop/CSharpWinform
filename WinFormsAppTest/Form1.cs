namespace WinFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SerializerDemo serializer = new SerializerDemo();
            Person xiaoSan = serializer.Serializer();

            this.BeginInvoke(new Action(() =>
            {
                foreach (var item in xiaoSan.GetType().GetProperties())
                {
                    Console.WriteLine(item.GetValue(xiaoSan));
                    this.label2.Text = (item.Name).ToString() + ":  " + (item.GetValue(xiaoSan)).ToString();
                    this.label2.Refresh();
                    Thread.Sleep(1000);
                }
            }));

        }


    }
}