using System;
using System.Collections.Generic;
using EmpTrack.ViewModels.User;
using Xamarin.Forms;

namespace EmpTrack.Views.Profile
{
    public partial class EmpProfile : ContentPage
    {
        EmpProfileViewModel viewModel;
        public EmpProfile()
        {
            InitializeComponent();
            viewModel = new EmpProfileViewModel();
            BindingContext = viewModel;
        }
    }
}
