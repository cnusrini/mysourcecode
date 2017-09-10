using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.User
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoginCommand
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage = new Views.Menu.MainPage();
                });
            }
        }
    }
}
