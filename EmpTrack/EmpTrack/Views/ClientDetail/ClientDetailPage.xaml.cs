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
        public ClientDetailPage()
        {
            InitializeComponent();
            clientdetailViewModel = new ClientDetailViewModel(Navigation);
            BindingContext = clientdetailViewModel;
        }
    }
}