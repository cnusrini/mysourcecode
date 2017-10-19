using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.Auction
{
    class AuctionViewModelForUser1 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        INavigation _Navigation;
        public string lot_Num;
        public string client_ID;
        
        public AuctionViewModelForUser1(INavigation _navigation)
        {
            _Navigation = _navigation;
        }

        public string Lot_Num
        {
            get
            {
                return lot_Num;
            }
            set
            {
                lot_Num = value;
                onPropertyChanged("Lot_Num");

            }
        }

        public string Client_ID
        {
            get
            {
                return client_ID;
            }
            set
            {
                client_ID = value;
                onPropertyChanged("Client_ID");

            }
        }
        
        public ICommand FetchDetailsCommand
        {
            get
            {
                return new Command(() =>
                {
                    _Navigation.PushAsync(new Views.LotDetail.LotDetailPage());
                });
            }
        }


        public ICommand PersonalLocationCommand
        {
            get
            {
                return new Command(() =>
                {
                    _Navigation.PushAsync(new Views.ClientDetail.ClientDetailPage());
                });
            }
        }


        private void onPropertyChanged(string v)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
