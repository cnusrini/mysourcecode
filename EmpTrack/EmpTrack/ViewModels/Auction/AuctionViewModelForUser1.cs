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
        public bool status;

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

        public bool Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                onPropertyChanged("Status");
            }
        }

        public ICommand SubmitCommand
        {
            get
            {
                return new Command(() =>
                {
                    if (String.IsNullOrEmpty(Lot_Num) && String.IsNullOrEmpty(Client_ID))
                    {
                        Status = true;
                    }
                    else
                    {
                        Status = false;
                        if (!String.IsNullOrEmpty(Lot_Num))
                        {
                            _Navigation.PushAsync(new Views.LotDetail.LotDetailPage());
                        }
                        else if (!String.IsNullOrEmpty(Client_ID))
                        {
                            _Navigation.PushAsync(new Views.ClientDetail.ClientDetailPage());
                        }
                    }
                });
            }
        }

        private void onPropertyChanged(string v)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(v));
        }
    }
}
