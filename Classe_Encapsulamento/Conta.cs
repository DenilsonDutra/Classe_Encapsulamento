using System;
using System.Globalization;

namespace Classe_Encapsulamento {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        //public Conta() {

        //}
                     
        public Conta(int numero, string nome) {
            Numero = numero;
            Titular = nome;
        }
        public Conta(int numero, string nome, double depositoinical):this(numero, nome) {
            ReceberDeposito(depositoinical);
        }

        /*public string Nome {
            get { return Titular; }

            set {
                if (value != null && value.Length > 1) {
                    Titular = value;
                }
            }

        }*/

        public void ReceberDeposito(double deposito) {
            Saldo = Saldo + deposito;
        }

        public void FazerSaque(double saque) {
            Saldo = Saldo - saque - 5.00;
        }
        public override string ToString() {
            return "Conta " + Numero + ", Titular: " +
                Titular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
