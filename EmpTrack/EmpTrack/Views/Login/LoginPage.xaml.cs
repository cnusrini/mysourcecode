using System;
using System.Collections.Generic;
using EmpTrack.ViewModels.User;
using Xamarin.Forms;
using EmpTrack.Interfaces;
using EmpTrack.Constants;

namespace EmpTrack.Views.Login
{
    public partial class LoginPage : ContentPage
    {
        LoginViewModel loginViewModel;
        public LoginPage()
        {
            InitializeComponent();
			loginViewModel = new LoginViewModel();
            BindingContext = loginViewModel;
        }
        
    }
}
