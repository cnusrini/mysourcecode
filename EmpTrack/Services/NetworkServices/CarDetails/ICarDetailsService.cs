using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.NetworkServices.CarDetails
{
    public interface ICarDetailsService
    {
        Task<Services.Models.LotDetails> FetchCarDetailsByLotNumber(string lot_id); // get car detail against lot number
    }
}
