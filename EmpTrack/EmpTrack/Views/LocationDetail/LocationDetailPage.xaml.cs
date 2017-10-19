using EmpTrack.Customizations;
using EmpTrack.ViewModels.LocationDetails;
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
        public LocationDetailPage()
        {
            InitializeComponent();
            //collapsibleListView.Items = LocationDetailsViewModel.GetList();

            var nativeListView2 = new CollapsibleListView();
            // REQUIRED: To share a scrollable view with other views in a StackLayout, it should have a VerticalOptions of FillAndExpand.
            nativeListView2.VerticalOptions = LayoutOptions.FillAndExpand;

            nativeListView2.Items = LocationDetailsViewModel.GetList();


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