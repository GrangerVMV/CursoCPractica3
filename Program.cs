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


            // Segundo ejemplo: Uso del Condicional If sin llaves

            Console.WriteLine("Por favor, indica si tienes reserva (Yes/No)");
            string reserva = Console.ReadLine();
            if (reserva == "Yes") // Si el If solo tiene 1 lin de código no hacen falta llaves
                Console.WriteLine("Adelante, puedes pasar porque tienes reserva"); // Esta línea siempre va a pertenecer al If y la lee o no la lee dependiendo de si cumple la condición
                Console.WriteLine("Disfruta de tu estacia"); // Esta línea no pertenece al If y por lo tanto el flujo de ejecución la lee siempre    
        }
    }
}
