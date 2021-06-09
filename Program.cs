using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que captura una letra mayuscula y la convierte en minuscula");
            Console.WriteLine("Coloque una letra: ");
            var letter = Console.ReadLine();
            if (letter == "A")
            {
                Console.WriteLine("La minuscula correspondiente es: a");
            }
            else if (letter == "B")
            {
                Console.WriteLine("La minuscula correspondiente es: b");
            }
            else
            {
                Console.WriteLine("El valor que digitaste no es valido");
            }

        }
    }
}
