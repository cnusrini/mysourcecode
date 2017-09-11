using System;
namespace EmpTrack.Constants
{
    public class APIsConstant
    {
        public static String BaseURL = "http://employetracking.azurewebsites.net/";
       
        #region  web apis 
        public static String SaveEmpDetailAPI = "api/employee/request/profile";
		#endregion

		#region Fields Constatns
		public const string Email = "email";
		public const string ModeSupported = "modeSupported";
		public const string EmployeeType = "employeeType";
		public const string WorkerName = "workerName";
		public const string WorkBeginWeek = "workBeginWeek";
		public const string TimeHoursSpent = "timeHoursSpent";
		public const string PartTimeSpentHour = "partTimeSpentHour";
		public const string TotalWorkingHour = "totalWorkingHour";
		public const string TotalRemaingHour = "totalRemaingHour";
		public const string LunchTime = "lunchTime";
		public const string NormalWorkingHour = "normalWorkingHour";
		public const string EmergencyBreakHour = "emergencyBreakHour";
		public const string IfWorkingWeekend = "ifWorkingWeekend";
		public const string IfComplianceVoilation = "ifComplianceVoilation";
        public const string WorkerAuthorization = "workerAuthorization";
		#endregion
	}
}
 