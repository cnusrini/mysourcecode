using EmpTrack.ViewModels.ClientDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.ClientDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientDetailPage : ContentPage
    {
        ClientDetailViewModel clientdetailViewModel;
        public ClientDetailPage(string clientdetail)
        {
            InitializeComponent();
            clientdetailViewModel = new ClientDetailViewModel(Navigation,clientdetail);
            BindingContext = clientdetailViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FetchClientDetails();
        }

        private async void FetchClientDetails()
        {
            await clientdetailViewModel.FetchClientDetail();
        }
    }
}