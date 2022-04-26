using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public string DocId { get; private set; }
        public double Wage { get; protected set; }
        public static int TotalEmployees { get; private set; }

        public Employee(double wage, string docId)
        {
            Console.WriteLine("Construtor da classe EMPLOYEE.");

            TotalEmployees++;
            DocId = docId;
            Wage = wage;
        }
        public abstract double GetBonus();
        public abstract void WageIncrease();
    }
}
