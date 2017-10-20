using Services.Models;
using Services.NetworkServices.ClientDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.ClientDetail
{
    class ClientDetailViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        INavigation _Navigation;
        ClientDetails clientDetail;
        string ClientID = null;
        public bool isbusy;
        public bool visibility;


        public ClientDetailViewModel(INavigation _navigation,string clientid)
        {
            _Navigation = _navigation;
            ClientID = clientid;
        }

        public ClientDetails ClientDetail
        {
            get
            {
                return clientDetail;
            }
            set
            {
                clientDetail = value;
                onPropertyChanged("ClientDetail");
            }
        }

        public bool IsBusy
        {
            get
            {
                return isbusy;
            }
            set
            {
                isbusy = value;
                onPropertyChanged("IsBusy");
            }
        }

        public bool Visibility
        {
            get
            {
                return visibility;
            }
            set
            {
                visibility = value;
                onPropertyChanged("Visibility");
            }
        }


        public ICommand GetQuoteCommand
        {
            get
            {
                return new Command(() =>
                {
                    _Navigation.PushAsync(new Views.Pricing.PricingPage());
                });
            }
        }

        public async Task FetchClientDetail()
        {
            var clientdetailservice = new ClientDetailsService();
            ClientDetails clientResponse = await clientdetailservice.FetchClientDetails(ClientID);
            if(clientResponse.Status)
            {
                ClientDetail = clientResponse;
                IsBusy = false;
                Visibility = true;
            }
            else
            {
                //else show error
                await Application.Current.MainPage.DisplayAlert("Error", "Somethin went wrong, check internet settings", "OK");
                Debug.WriteLine("Error Message " + clientResponse.ErrorMessage);
                IsBusy = false;
            }

        }


        private void onPropertyChanged(string data)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(data));
        }

    }
}
