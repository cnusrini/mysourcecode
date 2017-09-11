using System;
using System.Net.Http;
using EmpTrack.Constants;

namespace Services.NetworkServices
{
    public class BaseService
    {
		protected HttpClient client = new HttpClient();

		public BaseService()
        {
			client = new HttpClient();
			client.Timeout = TimeSpan.FromSeconds(50.0);
			client.MaxResponseContentBufferSize = 256000;
            client.BaseAddress = new Uri(APIsConstant.BaseURL);
        }
    }
}
