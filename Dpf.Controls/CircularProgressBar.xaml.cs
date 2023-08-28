using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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

namespace Dpf.Controls
{
    /// <summary>
    /// CircularProgressBar.xaml 的交互逻辑
    /// </summary>
    public partial class CircularProgressBar : UserControl
    {


        public double value
        {
            get { return (double)GetValue(valueProperty); }
            set { SetValue(valueProperty, value); }
        }
            
        // Using a DependencyProperty as the backing store for value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty valueProperty =
            DependencyProperty.Register("value", typeof(double), typeof(CircularProgressBar), 
                new PropertyMetadata(default(double),new PropertyChangedCallback(OnPropertyChanged)));


        public CircularProgressBar()
        {
            InitializeComponent();
            this.SizeChanged += CircularProgressBar_SizeChanged;
        }

        private void CircularProgressBar_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.UpdateValue();
        }



        public Brush BackColor
        {
            get { return (Brush)GetValue(backcolorProperty); }
            set { SetValue(backcolorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for backcolor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty backcolorProperty =
            DependencyProperty.Register("Backcolor", typeof(Brush), typeof(CircularProgressBar), new PropertyMetadata(Brushes.LightGray));



        public Brush ForeColor
        {
            get { return (Brush)GetValue(ForeColorProperty); }
            set { SetValue(ForeColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ForeColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ForeColorProperty =
            DependencyProperty.Register("ForeColor", typeof(Brush), typeof(CircularProgressBar), new PropertyMetadata(Brushes.Orange));


        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as CircularProgressBar).UpdateValue();
        }
        private void UpdateValue()
        {
            this.layout.Width = Math.Min(this.RenderSize.Width, this.RenderSize.Height);
            double radius = Math.Min(this.RenderSize.Width, this.RenderSize.Height) / 2;

            if (radius <= 0) return;

            double newValue = this.value % 100.0;
            double newX = 0.0, newY = 0.0;
            newX = radius + (radius - 3) * Math.Cos((newValue % 100.0 * 3.6 - 90) * Math.PI / 180);
            newY = radius + (radius - 3) * Math.Sin((newValue % 100.0 * 3.6 - 90) * Math.PI / 180);

            String pathDataStr = "M{0} 3A{1} {1} 0 {4} 1 {2} {3}"; //M{0}起始位置 {4}优势弧

            pathDataStr = string.Format(pathDataStr,
               radius + 0.01,
               radius - 3,
               newX,
               newY,
               value < 50 && newValue>0 ? 0 : 1
               );

            var converter = TypeDescriptor.GetConverter(typeof(Geometry));
            this.path.Data = (Geometry)converter.ConvertFrom(pathDataStr);
        }
    }
}
