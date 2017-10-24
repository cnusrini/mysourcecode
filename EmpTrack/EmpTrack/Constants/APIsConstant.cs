using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpTrack.Constants
{
    public class APIsConstant
    {
        //public static String BaseURL = "http://apidocapp.azurewebsites.net/";
		//public static String BaseURL = "http://integratedmobile.azurewebsites.net/";
        public static String BaseURL = "http://30474357.ngrok.io/api/";
        #region  web apis 
        public static String SaveEmpDetailAPI = "api/employee/request/profile";
        public static String FetchLotDetails = "http://e5ec19fb.ngrok.io/api/vehicle/request/get/detail?";
        public static String FetchClientDetails = "http://80b932ea.ngrok.io/api/client/request/get/detail?";
        public static String FetchLotList = "vehicle/request/get/detail/buyerId?";

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
        public const string Lot_ID = "lot_id";
		#endregion

		#region Domains
		//public static string ClientIDForDomain1 = "5df5d1a2-6581-41d2-87ec-52dc48f14461";
		//public static string ClientIDForDomain2 = "ee6b1ba3-99b1-4d62-9ef9-833c8c5b31fb";
		public static string ClientIDForDomain1 = "5560b06a-cdce-45e3-a7b4-92b17b281045";
		public static string ClientIDForDomain2 = "5ef95ad6-6928-4e05-9d10-0957fbe544b8";
        public static string RedirectURLDomain = "ilhob://auth";  

		#endregion
	}
}
