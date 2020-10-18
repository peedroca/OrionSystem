using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class UserResp
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int typeUser { get; set; }
        public int typeAccess { get; set; }
    }

    public class UserTest
    {
        public UserResp user { get; set; }
        public string token { get; set; }
    }

}
