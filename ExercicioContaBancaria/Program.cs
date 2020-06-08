using System;
using System.Globalization;

namespace ExercicioContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Entre com o número da conta: ");
            c.NumerConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            c.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char op = char.Parse(Console.ReadLine());

            if (op == 's' || op == 'S')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double depositoIncial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c.Deposito(depositoIncial);
            }

            
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine();
            
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);


        }
    }
}
