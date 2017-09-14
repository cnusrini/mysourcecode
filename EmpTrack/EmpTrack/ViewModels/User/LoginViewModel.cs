using EmpTrack.Constants;
using EmpTrack.Interfaces;
using EmpTrack.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using EmpTrack.Helpers;

namespace EmpTrack.ViewModels.User
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       
        public LoginViewModel()
        {}
        public ICommand Domain1Command
        {
            get
            {
                return new Command(async () =>
                {
	                Settings.DomainType = 1;
					var data = await DependencyService.Get<IAuthenticator>()
					  .Authenticate(APIsConstant.authorityForDomain1, APIsConstant.graphResourceUriForDomain1, APIsConstant.clientIdForDomain1, APIsConstant.returnUriForDomain1);

					var token = data.IdToken;
					if (!string.IsNullOrEmpty(token))
					{
						Settings.UserName = data.UserInfo.GivenName;
					                   Settings.Email = data.UserInfo.DisplayableId;
					    App.Current.MainPage = new Views.Menu.MainPage();
					}
                });
            }
        }

        public ICommand Domain2Command
        {
            get
            {
                return new Command(async () =>
                {
                    Settings.DomainType = 2;
                    var data = await DependencyService.Get<IAuthenticator>()
                      .Authenticate(APIsConstant.authorityForDomain2, APIsConstant.graphResourceUriForDomain2, APIsConstant.clientIdForDomain2, APIsConstant.returnUriForDomain2);
                    
                    var token = data.IdToken;
                    if (!string.IsNullOrEmpty(token))
                    {
						Settings.UserName = data.UserInfo.GivenName;
                        Settings.Email = data.UserInfo.DisplayableId;
                        App.Current.MainPage = new Views.Menu.MainPage();
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
