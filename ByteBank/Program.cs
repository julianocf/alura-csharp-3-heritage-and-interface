using ByteBank.Employees;
using ByteBank.Systems;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao ByteBank!");

            InternalSystem internalSystem = new InternalSystem();

            BonusManager bonusManager = new BonusManager();

            Assistant carlos = new Assistant("546.879.157-20");
            carlos.Name = "Carlos";

            Director roberta = new Director("454.658.148-3");
            roberta.Name = "Roberta";
            roberta.Password = "123456";

            bonusManager.Register(carlos);
            bonusManager.Register(roberta);

            if (internalSystem.Login(roberta, "123456"))
            {
                Console.WriteLine("Bonificação do Carlos: " + carlos.GetBonus());
                Console.WriteLine("Bonificação da Roberta: " + roberta.GetBonus());
                Console.WriteLine("Total de bonificações: " + bonusManager.GetTotalBonus());
            }
            Console.ReadLine();

        }
    }
}
