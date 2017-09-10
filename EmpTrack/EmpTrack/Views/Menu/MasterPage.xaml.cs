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
                TargetType = typeof(Profile.MyProfile)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Employee Profile",
                TargetType = typeof(Profile.EmpProfile)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Privacy Policy",
				TargetType = typeof(PrivacyPolicy.PrivacyPolicyPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Terms Of Use",
				TargetType = typeof(TermsOfUse.TermsOfUsePage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Data Usage Policy",
				TargetType = typeof(DataUsage.DataUsagePolicyPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "About Us",
				TargetType = typeof(AboutUs.AboutUsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Contact Us",
				TargetType = typeof(ContactUs.ContactUsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Settings",
				TargetType = typeof(Settings.SettingPage2)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Usage",
                TargetType = typeof(DataUsage.UsagePage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "News",
				TargetType = typeof(News.NewsPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Notifications",
				TargetType = typeof(Notifications.NotificationPage)
			});
			masterPageItems.Add(new MasterPageItem
			{
				Title = "Logout"
			});

			listView.ItemsSource = masterPageItems;
        }
    }
}
