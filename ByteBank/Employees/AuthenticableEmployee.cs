using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public abstract class AuthenticableEmployee : Employee, IAuthenticable
    {
        public string Password { get; set; }

        public AuthenticableEmployee(double wage, string docId)
            : base(wage, docId)
        {

        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }

    }
}
