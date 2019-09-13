using System;
using System.Collections.Generic;
using System.Text;

namespace Fernando.TesteCouchBase.Domain.Entities
{
    public class User
    {
        public string Id { get; set; }
        public string CountryCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
