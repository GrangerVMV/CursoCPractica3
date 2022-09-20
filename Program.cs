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

            // Séptimo ejemplo: Uso del Condicional If/Else con operador lógico ||
            Console.WriteLine("Introduce la nota del primer parcial");
            float parcial1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota del segundo parcial");
            float parcial2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota del tercer parcial");
            float parcial3 = int.Parse(Console.ReadLine());
            if (parcial1 < 5 || parcial2 < 5 || parcial3 < 5) Console.WriteLine("Lo siento, tendrás que prsentarte en septiembre");
            else
            {
                float media = (parcial1 + parcial2 + parcial3) / 3;
                Console.WriteLine($"Enhorabuena, tu nota media es {media}");
            }

            // Octavo ejemplo: Uso de Else if (condición que cd se cumple sale del flujo)
            Console.WriteLine("Por favor introduce tu edad");
            edad = int.Parse(Console.ReadLine());
            if (edad < 18) Console.WriteLine("Eres un niño");
            else if (edad <30) Console.WriteLine("Eres joven aún");
            else if (edad < 60) Console.WriteLine("Eres maduro");
            else Console.WriteLine("Debes cuidarte ya");

            /*Uso de Switch:
             Evalua expresiones ctes tipo string, char o int (no admite operadores lógicos, etc)
            La expresión para cada case debe ser única (no se puede repetir)
            Cada case debe llevar un break
            */
            
            // Noveno ejemplo: Uso de Condicional Switch (expresión constante string) 
            Console.WriteLine("Por favor elija medio de transporte (coche/tren/avion)");
            string medioTransporte = Console.ReadLine();
            switch (medioTransporte)
            {
                case "coche":
                    Console.WriteLine("La velocidad media es de 100km/h");
                    break;
                case "tren":
                    Console.WriteLine("La velocidad media es de 250km/h");
                    break;
                case "avion":
                    Console.WriteLine("La velocidad media es de 600km/h");
                    break;
                default:
                    Console.WriteLine("Medio de transporte no contemplado");
                    break;
            }

            // Decimo ejemplo: Uso de Condicional Switch (expresión constante int) 
            Console.WriteLine("Introduce número de mes para el cálculo de la comisión");
            int numMes = int.Parse(Console.ReadLine());
            switch (numMes)
            {
                case 1:
                    Console.WriteLine("El mes escogido es enero");
                    break;
                case 2:
                    Console.WriteLine("El mes escogido es febrero");
                    break;
                case 3:
                    Console.WriteLine("El mes escogido es marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes escogido es abril");
                    break;
                case 5:
                    Console.WriteLine("El mes escogido es mayo");
                    break;
                case 6:
                    Console.WriteLine("El mes escogido es junio");
                    break;
                case 7:
                    Console.WriteLine("El mes escogido es julio");
                    break;
                case 8:
                    Console.WriteLine("El mes escogido es agosto");
                    break;
                case 9:
                    Console.WriteLine("El mes escogido es septiembre");
                    break;
                case 10:
                    Console.WriteLine("El mes escogido es octubre");
                    break;
                case 11:
                    Console.WriteLine("El mes escogido es noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes escogido es diciembre");
                    break;
                default:
                    Console.WriteLine("Número de mes incorrecto");
                    break;                   
            }
            
        }
    }
}
