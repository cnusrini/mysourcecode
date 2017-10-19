using EmpTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmpTrack.Customizations
{
    public class CollapsibleListView : View
    {
        public static readonly BindableProperty ItemsProperty =
            BindableProperty.Create("Items", typeof(List<EntityClass>), typeof(CollapsibleListView), new List<EntityClass>());

        public List<EntityClass> Items
        {
            get { return (List<EntityClass>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {

            if (ItemSelected != null)
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
        }
    }
}
