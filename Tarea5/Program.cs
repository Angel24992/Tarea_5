using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Desarrolla un programa que genere un número aleatorio entre 1 y 100 y le pida al usuario que lo adivine. 
             * El programa debe utilizar un bucle while para seguir pidiendo intentos hasta que el usuario acierte el número. 
             
            // Se crea una instancia de clase Random para generar números aletorios
            Random random = new Random();
            // Genera un número aleatorio entre 1 y 100
            int numAleatorio = random.Next(1, 101);
            // Variable para almacenar el intento del usuario
            int intento = 0;

            // Mensaje de bienvenida al juego
            Console.WriteLine("Hola bienvenido, adivina que número estoy pensando del 1 al 100");

            // Bucle que se ejecuta hasta que el usaurio adivine el número
            while (intento != numAleatorio) {
                // Se solicita al usuario que ingrese su intento
                Console.Write("Ingresa tu número: ");
                intento = int.Parse(Console.ReadLine());

                // Verifica si el numero ingresado es menor, mayor o igual al número aleatorio
                if (intento < numAleatorio) {
                    Console.WriteLine("Demasiado bajo. Prueba otra vez.");
                }
                else if (intento > numAleatorio) {
                    Console.WriteLine("Demasiado alto. Prueba otra vez.");
                }
                else
                {
                    Console.WriteLine($"Felecitaciones. Adivinaste!!! El numero aleatorio es: {numAleatorio}\n" +
                        $"Gracias por jugar");
                }
            }
            Console.ReadKey();
            */


            /*
             * 2. Crea un programa que utilice un bucle while para contar la cantidad 
             * de números pares desde 1 hasta un número ingresado por el usuario. 
             
            // Información al usuario de lo que hace el programa
            Console.WriteLine("Hola, este programa te va ayudar a contar los numeros pares.\n" +
                "Desde el 1 hasta el número que tu ingreses.");
            // Solicita al usuario ingresar un número
            Console.Write("Por favor ingrese un número entero: ");
            // Se lee la entrada del usuario como cadena para posterior verificación que sea un entero
            string numeroIngresado = Console.ReadLine();

            // try: intenta convertir la entrada del usuario a un entero
            try
            {
                // Convierte la entrada del usuario a un entero
                int numero = int.Parse(numeroIngresado);

                // Inicializa un contador para los números pares
                int contadorPares = 0;
                // Inicializa la variable de control del bucle
                int i = 1;

                // Bucle que se ejecuta mientras i sea menor o igual al número ingresado
                while (i <= numero)
                {
                    // Comprueba si el número i es par
                    if (i % 2 == 0)
                    {
                        // Incrementa el contador si el número es par
                        contadorPares++;
                    }
                    // Incrementa el contador del bucle
                    i++;
                }
                // Muestra el resultado
                Console.WriteLine($"La cantidad de numeros pares desde 1 a {numero} es de {contadorPares}");
            }
            catch (FormatException)
            {
                // Maneja la excepción si la entrada del usuario no es número valido
                Console.WriteLine("Número ingresado no valido");
            }
            Console.ReadKey();
            */


            /*
             * 3. Escribe un programa que utilice un bucle do-while para imprimir en la 
             * consola una secuencia de números de 10 a 0, de forma decreciente.
             
            // Se inicializa la variable con valor 10
            int num3_1 = 10;

            // Bucle que se ejecuta mientras que la condición sea verdadera
            do
            {
                // Imprime el número actual en la consola
                Console.WriteLine(num3_1);
                // Decrementa el número en 1
                num3_1--;
            }
            // Condición del bucle para que se detenga en 0
            while (num3_1 >= 0);

            Console.ReadKey();
            */


            /*
             * 4. Desarrolla un programa que presente un menú interactivo al usuario utilizando un bucle while. El menú debe permitir 
             * al usuario elegir entre diferentes opciones, como realizar una operación matemática o salir del programa. 
            
            // Indicación al usuario lo que puedes hacer con el programa
            Console.WriteLine("Bienvenido. Del siguiente menu escoge la opcion que desees\n\n" +
                "1. Para realizar una suma\n" +
                "2. Para realizar una resta\n" +
                "3. Para realizar una multiplicacion\n" +
                "4. Para realizar una division\n" +
                "5. Para realizar una salir\n");

            // Se solicita al usuario que escoja una opción del menu anterior
            Console.Write("Ingresa la opción: ");
            int num4_I = int.Parse(Console.ReadLine());

            // Bucle indica que el programa siga si el numero ingresado es diferente a 5
            while (num4_I != 5)
            {
                // Condición para que el usuario escoja los valores del 1 al 4
                if (num4_I >= 1 && num4_I <= 4)
                {
                    // Se solicita al usuario que ingrese dos números para realizar la peración
                    Console.WriteLine("\nIngresa dos numeros para realizar la operacion elegida\n");
                    Console.Write("Ingrese 1er número: ");
                    int num4_1 = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese 2do número: ");
                    int num4_2 = int.Parse(Console.ReadLine());

                    // Realiza la opreación seleccionada
                    switch (num4_I)
                    {
                        case 1:
                            Console.WriteLine($"\nLa suma de {num4_1} + {num4_2} = {num4_1 + num4_2}");
                            break;

                        case 2:
                            Console.WriteLine($"\nLa resta de {num4_1} - {num4_2} = {num4_1 - num4_2}");
                            break;

                        case 3:
                            Console.WriteLine($"\nLa multiplicación de {num4_1} * {num4_2} = {num4_1 * num4_2}");
                            break;

                        case 4:
                            // Condición para dividir diferente a 0
                            if (num4_2 != 0)
                            {
                                // Cambio en la respuesta de entero a decimal
                                Console.WriteLine($"\nLa división de {num4_1} / {num4_2} = {(double)num4_1 / num4_2}");
                            }
                            else
                            {
                                Console.WriteLine("\nError no se puede dividir para cero");
                            }
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nIngrese un valor valido");
                }
                // Muestra el menu nuevamente hasta que el usuario coloque el valor 5
                Console.WriteLine("\nEscoge la opcion que desees\n\n" +
                "1. Para realizar una suma\n" +
                "2. Para realizar una resta\n" +
                "3. Para realizar una multiplicacion\n" +
                "4. Para realizar una division\n" +
                "5. Para realizar una salir\n");

                Console.Write("Ingresa la opción: ");
                num4_I = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nGracias por usar el programa");
            Console.ReadKey();
            */


            /*
             * 5. Crea un programa que simule el juego de piedra, papel o tijera contra el usuario. El programa 
             * debe utilizar un bucle while para repetir el juego hasta que el usuario decida salir.
     
            // Se crea una instancia de clase Random para generar números aletorios
            Random random5 = new Random();
            // Indicaciones al usuario
            Console.WriteLine("Bienvenido al juego de piedra papel y tijera\n" +
                "La reglas del juegos son las siguientes:\n" +
                "El programa al inicio y al final de cada juego te va a preguntar si quieres jugar o no, para seguir jugando debes escrbir si " +
                "caso contrario aplasta cualquier tecla \n" +
                "Una vez ingresado al juego:\n" +
                "1 = Piedra\n" +
                "2 = Papel\n" +
                "3 = Tijera");
            // Pregunta si el usuario quiere jugar
            Console.WriteLine("Quieres jugar? ");
            string opcion = Console.ReadLine().ToLower();

            // Bucle hasta que el usuario ya no desee jugar
            while (opcion == "si")
            {
                // Solicita la eleccion del usuario
                Console.WriteLine("Ingresa tu elección");
                int eleccion = int.Parse(Console.ReadLine());
                // Condiciona que la opcion ingresada por el usuario sea del 1 al 3
                if (eleccion >=1 && eleccion <= 3)
                {
                    // Genera un número aleatorio entre 1 y 3
                    int numAleatorio5 = random5.Next(1, 4);

                    // Indica si gano el Usuario o la PC
                    if (eleccion == 1 && numAleatorio5 == 1)
                    {
                        Console.WriteLine($"Tú y la PC ({numAleatorio5}) escogieron Piedra. Quedaron empates");
                    }
                    else if (eleccion == 2 && numAleatorio5 == 2)
                    {
                        Console.WriteLine($"Tú y la PC ({numAleatorio5}) escogieron Papel. Quedaron empates");
                    }
                    else if (eleccion == 3 && numAleatorio5 == 3)
                    {
                        Console.WriteLine($"Tú y la PC ({numAleatorio5}) escogieron Tijeras. Quedaron empates");
                    }
                    else if (eleccion == 1 && numAleatorio5 == 2)
                    {
                        Console.WriteLine($"Tú escogiste Piedra y la PC ({numAleatorio5}) escogio Papel. Gano la PC");
                    }
                    else if (eleccion == 1 && numAleatorio5 == 3)
                    {
                        Console.WriteLine($"Tú escogiste Piedra y la PC ({numAleatorio5}) escogio Tijeras. Tú Ganaste");
                    }
                    else if (eleccion == 2 && numAleatorio5 == 1)
                    {
                        Console.WriteLine($"Tú escogiste Papel y la PC ({numAleatorio5}) escogio Piedra. Tú Ganaste");
                    }
                    else if (eleccion == 2 && numAleatorio5 == 3)
                    {
                        Console.WriteLine($"Tú escogiste Papel y la PC ({numAleatorio5}) escogio Tijeras. Gano la PC");
                    }
                    else if (eleccion == 3 && numAleatorio5 == 1)
                    {
                        Console.WriteLine($"Tú escogiste Tijeras y la PC ({numAleatorio5}) escogio Piedra. Gano la PC");
                    }
                    else
                    {
                        Console.WriteLine($"Tú escogiste Tijeras y la PC ({numAleatorio5}) escogio Papel. Tú Ganaste");
                    }
                }
                else
                {
                    Console.WriteLine("Número ingresado no valido");
                }
                // Pregunta si desea continuar con el bucle
                Console.WriteLine("Para continuar escribe si, caso contrario aplasta cualquier tecla ");
                opcion = Console.ReadLine();
            }
            // Mensaje fin de bucle
            Console.WriteLine("Nos vemos en una próxima vez");
            Console.ReadKey();
            */


            /*
             * 6. Escribe un programa que calcule el factorial de un número ingresado por el usuario utilizando un bucle while.
             
            // Indicación al usuario
            Console.WriteLine("Ingrese un numero para calcular su factorial");
            int num6;
            // Verificación que la entrade del usuario sea entero positivo
            bool num6Validacion = int.TryParse(Console.ReadLine(), out num6);
            if (num6Validacion && num6 >= 0)
            {
                int factorial = 1;
                int contador = num6;

                // Calculo del factorial
                while (contador > 1)
                {
                    factorial *= contador;
                    contador--;
                }
                Console.WriteLine($"El factrial de {num6} es {factorial}");
            }
            else {
                Console.WriteLine("Ingrese un numero enero no negativo");
            }
            Console.ReadKey();
            */


            /*
             * 7. Desarrolla un programa que solicite al usuario que ingrese un número entero positivo hasta que introduzca un valor válido.  
             
            int num7;
            bool num7Validacion = false;

            // Bucle para hasta que el usuario ingrese un número entero positivo
            while (!num7Validacion) {
                Console.Write("  Ingrese un número entero positivo: ");
                string numIng = Console.ReadLine();

                // Tranformar la entrada para comprobar que el string ingresado sea un número entero positivo
                if (int.TryParse(numIng, out num7) && num7 > 0)
                {
                    num7Validacion = true;
                    Console.WriteLine($"\n  Ingresaste el número {num7} que es un entero positivo");
                }
                else {
                    Console.WriteLine("\n  " +
                        "Error. Intenta nuevamente\n");
                }
            }
            Console.ReadKey();
            */


            /*
             * 8. Crea un programa que simule un cajero automático. El programa debe permitir al usuario realizar operaciones como consultar saldo, 
             * retirar dinero y depositar dinero. El programa debe utilizar bucles while o do-while para controlar el flujo de las operaciones.
             
            // Saldo inicial de la cuenta
            decimal saldo = 1000.00m;
            // Variable para controlar si el usuario desea salir del bucle
            bool salir = false;
            // El bucle continuará ejecutándose mientras `salir` sea `false`
            while (!salir)
            {
                Console.WriteLine("\n--- Cajero Automático ---");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción (1-4): ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Consultar saldo; Muestra el saldo actual formateado como moneda
                        Console.WriteLine($"\nTu saldo actual es: {saldo:C}");
                        break;

                    case "2":
                        // Retirar dinero
                        Console.Write("\nIngresa la cantidad que deseas retirar: ");
                        decimal cantidadRetiro;
                        // Intenta convertir la entrada del usuario a un decimal y verifica que sea mayor que 0
                        if (decimal.TryParse(Console.ReadLine(), out cantidadRetiro) && cantidadRetiro > 0)
                        {
                            if (cantidadRetiro <= saldo)
                            {
                                saldo -= cantidadRetiro;
                                // Muestra el saldo actual formateado como moneda
                                Console.WriteLine($"Has retirado {cantidadRetiro:C}. Tu nuevo saldo es: {saldo:C}");
                            }
                            else
                            {
                                Console.WriteLine("Fondos insuficientes.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Cantidad no válida.");
                        }
                        break;

                    case "3":
                        // Depositar dinero
                        Console.Write("\nIngresa la cantidad que deseas depositar: ");
                        decimal cantidadDeposito;

                        if (decimal.TryParse(Console.ReadLine(), out cantidadDeposito) && cantidadDeposito > 0)
                        {
                            saldo += cantidadDeposito;
                            // Muestra el saldo actual formateado como moneda
                            Console.WriteLine($"Has depositado {cantidadDeposito:C}. Tu nuevo saldo es: {saldo:C}");
                        }
                        else
                        {
                            Console.WriteLine("Cantidad no válida.");
                        }
                        break;

                    case "4":
                        // Salir
                        salir = true;
                        Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta pronto!");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 4.");
                        break;
                }
            }
            Console.ReadLine();
            */


            /*
             * 9. Escribe un programa que elija una palabra aleatoria de un diccionario y le pida al usuario que la adivine. 
             * El programa debe utilizar un bucle while para seguir pidiendo intentos hasta que el usuario acierte la palabra.
             

            Console.WriteLine("Las palabras del diccinario son:\n" +
                "manzana\n" +
                "guineo\n" +
                "cereza\n" +
                "sandia\n" +
                "kiwi\n" +
                "mango\n" +
                "naranja\n");
            // Diccionario de palabras para elegir aleatoriamente
            string[] diccionario = { "manzana", "guineo", "cereza", "sandia", "kiwi", "mango", "naranja" };
            
            // Crear una instancia de Random para seleccionar una palabra aleatoria
            Random random = new Random();
            // Elegir una palabra aleatoria del diccionario
            string palabraSecreta = diccionario[random.Next(diccionario.Length)];

            // Variable para almacenar la adivinanza del usuario
            string adivinanza = string.Empty;

            Console.WriteLine("¡Adivina la palabra secreta!\n");

            // Bucle que continúa pidiendo intentos hasta que el usuario acierte la palabra
            while (adivinanza != palabraSecreta)
            {
                Console.Write("Ingresa tu adivinanza: ");
                // Leer la entrada del usuario y convertir a minúsculas
                adivinanza = Console.ReadLine().ToLower(); 

                if (adivinanza == palabraSecreta)
                {
                    Console.WriteLine("\nFelicidades. Has adivinado la palabra.");
                }
                else
                {
                    Console.WriteLine("\nIntenta nuevamente.\n");
                }
            }
            Console.ReadKey();
            */


            /*
             * 10. Desarrolla un programa que genere contraseñas aleatorias seguras utilizando un bucle while o do-while. 
             * La contraseña debe cumplir con ciertos requisitos de longitud, complejidad y caracteres especiales.

            // Definir los requisitos de la contraseña
            const int longitudMinima = 12; // Longitud mínima de la contraseña
            const string caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()_-+=<>?"; // Conjunto de caracteres válidos

            Random random = new Random();
            StringBuilder contraseña;
            bool esSegura;

            // Generar contraseñas hasta que cumpla con los requisitos
            do
            {
                contraseña = new StringBuilder(longitudMinima);
                esSegura = false; // Inicialmente asumimos que la contraseña no es segura

                // Crear una contraseña aleatoria
                for (int i = 0; i < longitudMinima; i++)
                {
                    int indice = random.Next(caracteres.Length);
                    contraseña.Append(caracteres[indice]);
                }

                // Verificar si la contraseña es segura
                string contraseñaGenerada = contraseña.ToString();
                bool tieneMinúscula = false;
                bool tieneMayúscula = false;
                bool tieneNúmero = false;
                bool tieneCaracterEspecial = false;

                foreach (char c in contraseñaGenerada)
                {
                    if (char.IsLower(c)) tieneMinúscula = true;
                    if (char.IsUpper(c)) tieneMayúscula = true;
                    if (char.IsDigit(c)) tieneNúmero = true;
                    if ("!@#$%^&*()_-+=<>?".Contains(c)) tieneCaracterEspecial = true;
                }

                // La contraseña es segura si cumple todos los requisitos
                esSegura = tieneMinúscula && tieneMayúscula && tieneNúmero && tieneCaracterEspecial;

            } while (!esSegura);

            // Imprimir la contraseña generada
            Console.WriteLine("Contraseña generada: " + contraseña.ToString());
            Console.ReadKey();
            */
        }
    }
}
