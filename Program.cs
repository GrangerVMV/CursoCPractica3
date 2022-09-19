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


            // Tercer ejemplo: Uso del Condicional If/Else sin llaves y con condición booleana

            Console.WriteLine("Vamos a evaluar si puedes conducir vehículos");
            bool carnet=false;
            if (carnet) Console.WriteLine("Enhorabuena, puedes conducir vehículos");// Entra si la variables es true, no es necesario poner carnet==true
            else Console.WriteLine("Lo siento, no puedes conducir vehículos");// Entra si la condición del if no se cumple. Si tuviera más de una línea habría que poner llaves


            // Cuarto ejemplo: Uso del Condicional If/Else con operador lógico &&
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Por favor, introduce tu edad");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique si tiene carnet de conducir (Yes/No)");
            string carnet2 = Console.ReadLine();
            if (carnet2 == "Yes" && edad >= 18) Console.WriteLine("Enhorabuena, puedes conducir vehiculos");
            else Console.WriteLine("Lo siento no puedes conducir vehiculos");

            // Quinto ejemplo: Uso de 2 Condicionales If/Else no anidados (condiciones encadenadas)
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Por favor, introduce tu edad");
            edad = int.Parse(Console.ReadLine());
            carnet2 = "no";
            if (edad >= 18)
            {
                Console.WriteLine("Por favor, indique si tiene carnet de conducir (Yes/No)");
                carnet2 = Console.ReadLine();
            }
            if (edad >= 18 && carnet2=="Yes") Console.WriteLine("Enhorabuena, puedes conducir vehiculos");
            else Console.WriteLine("Lo siento no puedes conducir vehiculos");

            // Sexto ejemplo: Uso de 2 Condicionales If/Else anidados (comparando cadenas texto)
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");
            Console.WriteLine("Por favor, introduce tu edad");
            edad = int.Parse(Console.ReadLine());
            if (edad < 18) Console.WriteLine("Lo siento no puedes conducir vehiculos");
            else 
            {
                Console.WriteLine("Por favor, indique si tiene carnet de conducir (Yes/No)");
                carnet2 = Console.ReadLine();
                int compara = String.Compare(carnet2, "Yes", true);
                if (compara == 0) Console.WriteLine("Enhorabuena, puedes conducir un vehículo");
                else Console.WriteLine("Lo siento, no puedes conducir vehículos");
            }
        }
    }
}
