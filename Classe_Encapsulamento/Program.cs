using System;
using System.Globalization;

namespace Classe_Encapsulamento {
    class Program {
        static void Main(string[] args) {

            Conta c;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            //Conta c = new Conta(numero, nome);

            Console.Write("Havera depósito inicial (s/n)?");
            char di =  char.Parse(Console.ReadLine());
            

            if (di == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, inicial);
            }
            else {
                c = new Conta(numero, nome);            
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.ReceberDeposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.FazerSaque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

        }


    }
}
