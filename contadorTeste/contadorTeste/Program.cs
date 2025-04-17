using System;

namespace BackContador {

    class Program {
        static int contador = 0;

        static void Main(string[] args) {
            Console.WriteLine("Bem-vindo ao contador!");
            Console.WriteLine($"Contador atual: {contador}");

            Console.WriteLine("Pressione Enter para incrementar o contador...");
            while (true) {
                Console.ReadLine();
                contador++;
                Console.WriteLine($"Contador atualizado: {contador}");
            }
        }
    }
}
