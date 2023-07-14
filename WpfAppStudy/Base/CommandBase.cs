using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppStudy.Base
{
    class CommandBase : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        public Action<Object> DoExecute { set; get; }
        public CommandBase() { }
        public CommandBase(Action<object> action) //Action 委托存储必须有一个参数和返回值的方法
        {
            DoExecute = action;
        }
        public bool CanExecute(object parameter)    //是否执行
        {
            return true;
        }
        public void Execute(object parameter)   //invoke 线程间同步执行调用
        {
            this.DoExecute?.Invoke(parameter);
        }

    }
}
