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
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Net.Http;

namespace EmpTrack.ViewModels.User
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       
        public LoginViewModel()
        {}
        
        public ICommand ClientCommand
        {
            get
            {
                return new Command(async () =>
                {
                    if (!String.IsNullOrEmpty(Settings.Email))
                    {
                        App.Current.MainPage = new Views.Menu.MainPage();
                    }
                    else
                    {
                        Settings.DomainType = 2;
                        var data = await DependencyService.Get<IAuthenticator>()
                          .Authenticate(APIsConstant.authorityForDomain2, APIsConstant.graphResourceUriForDomain2, APIsConstant.clientIdForDomain2, APIsConstant.returnUriForDomain2);

                        var token = data.IdToken;
                        if (!string.IsNullOrEmpty(token))
                        {
                            Settings.UserName = data.UserInfo.GivenName;
                            Settings.Email = data.UserInfo.DisplayableId;


                            var url = "https://login.microsoftonline.com/uvsoft.onmicrosoft.com/oauth2/logout?post_logout_redirect_uri=www.google.com";

                            AuthenticationContext ac = new AuthenticationContext(APIsConstant.authorityForDomain2);
                            ac.TokenCache.Clear();

                            var client = new HttpClient();
                            var request = new HttpRequestMessage(HttpMethod.Get, url);
                            var response = await client.SendAsync(request);
                            
                            //Navigate to main page if logged in successfully
                            App.Current.MainPage = new Views.Menu.MainPage();
                        }   
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
