using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            Agencia agencia;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial? s/n: ");
            char resp = Char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.WriteLine("Entre com o deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                agencia = new Agencia(numero, titular, depositoInicial);
            }
            else {
                agencia = new Agencia(numero, titular);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(agencia);

            Console.WriteLine();

            Console.WriteLine("Entre um valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            agencia.Deposito(quantia);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(agencia);

            Console.WriteLine("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            agencia.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(agencia);


        }


    }
}
