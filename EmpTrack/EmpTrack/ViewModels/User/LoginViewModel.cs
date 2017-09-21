using EmpTrack.Constants;
using EmpTrack.Helpers;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Diagnostics;

namespace EmpTrack.ViewModels.User
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public LoginViewModel()
        { }

        public ICommand Domain1Command
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (!String.IsNullOrEmpty(Settings.Email))
                        {
                            Application.Current.MainPage = new Views.Menu.MainPage();
                        }
                        else if (String.IsNullOrEmpty(Settings.Email))
                        {
                            Settings.DomainType = 1;
                            AuthenticationResult ar = await App.PCA1.AcquireTokenAsync(App.Scopes, App.UiParent);
                            
                            foreach (var user in App.PCA1.Users)
                            {
                                App.PCA1.Remove(user);
                            }
                            Application.Current.MainPage = new Views.Menu.MainPage();
                        }
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine("Exception " + ex.Message);
                    }
                });
            }
        }

        public ICommand Doamin2Command
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (!String.IsNullOrEmpty(Settings.Email))
                        {
                            Application.Current.MainPage = new Views.Menu.MainPage();
                        }
                        else if (String.IsNullOrEmpty(Settings.Email))
                        {
                            Settings.DomainType = 2;
                            AuthenticationResult ar = await App.PCA2.AcquireTokenAsync(App.Scopes, App.UiParent);
                            
                            foreach (var user in App.PCA2.Users)
                            {
                                App.PCA2.Remove(user);
                            }
                            Application.Current.MainPage = new Views.Menu.MainPage();
                        }
                    }
                    catch(Exception ex)
                    {
                        Debug.WriteLine("Exception "+ex.Message);
                    }
                });
            }
        }


        /// <summary>
        /// Ons the property changed.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
