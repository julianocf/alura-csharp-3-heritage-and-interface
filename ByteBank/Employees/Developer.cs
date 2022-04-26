using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Developer : Employee
    {
        public Developer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Construtor da classe DEVELOPER.");
        }

        public override double GetBonus()
        {
            return Wage * 0.1;
        }

        public override void WageIncrease()
        {
            Wage *= 1.15;
        }
    }
}
