using EmpTrack.ViewModels.LotDetail;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.LotDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LotDetailPage : ContentPage
    {
        LotDetailViewModel lotdetailViewModel;
        public LotDetailPage(string lotnum)
        {
            InitializeComponent();
            lotdetailViewModel = new LotDetailViewModel(Navigation , lotnum);
            BindingContext = lotdetailViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FetchCarDetails();
            
        }

        private async void FetchCarDetails()
        {
            await lotdetailViewModel.FetchCarDetailsByLotNum();          
        }
    }
}