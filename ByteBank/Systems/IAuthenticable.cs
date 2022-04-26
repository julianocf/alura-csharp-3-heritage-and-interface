using ByteBank.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Systems
{
    public interface IAuthenticable
    {
        bool Authenticate(string password);
    }
}
