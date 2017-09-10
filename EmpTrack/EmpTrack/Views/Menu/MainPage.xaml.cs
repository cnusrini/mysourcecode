using System;
using System.Collections.Generic;
using EmpTrack.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            masterPage.ListView.ItemSelected += OnItemSelected;
        }
		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;
			if (item != null)
			{
                if (!item.Title.Equals("Logout"))
                {
					Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
					masterPage.ListView.SelectedItem = null;
					IsPresented = false;
                }
                else
                {
                    //Perform logout here
                    App.Current.MainPage = new Views.Login.LoginPage();

                }
				
			}
		}
    }
}
