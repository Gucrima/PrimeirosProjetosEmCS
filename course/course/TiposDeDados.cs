using System;

namespace Course {
    class Program {
        static void Main(string[] args) {
           
            bool completo = false; // booleano, pode ser true ou false
            char genero = 'M'; // char é um único caractere, aspas simples
            char letra = '\u0041'; // letra A em unicode
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; // long is needed for numbers larger than int, L maiusculo indica que é um long
            float n5 = 4.5f; // float é um número decimal, f indica que é um float
            double n6 = 4.5; // double é um número decimal, mais preciso que float
            string nome = "Maria"; // string é uma sequência de caracteres, aspas duplas
            object obj = "João"; // object pode ser qualquer tipo de dado, aspas duplas
            object obj2 = 4.5f; // object pode ser qualquer tipo de dado, aspas duplas

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(nome);
            Console.WriteLine(obj);
            Console.WriteLine(obj2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);



            Console.ReadKey(); 
        }
    }
}