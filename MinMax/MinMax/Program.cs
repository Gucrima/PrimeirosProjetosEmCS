using System;
using System.Globalization; // Importa o namespace System.Globalization para usar CultureInfo

namespace MinMax {
    class Program {
        static void Main(string[] args) {


            //exemplo de uso de tipos numéricos em C#

            int n1 = int.MinValue;
            int n2 = int.MaxValue;
            sbyte n3 = sbyte.MinValue;
            decimal n4 = decimal.MaxValue;
            double saldo = 10.203;

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(saldo.ToString("F3")); // formata com 3 casas decimais
            Console.WriteLine(saldo.ToString("F2")); // formata com 2 casas decimais
            Console.WriteLine(saldo.ToString("F1")); // formata com 1 casas decimais
            Console.WriteLine(saldo.ToString("F0")); // formata com 0 casas decimais
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture)); // formata com 3 casas decimais usando ponto como separador decimal

            // exemplo de uso de tipos numéricos com interpolação e formatação
            int idade = 32;
            double salario = 12.3456;
            string nome = "João";
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo de {salario:F2} reais");

            // exemplo de uso de tipos numéricos com formatação usando interpolação
            Console.WriteLine($"{nome} tem {idade} anos e tem o saldo de {salario:F2} reais");

            // exemplo com concatenação
            Console.WriteLine(nome + " tem " + idade + " anos e tem o saldo de " + salario.ToString("F2") + " reais");

        }
    }
}