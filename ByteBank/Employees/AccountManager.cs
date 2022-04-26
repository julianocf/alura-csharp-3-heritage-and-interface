using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class AccountManager : AuthenticableEmployee
    {
        public AccountManager(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Construtor da classe ACCOUNTMANAGER.");
        }

        public override double GetBonus()
        {
            return Wage * 0.25;
        }

        public override void WageIncrease()
        {
            Wage *= 1.05;
        }

    }
}
