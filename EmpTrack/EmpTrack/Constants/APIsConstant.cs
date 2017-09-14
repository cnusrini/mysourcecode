using System;
namespace EmpTrack.Constants
{
    public class APIsConstant
    {
        public static String BaseURL = "http://apidocapp.azurewebsites.net/";
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

        #region



        public static string clientIdForDomain1 = " 6e32e2d5-92f7-4959-895f-d7605adf51bc\n";   // application id
        public static string authorityForDomain1 = "https://login.windows.net/common";
        public static string returnUriForDomain1 = "hhttp://empAzureAD";
        public const string graphResourceUriForDomain1 = "https://graph.windows.net";
        public static string graphApiVersionForDomain1 = "2013-11-08";

        
        public static string clientIdForDomain2 = "ca840096-e501-4452-b2f1-d5a525c0c396";   // application id
        public static string authorityForDomain2 = "https://login.windows.net/common";
        public static string returnUriForDomain2 = "http://cloudtxtruck";
        public const string graphResourceUriForDomain2 = "https://graph.windows.net";
        public static string graphApiVersionForDomain2 = "2013-11-08";
        #endregion

    }
}
 