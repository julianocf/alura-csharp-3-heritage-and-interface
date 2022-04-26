using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Systems
{
    public class InternalSystem
    {
            public bool Login(IAuthenticable employee, string password)
            {
                bool AuthenticatedUser = employee.Authenticate(password);

                if (AuthenticatedUser)
                {
                    Console.WriteLine("Bem-vindo ao Sistema Interno do ByteBank!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Opa, senha incorreta!");
                    return false;
                }
            }
    }
}
