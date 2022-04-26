using ByteBank.Systems;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    class Director : AuthenticableEmployee
    {
        public Director(string docId) : base(5000, docId)
        {
            Console.WriteLine("Construtor da classe DIRECTOR.");
        }

        public override double GetBonus()
        {
            return Wage * 0.5;
        }
        public override void WageIncrease()
        {
            Wage *= 1.15;
        }
    }
}
