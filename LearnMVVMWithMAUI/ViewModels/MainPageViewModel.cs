using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using LearnMVVMWithMAUI.Models;

namespace LearnMVVMWithMAUI.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand SomeCommand1 { get; set; }
        public ICommand SomeCommand2 { get; set; }

        public SomeModel Model { get; set; }
        public MainPageViewModel()
        {
            Model = new SomeModel
            {
                SomeString = "Test"
            };
            SomeCommand1 = new Command(DoSomeCommand1);
            SomeCommand2 = new Command(DoSomeCommand2);
        }

        private void DoSomeCommand1()
        {
            Model.SomeString = DateTime.Now.Ticks.ToString();
        }

        private void DoSomeCommand2()
        {
            App.Current.MainPage.DisplayAlert("", Model.SomeString, "ok");
        }
    }
}
