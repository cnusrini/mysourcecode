using EmpTrack.Constants;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.NetworkServices.LotDetails
{
    public class LotDetailsService : BaseService, ILotDetailsService
    {
        public async Task<Services.Models.LotDetails> GetLotDetails(string lot_id)
        {
            try
            {
                string r = EmpTrack.Constants.APIsConstant.FetchLotDetails + "lot_id=6b6490fd-2191-428b-bc55-0e4646b0b1f4";
                var responseJson = await client.GetAsync(r);
                string json = await responseJson.Content.ReadAsStringAsync();
                if (!json.Equals(null)) //only parse json if it contains data
                {
                    var lotresponse = JsonConvert.DeserializeObject<Services.Models.LotDetails>(json);
                    return lotresponse;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("FetchMeditationBaseOn Id", ex.Message);
            }

            return null;

            //var content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");
            //HttpResponseMessage responseJson = await client.GetAsync(APIsConstant.FetchLotDetails, content);
            //var json = await responseJson.Content.ReadAsStringAsync();
            //var lotResponse = JsonConvert.DeserializeObject<Services.Models.LotDetails>(json);
            //return lotResponse;
        }
    }
}
