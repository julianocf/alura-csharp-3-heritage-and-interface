using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class CommercialPartner : IAuthenticable
    {
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
