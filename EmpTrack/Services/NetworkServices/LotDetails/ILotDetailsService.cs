using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.NetworkServices.LotDetails
{
    public interface ILotDetailsService
    {
        Task<Services.Models.LotDetails> GetLotDetails(string lot_id);
    }
}
