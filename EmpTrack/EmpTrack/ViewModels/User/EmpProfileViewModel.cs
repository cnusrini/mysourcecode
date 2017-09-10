using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using EmpTrack.Models;
using Xamarin.Forms;

namespace EmpTrack.ViewModels.User
{
    public class EmpProfileViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand SaveButtonCommand { get; set; }
        private DateTime weekBeginDate = DateTime.Now;
        private TimeSpan lunchFrom, lunchTo;
        private TimeSpan normalWorkingFrom, normalWorkingTo;
        private TimeSpan emergencyBreakFrom, emergencyBreakTo;
        private DateTime plannedLeaveTo = DateTime.Now;
        private DateTime plannedLeaveFrom = DateTime.Now;
        private String name { get; set; }
        private String email { get; set; }


        private List<String> supportedModes = new List<String>() { "U.S. 70:8", "U.S. 60:7" };
        private List<string> worketTypes = new List<string>() { "Main Worker", "Co-Worker" };


        int selectedModeIndex = 0;
        int selectedWorkerTypeIndex = 0;
        int workingTimeSpent, partTimeHourSpent, totalWorkingTime, hourRemaining = 0;
        bool ifWorkingOnWeekend, ifComplianceViolation  = false;


        public EmpProfileViewModel()
        {
            SetupSaveCommand();
        }

        private void SetupSaveCommand()
        {
			SaveButtonCommand = new Command((e) =>
			{
                String selectedMode = SupportedModes[selectedModeIndex];
                String selectedWorkerType = WorketTypes[selectedWorkerTypeIndex];
                //call post server call to save data here

			});
        }

#region generic profile info region
		public String Name
		{
			get { return name; }
			set
			{
				if (name != value)
				{
					name = value;
					OnPropertyChanged("Name");
				}
			}
		}

		public String Email
		{
			get { return email; }
			set
			{
				if (email != value)
				{
					email = value;
					OnPropertyChanged("Email");
				}
			}
		}

        public bool IfWorkingOnWeekend
		{
			get { return ifWorkingOnWeekend; }
			set
			{
				if (ifWorkingOnWeekend != value)
				{
					ifWorkingOnWeekend = value;
					OnPropertyChanged("IfWorkingOnWeekend");
				}
			}
		}

		public bool IfComplianceViolation
		{
			get { return ifComplianceViolation; }
			set
			{
				if (ifComplianceViolation != value)
				{
					ifComplianceViolation = value;
					OnPropertyChanged("IfComplianceViolation");
				}
			}
		}
#endregion


#region Total working time calculationns
        public int TotalWorkingTime
		{
			get { return totalWorkingTime; }
			set
			{
                if (totalWorkingTime != value)
                {
                    totalWorkingTime = value;

                }
			    OnPropertyChanged("TotalWorkingTime");
                HourRemaining = CalculateRemainingHours();
			}
		}
		public int HourRemaining
		{
			get { return hourRemaining; }
			set
			{
				if (hourRemaining != value)
				{
					hourRemaining = value;
				}
				OnPropertyChanged("HourRemaining");
			}
		}
		public int WorkingTimeSpent
		{
			get { return workingTimeSpent; }
			set
			{
				if (workingTimeSpent != value)
				{
					workingTimeSpent = value;
					OnPropertyChanged("WorkingTimeSpent");
					TotalWorkingTime = WorkingTimeSpent + PartTimeHourSpent;
				}
			}
		}

		public int PartTimeHourSpent
		{
			get { return partTimeHourSpent; }
			set
			{
				if (partTimeHourSpent != value)
				{
					partTimeHourSpent = value;
					OnPropertyChanged("PartTimeHourSpent");
                    TotalWorkingTime = WorkingTimeSpent + PartTimeHourSpent;
				}
			}
		}

#endregion
       

#region Date & Time Picker

