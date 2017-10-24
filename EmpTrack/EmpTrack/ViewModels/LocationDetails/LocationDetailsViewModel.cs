using EmpTrack.Models;
using Services.Models;
using Services.NetworkServices.CarDetails;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.LocationDetails
{
    public class LocationDetailsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        List<LotGroupEntity> vehicle;
        public bool isbusy;
        public string BuyerID = null;


        public LocationDetailsViewModel(string buyer_id)
        {
            BuyerID = buyer_id;
            vehicle = new List<LotGroupEntity>();
        }


        public List<LotGroupEntity> Vehicle
        {
            get
            {
                return vehicle;
            }
            set
            {
                vehicle = value;
                onPropertyChanged("LotListt");
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


        public async Task FetchLotList()
        {
            //IsBusy = true;
            Vehicle.Clear();
            var cardetailservicesssss = new Services.NetworkServices.CarDetails.CarDetailsService();
            LotList lotResponse = await cardetailservicesssss.FetchLotListByBuyerID(BuyerID);
            if(lotResponse.Status)
            {
                var locations = lotResponse.vehicle.GroupBy(x => x.Location).Select(a => new { location = a.Key });

                foreach (var location in locations)
                {
                    LotGroupEntity groupEntity = new LotGroupEntity();
                    groupEntity.Location = location.location;
                    List<Vehicle> vehicles = new List<Services.Models.Vehicle>();
                  
                    foreach(Vehicle vehicle in lotResponse.vehicle)
                    {
                        if (vehicle.Location.Equals(location.location))
                            {
                            vehicles.Add(vehicle);
                        }
                    }
                    groupEntity.vehicle = vehicles;
                    Vehicle.Add(groupEntity);
                }
            }
            
        }


        private void onPropertyChanged(string data)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(data));
        }







        //public static List<EntityClass> GetList()
        //{
        //    var items = new List<EntityClass>();
        //    items.Add(new EntityClass()
        //    {
        //        Id = 0,
        //        Title = "Parent Without Child",
        //        IsSelected = true,
        //        //SelectedStateIcon = "switch_on.png",
        //        //DeselectedStateIcon = "switch_off.png",
        //    });

        //    items.Add(new EntityClass()
        //    {
        //        Id = 1,
        //        Title = "Parent 1",
        //        IsSelected = false,
        //        //SelectedStateIcon = "arrow_up.png",
        //        //DeselectedStateIcon = "arrow_down.png",
        //        ChildItems = new List<EntityClass>() {
        //            new EntityClass () {
        //                Id = 0,
        //                Title = "Child 1 ",
        //                IsSelected = true,
        //                OnClickListener = new Action<EntityClass> ((s) => Application.Current.MainPage.DisplayAlert ("Alert", "message", "cancel"))
        //            },
        //            new EntityClass () {
        //                Id = 1,
        //                Title = "Child 2 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 2,
        //                Title = "Child 3 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 3,
        //                Title = "Child 4 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 4,
        //                Title = "Child 5 ",
        //                IsSelected = true,

        //            },
        //        }
        //    });
        //    items.Add(new EntityClass()
        //    {
        //        Id = 1,
        //        Title = "Parent 2",
        //        IsSelected = false,
        //        ChildItems = new List<EntityClass>() {
        //            new EntityClass () {
        //                Id = 0,
        //                Title = "Child 1 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 1,
        //                Title = "Child 2 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 2,
        //                Title = "Child 3 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 3,
        //                Title = "Child 4 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 4,
        //                Title = "Child 5 ",
        //                IsSelected = true,

        //            },
        //        }
        //    });
        //     items.Add(new EntityClass()
        //    {
        //        Id = 1,
        //        Title = "Parent 3",
        //        IsSelected = false,
        //        ChildItems = new List<EntityClass>() {
        //            new EntityClass () {
        //                Id = 0,
        //                Title = "Child 1 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 1,
        //                Title = "Child 2 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 2,
        //                Title = "Child 3 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 3,
        //                Title = "Child 4 ",
        //                IsSelected = true,

        //            },
        //            new EntityClass () {
        //                Id = 4,
        //                Title = "Child 5 ",
        //                IsSelected = true,
        //            },
        //        }
        //    });
        //    return items;
        //}
    }
}
