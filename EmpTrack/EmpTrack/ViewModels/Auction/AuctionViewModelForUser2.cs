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
    class AuctionViewModelForUser2 : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        INavigation _Navigation;
        public string lot_Num;
        public string buyer_ID;
        public bool status;

        public AuctionViewModelForUser2(INavigation _navigation)
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

        public string Buyer_ID
        {
            get
            {
                return buyer_ID;
            }
            set
            {
                buyer_ID = value;
                onPropertyChanged("Buyer_ID");

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
                    if (String.IsNullOrEmpty(Lot_Num) && String.IsNullOrEmpty(Buyer_ID))
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
                        else if (!String.IsNullOrEmpty(Buyer_ID))
                        {
                            _Navigation.PushAsync(new Views.LocationDetail.LocationDetailPage());
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
