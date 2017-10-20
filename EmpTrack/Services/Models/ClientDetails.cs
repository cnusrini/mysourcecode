using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Models
{
    public class ClientDetails : BaseServerResponse
    {
        public string clientid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
    }
}
