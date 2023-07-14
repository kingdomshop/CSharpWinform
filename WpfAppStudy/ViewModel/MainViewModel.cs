using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfAppStudy.Base;

namespace WpfAppStudy.ViewModel
{
    class MainViewModel:NotifyPropertyBase
    {
        private UIElement? _mainContent;
        public UIElement MainContent {
            get { return _mainContent; }
            set {
                Set<UIElement>(ref _mainContent, value);
            }
        }

        public CommandBase TabChangedCommand { get;set; }

        public MainViewModel()
        {
            TabChangedCommand = new CommandBase(OnTapChange);
            OnTapChange("WpfAppStudy.dll|WpfAppStudy.View.SystermMointor");
        }

        private void OnTapChange(Object o)
        {
            if (o == null) return;
            String[] strValue = o.ToString().Split('|');
            Assembly assembly = Assembly.LoadFrom(strValue[0]);
            Type type = assembly.GetType(strValue[1]);
            this.MainContent = (UIElement)Activator.CreateInstance(type);
        }
    }
}
    