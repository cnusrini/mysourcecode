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

namespace EmpTrack.ViewModels.User
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        //public ObservableCollection<MasterPageItem>  masterpageitem;
        List<MasterPageItem> masterPageItems;

        public LoginViewModel()
        {
            masterPageItems = new List<MasterPageItem>();
            //masterpageitem = new ObservableCollection<MasterPageItem>();
        }

        public List<MasterPageItem> masterPageItem
        {
            get
            {
                return masterPageItems;
            }
            set
            {
                masterPageItems = value;
                onPropertyChnaged("masterPageItem");
            }
        }

        private void onPropertyChnaged(string v)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(v));
        }

        public ICommand Domain1Command
        {
            get
            {
                return new Command(async () =>
                {
                    var data = await DependencyService.Get<IAuthenticator>()
                      .Authenticate(APIsConstant.authorityForDomain1, APIsConstant.graphResourceUriForDomain1, APIsConstant.clientIdForDomain1, APIsConstant.returnUriForDomain1);
                    
                    //var s = data.IdToken;
                    var userName = data.UserInfo.GivenName;
                    if (!string.IsNullOrEmpty(userName))
                    {
                        //var masterPageItems = new List<MasterPageItem>();
                        //masterPageItem.Add(new MasterPageItem
                        //{
                        //    Title = "My Profile",
                        //    IconSource = "User.png",
                        //    TargetType = typeof(Views.Profile.MyProfile)
                        //});
                        //masterPageItem.Add(new MasterPageItem
                        //{
                        //    Title = "Policy Menu",
                        //    IconSource = "Policy.png",
                        //    TargetType = typeof(Views.PolicyMenu.PolicyMenuPage)
                        //});
                        //masterPageItem.Add(new MasterPageItem
                        //{
                        //    Title = "About Us",
                        //    IconSource = "About.png",
                        //    TargetType = typeof(Views.AboutUs.AboutUsPage)
                        //});
                        //masterPageItem.Add(new MasterPageItem
                        //{
                        //    Title = "Send Feedback",
                        //    IconSource = "Feedback.png",
                        //    TargetType = typeof(Views.SendFeedback.SendFeedbackPage)
                        //});
                        //masterPageItem.Add(new MasterPageItem
                        //{
                        //    Title = "Settings",
                        //    IconSource = "Settings.png",
                        //    TargetType = typeof(Views.Settings.SettingPage2)
                        //});
                        //masterPageItem.Add(new MasterPageItem
                        //{
                        //    Title = "Logout",
                        //    IconSource = "Logout.png"
                        //});
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
                    var data = await DependencyService.Get<IAuthenticator>()
                      .Authenticate(APIsConstant.authorityForDomain2, APIsConstant.graphResourceUriForDomain2, APIsConstant.clientIdForDomain2, APIsConstant.returnUriForDomain2);


                    //var s = data.IdToken;
                    var userName = data.UserInfo.GivenName;
                    if (!string.IsNullOrEmpty(userName))
                    {
                        //var masterPageItems = new List<MasterPageItem>();
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Employee Profile",
                        //    IconSource = "User.png",
                        //    TargetType = typeof(Views.Profile.EmpProfile)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Usage",
                        //    IconSource = "Usage.png",
                        //    TargetType = typeof(Views.Usage.UsagePage)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Policy Menu",
                        //    IconSource = "Policy.png",
                        //    TargetType = typeof(Views.PolicyMenu.PolicyMenuPage)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "News",
                        //    IconSource = "News.png",
                        //    TargetType = typeof(Views.News.NewsPage)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Notifications",
                        //    IconSource = "Notifications.png",
                        //    TargetType = typeof(Views.Notifications.NotificationPage)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "About Us",
                        //    IconSource = "About.png",
                        //    TargetType = typeof(Views.AboutUs.AboutUsPage)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Send Feedback",
                        //    IconSource = "Feedback.png",
                        //    TargetType = typeof(Views.SendFeedback.SendFeedbackPage)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Settings",
                        //    IconSource = "Settings.png",
                        //    TargetType = typeof(Views.Settings.SettingPage2)
                        //});
                        //masterPageItems.Add(new MasterPageItem
                        //{
                        //    Title = "Logout",
                        //    IconSource = "Logout.png"
                        //});
                        App.Current.MainPage = new Views.Menu.MainPage();
                    }

                });
            }
        }




    }
}
