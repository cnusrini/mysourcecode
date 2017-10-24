using EmpTrack.Customizations;
using EmpTrack.ViewModels.LocationDetails;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.LocationDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocationDetailPage : ContentPage
    {
        LocationDetailsViewModel locationDetailViewModel;
        List<string> parent;
        CollapsibleListView nativeListView2 = null;


        public LocationDetailPage(string buyer_id)
        {
            InitializeComponent();
            locationDetailViewModel = new LocationDetailsViewModel(buyer_id);
            parent = new List<string>();

           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
             GetLotList();
           
        }

        private async void GetLotList()
        {
            await locationDetailViewModel.FetchLotList();
            nativeListView2 = new CollapsibleListView();
            // REQUIRED: To share a scrollable view with other views in a StackLayout, it should have a VerticalOptions of FillAndExpand.
            nativeListView2.VerticalOptions = LayoutOptions.FillAndExpand;
            nativeListView2.Items = locationDetailViewModel.Vehicle;
            Content = new StackLayout
            {
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Children = {
                    nativeListView2
                }
            };
           

        }
        
    }
}