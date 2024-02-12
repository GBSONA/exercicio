using Primeiro;
using System;
using System.Globalization;


namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Pessoa pessoa;

            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N) ?");
            string inicial = Console.ReadLine().ToLower();
            if(inicial == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CI);
                pessoa = new Pessoa(titular, conta, saldo);
            }
            else
            {
                pessoa = new Pessoa(titular, conta);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(pessoa);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CI);
            pessoa.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(pessoa);
            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CI);
            pessoa.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(pessoa);

        }
    }
}

