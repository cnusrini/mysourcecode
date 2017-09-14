using System;
using System.Collections.Generic;
using EmpTrack.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
		public ListView ListView { get { return listView; } }
        public MasterPage()
        {
            InitializeComponent();
			var masterPageItems = new List<MasterPageItem>();
			masterPageItems.Add(new MasterPageItem
			{
				Title = "My Profile",
                IconSource = "User.png",
                TargetType = typeof(Profile.MyProfile)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Employee Profile",
                IconSource= "User.png",
                TargetType = typeof(Profile.EmpProfile)
			});
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Dashboard",
                IconSource = "Dashboard.png",
                TargetType = typeof(Dashboard.DashboardPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Policy Menu",
                IconSource = "Policy.png",
                TargetType = typeof(PolicyMenu.PolicyMenuPage)
            });
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Usage",
                IconSource= "Usage.png",
                TargetType = typeof(Usage.UsagePage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "News",
                IconSource= "News.png",
				TargetType = typeof(News.NewsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Notifications",
                IconSource= "Notifications.png",
				TargetType = typeof(Notifications.NotificationPage)
			});
            masterPageItems.Add(new MasterPageItem
            {
                Title = "About Us",
                IconSource= "About.png",
                TargetType = typeof(AboutUs.AboutUsPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Send Feedback",
                IconSource= "Feedback.png",
                TargetType = typeof(SendFeedback.SendFeedbackPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Settings",
                IconSource= "Settings.png",
                TargetType = typeof(Settings.SettingPage2)
            });
            masterPageItems.Add(new MasterPageItem
			{
				Title = "Logout",
                IconSource= "Logout.png"
            });

			listView.ItemsSource = masterPageItems;
        }
    }
}