        public DateTime WeekBeginDate
		{
			get { return weekBeginDate; }
			set
			{
				if (weekBeginDate != value)
				{
					weekBeginDate = value;
					OnPropertyChanged("WeekBeginDate");
				}
			}
		}
		public DateTime PlannedLeaveFrom
		{
			get { return plannedLeaveFrom; }
			set
			{
				if (plannedLeaveFrom != value)
				{
					plannedLeaveFrom = value;
					OnPropertyChanged("PlannedLeaveFrom");
				}
			}
		}
		public DateTime PlannedLeaveTo
		{
			get { return plannedLeaveTo; }
			set
			{
				if (plannedLeaveTo != value)
				{
					plannedLeaveTo = value;
					OnPropertyChanged("PlannedLeaveTo");
				}
			}
		}
		
		public TimeSpan EmergencyBreakFrom
		{
			get { return emergencyBreakFrom; }
			set
			{
				if (emergencyBreakFrom != value)
				{
					emergencyBreakFrom = value;
					OnPropertyChanged("EmergencyBreakFrom");
				}
			}
		}
		public TimeSpan EmergencyBreakTo
		{
			get { return emergencyBreakTo; }
			set
			{
				if (emergencyBreakTo != value)
				{
					emergencyBreakTo = value;
					OnPropertyChanged("EmergencyBreakTo");
				}
			}
		}

		public TimeSpan NormalWorkingFrom
		{
			get { return normalWorkingFrom; }
			set
			{
				if (normalWorkingFrom != value)
				{
					normalWorkingFrom = value;
					OnPropertyChanged("NormalWorkingFrom");
				}
			}
		}
		public TimeSpan NormalWorkingTo
		{
			get { return normalWorkingTo; }
			set
			{
				if (normalWorkingTo != value)
				{
					normalWorkingTo = value;
					OnPropertyChanged("NormalWorkingTo");
				}
			}
		}

		public TimeSpan LunchTo
		{
			get { return lunchTo; }
			set
			{
				if (lunchTo != value)
				{
					lunchTo = value;
					OnPropertyChanged("LunchTo");
				}
			}
		}
		public TimeSpan LunchFrom
		{
			get { return lunchFrom; }
			set
			{
				if (lunchFrom != value)
				{
					lunchFrom = value;
					OnPropertyChanged("LunchFrom");
				}
			}
		}
#endregion

#region Simple Data Pickers
        public List<String> WorketTypes
		{
			get { return worketTypes; }
			set
			{
				if (worketTypes != value)
				{
					worketTypes = value;
					OnPropertyChanged("WorketTypes");
				}
			}
		}
		public int SelectedWorkerTypeIndex
		{
			get { return selectedWorkerTypeIndex; }
			set
			{
				if (selectedWorkerTypeIndex != value)
				{
					selectedWorkerTypeIndex = value;
					OnPropertyChanged("SelectedWorkerTypeIndex");
				}
			}
		}
		public List<String> SupportedModes
		{
			get { return supportedModes; }
			set
			{
				if (supportedModes != value)
				{
					supportedModes = value;
					OnPropertyChanged("SupportedModes");
				}
			}
		}
		public int SelectedModeIndex
		{
			get { return selectedModeIndex; }
			set
			{
				if (selectedModeIndex != value)
				{
					selectedModeIndex = value;
					OnPropertyChanged("SelectedModeIndex");
					HourRemaining = CalculateRemainingHours();
				}
			}
		}
		#endregion


		/// <summary>
		/// Calculates the remaining hours based on selected supported mode value
		/// If selected mode is 70:8 then minus total working hours from 70 else from 60
		/// </summary>
		/// <returns>The remaining hours.</returns>
		private int CalculateRemainingHours()
		{
			int remainingHours = 0;
			String selectedMode = SupportedModes[selectedModeIndex];
			if (selectedMode.Equals("U.S. 70:8"))
			{
				remainingHours = TotalWorkingTime - 70;
			}
			else
			{
				remainingHours = TotalWorkingTime - 60;
			}
			return remainingHours;
		}

        /// <summary>
        /// Ons the property changed.
        /// </summary>
        /// <param name="propertyName">Property name.</param>
        protected virtual void OnPropertyChanged(string propertyName)
		{
			var changed = PropertyChanged;
			if (changed != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

	}
}