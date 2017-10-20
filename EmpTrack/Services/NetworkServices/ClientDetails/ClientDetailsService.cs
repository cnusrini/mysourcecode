﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.Models;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Services.NetworkServices.ClientDetails
{
    class ClientDetailsService : BaseService, IClientDetailsService
    {
        public async Task<Models.ClientDetails> FetchClientDetails(string clientid)
        {
            try
            {
                string r = EmpTrack.Constants.APIsConstant.FetchLotDetails + "lot_id=6b6490fd-2191-428b-bc55-0e4646b0b1f4";
                var responseJson = await client.GetAsync(r);
                string json = await responseJson.Content.ReadAsStringAsync();
                if (!json.Equals(null)) //only parse json if it contains data
                {
                    var lotresponse = JsonConvert.DeserializeObject<Services.Models.ClientDetails>(json);
                    return lotresponse;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("FetchMeditationBaseOn Id", ex.Message);
            }

            return null;
        }
    }
}
