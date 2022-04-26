using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("Construtor da classe DESIGNER.");
        }

        public override double GetBonus()
        {
            return Wage * 0.17;
        }

        public override void WageIncrease()
        {
            Wage *= 1.11;
        }
    }
}
