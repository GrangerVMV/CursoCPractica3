using System;

namespace CursoCPractica3_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            bool haceFrio = false;
            Console.WriteLine($"El valor de la variable booleana <haceFrio> negada (!) es {!haceFrio}"); // usamos el operador ! para negar el valor de una variable 

            // Primer ejemplo: Uso del Condicional If

            Console.WriteLine("Por favor, introduce tu edad");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18) 
            {
                Console.WriteLine("Adelante, puedes pasar porque eres mayor de edad");
            }
        }
    }
}
