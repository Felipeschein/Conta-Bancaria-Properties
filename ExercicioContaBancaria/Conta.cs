
using System.Globalization;


namespace ExercicioContaBancaria
{
    class Conta
    {
        private string _nome;
        private int _numeroConta; 
        public double Saldo { get; private set; }
        


        public Conta() {
        }

        public Conta(string nome, int numeroConta)
        {
            _nome = nome;
            _numeroConta = numeroConta;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
        public int NumerConta
        {
            get { return _numeroConta; }
            set
            {
                if (_numeroConta == 0)
                {
                    _numeroConta = value;
                }
            }
        }

        
        public void Deposito(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo = (Saldo - valor) - 5.0;
        }

        public override string ToString()
        {
            return "Conta " + _numeroConta + ", "
                + "Titular: " + _nome + ", "
                + "Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
