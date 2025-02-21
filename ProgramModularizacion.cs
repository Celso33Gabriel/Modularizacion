using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            Console.Clear();
            Console.WriteLine("Menú de Ejercicios");
            Console.WriteLine("1. Calculadora Básica");
            Console.WriteLine("2. Validación de Contraseña");
            Console.WriteLine("3. Números Primos");
            Console.WriteLine("4. Suma de Números Pares");
            Console.WriteLine("5. Conversión de Temperatura");
            Console.WriteLine("6. Contador de Vocales");
            Console.WriteLine("7. Cálculo de Factorial");
            Console.WriteLine("8. Juego de Adivinanza");
            Console.WriteLine("9. Paso por Referencia");
            Console.WriteLine("10. Tabla de Multiplicar");
            Console.WriteLine("11. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Calculadora();
                        break;
                    case 2:
                        ValidarContrasena();
                        break;
                    case 3:
                        VerificarPrimo();
                        break;
                    case 4:
                        SumarNumerosPares();
                        break;
                    case 5:
                        ConvertirTemperatura();
                        break;
                    case 6:
                        ContarVocales();
                        break;
                    case 7:
                        CalcularFactorial();
                        break;
                    case 8:
                        JuegoAdivinanza();
                        break;
                    case 9:
                        IntercambioPorReferencia();
                        break;
                    case 10:
                        TablaMultiplicar();
                        break;
                    case 11:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ingrese un número válido.");
            }
            Console.WriteLine("Presione Enter para continuar...");
            Console.ReadLine();
        } while (opcion != 11);
    }

    static void Calculadora()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Seleccione una operación: (+, -, *, /)");
        char operacion = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double resultado = operacion switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : double.NaN,
            _ => double.NaN
        };
        Console.WriteLine("Resultado: " + resultado);
    }

    static void ValidarContrasena()
    {
        string? contrasena;
        do
        {
            Console.Write("Ingrese la contraseña: ");
            contrasena = Console.ReadLine();
        } while (contrasena != "1234");
        Console.WriteLine("Acceso concedido.");
    }

    static void VerificarPrimo()
    {
        Console.Write("Ingrese un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        bool esPrimo = num > 1 && (num == 2 || num % 2 != 0);
        for (int i = 3; i * i <= num && esPrimo; i += 2)
        {
            if (num % i == 0) esPrimo = false;
        }
        Console.WriteLine(esPrimo ? "Es primo" : "No es primo");
    }

    static void SumarNumerosPares()
    {
        int suma = 0, num;
        do
        {
            Console.Write("Ingrese un número (0 para salir): ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) suma += num;
        } while (num != 0);
        Console.WriteLine("Suma de pares: " + suma);
    }

    static void ConvertirTemperatura()
    {
        Console.Write("Ingrese la temperatura: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Convertir a (C)elsius o (F)ahrenheit?");
        char opcion = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double resultado = opcion == 'C' ? (temp - 32) * 5 / 9 : temp * 9 / 5 + 32;
        Console.WriteLine("Temperatura convertida: " + resultado);
    }

    static void ContarVocales()
    {
        Console.Write("Ingrese un texto: ");
        string? texto = Console.ReadLine();
        if (texto == null)
        {
            Console.WriteLine("No se ingresó ningún texto.");
            return;
        }
        texto = texto.ToLower();
        int conteo = 0;
        foreach (char c in texto)
        {
            if ("aeiou".Contains(c)) conteo++;
        }
        Console.WriteLine("Cantidad de vocales: " + conteo);
    }

    static void CalcularFactorial()
    {
        Console.Write("Ingrese un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;
        for (int i = 2; i <= num; i++) factorial *= i;
        Console.WriteLine("Factorial: " + factorial);
    }

    static void JuegoAdivinanza()
    {
        Random rand = new Random();
        int num = rand.Next(1, 101), intento;
        do
        {
            Console.Write("Adivine el número (1-100): ");
            intento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intento < num ? "Demasiado bajo" : intento > num ? "Demasiado alto" : "¡Correcto!");
        } while (intento != num);
    }

    static void IntercambioPorReferencia()
    {
        Console.Write("Ingrese dos números: ");
        int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());
        (a, b) = (b, a);
        Console.WriteLine($"Valores intercambiados: {a}, {b}");
    }

    static void TablaMultiplicar()
    {
        Console.Write("Ingrese un número: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++) Console.WriteLine($"{num} x {i} = {num * i}");
    }
}
