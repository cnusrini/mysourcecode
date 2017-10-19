using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.LotDetail
{
    class LotDetailViewModel
    {
        INavigation _Navigation;
        public LotDetailViewModel(INavigation _navigation)
        {
            _Navigation = _navigation;
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
    }
}
