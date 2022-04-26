using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Assistant : Employee
    {
        public Assistant(string cpf) : base(2000, cpf)
        {
            Console.WriteLine("Construtor da classe ASSISTANT.");
        }

        public override double GetBonus()
        {
            return Wage * 0.2;
        }

        public override void WageIncrease()
        {
            Wage *= 1.1;
        }
    }
}
