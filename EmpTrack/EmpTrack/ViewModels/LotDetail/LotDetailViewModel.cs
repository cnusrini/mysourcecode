using EmpTrack.Constants;
using Services.NetworkServices.CarDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Services.Models;
using System.Diagnostics;

namespace EmpTrack.ViewModels.LotDetail
{
    class LotDetailViewModel : INotifyPropertyChanged
    {
        INavigation _Navigation;
        string LotNum = null;
        Vehicle vehiclee;
        public bool isbusy;
        public bool visibility;

        public event PropertyChangedEventHandler PropertyChanged;

        public LotDetailViewModel(INavigation _navigation , string lotNum)
        {
            _Navigation = _navigation;
            LotNum = lotNum;
        }

        public Vehicle Vehiclee
        {
            get
            {
                return vehiclee;
            }
            set
            {
                vehiclee = value;
                onPropertyChanged("Vehiclee");
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
        

        public async Task FetchCarDetailsByLotNum()
        {
            IsBusy = true;
            var carDetailByLotNum = new CarDetailsService();
            LotDetails lotResponse = await carDetailByLotNum.FetchCarDetailsByLotNumber(LotNum);
            if (lotResponse.Status)
            {
                //assign to notifuy property
                Vehiclee = lotResponse.vehicle;
                IsBusy = false;
                Visibility = true;
            }
            else
            {
                //else show error
                await Application.Current.MainPage.DisplayAlert("Error", "Somethin went wrong, check internet settings", "OK");
                Debug.WriteLine("Error Message " + lotResponse.ErrorMessage);
                IsBusy = false;
            }

        }


        private void onPropertyChanged(string data)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(data));
        }

    }
}
