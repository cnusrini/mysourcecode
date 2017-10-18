using EmpTrack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.LocationDetails
{
    public class LocationDetailsViewModel
    {
        public LocationDetailsViewModel()
        {
        }

        public static List<EntityClass> GetList()
        {
            var items = new List<EntityClass>();
            items.Add(new EntityClass()
            {
                Id = 0,
                Title = "Parent Without Child",
                IsSelected = true,
                //SelectedStateIcon = "switch_on.png",
                //DeselectedStateIcon = "switch_off.png",
            });

            items.Add(new EntityClass()
            {
                Id = 1,
                Title = "Parent 1",
                IsSelected = false,
                //SelectedStateIcon = "arrow_up.png",
                //DeselectedStateIcon = "arrow_down.png",
                ChildItems = new List<EntityClass>() {
                    new EntityClass () {
                        Id = 0,
                        Title = "Child 1 ",
                        IsSelected = true,
                        OnClickListener = new Action<EntityClass> ((s) => Application.Current.MainPage.DisplayAlert ("Alert", "message", "cancel"))
                    },
                    new EntityClass () {
                        Id = 1,
                        Title = "Child 2 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 2,
                        Title = "Child 3 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 3,
                        Title = "Child 4 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 4,
                        Title = "Child 5 ",
                        IsSelected = true,

                    },
                }
            });
            items.Add(new EntityClass()
            {
                Id = 1,
                Title = "Parent 2",
                IsSelected = false,
                ChildItems = new List<EntityClass>() {
                    new EntityClass () {
                        Id = 0,
                        Title = "Child 1 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 1,
                        Title = "Child 2 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 2,
                        Title = "Child 3 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 3,
                        Title = "Child 4 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 4,
                        Title = "Child 5 ",
                        IsSelected = true,

                    },
                }
            });
            items.Add(new EntityClass()
            {
                Id = 1,
                Title = "Parent 3",
                IsSelected = false,
                ChildItems = new List<EntityClass>() {
                    new EntityClass () {
                        Id = 0,
                        Title = "Child 1 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 1,
                        Title = "Child 2 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 2,
                        Title = "Child 3 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 3,
                        Title = "Child 4 ",
                        IsSelected = true,

                    },
                    new EntityClass () {
                        Id = 4,
                        Title = "Child 5 ",
                        IsSelected = true,
                    },
                }
            });
            return items;
        }
    }
}
