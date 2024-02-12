using System;
using static System.Net.Mime.MediaTypeNames;


namespace Primeiro
{
    internal class Pessoa
    {
        private string _titular;
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        public Pessoa(string nome, int conta) {
            _titular = nome;
            Conta = conta;
        }
        public Pessoa(string nome, int conta, double saldoInicial) :this(nome, conta)
        {
            Deposito(saldoInicial);
        }

        public string Nome { 
            get { return _titular; }
            set {
                if (value != null && value.Length > 1 )
                {
                    _titular = value;
                }
            }
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - 5 - saque;
        }

        public override string ToString()
        {
            return "Conta " + Conta + ", Titular: " + _titular + ", Saldo: R$:" + Saldo.ToString("F2");
        }

    }
}
