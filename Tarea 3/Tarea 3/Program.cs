using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Declaraciones de Funciones


//Calculadora basica
int suma (int num1, int num2)
{
    return num1 + num2;
}

int resta(int num1, int num2)
{
    return num1 - num2;
}

int multiplicacion(int num1, int num2)
{
    return num1 * num2;
}

int division(int num1, int num2)
{
    return num1 / num2;
}

//Validacion de Contraseña

string validacion (int clavecorrecta, int claveincorrecta)
{
    clavecorrecta = 1234;
    do
    {
        Console.WriteLine("Ingrese la clave");
        claveincorrecta = Convert.ToInt32(Console.ReadLine());
        if (claveincorrecta != clavecorrecta)
        {
            Console.WriteLine("Clave incorrecta");
        }
    } while (claveincorrecta != clavecorrecta);

    return "Acceso Concedido";
}

//Numeros Primos

string primos(int numero)
{
    if (numero <= 1) return $"{numero} no es primo.";  

    for (int i = 2; i < numero; i++)  

    {        if (numero % i == 0) return $"{numero} no es primo.";  

    }
    return $"{numero} es primo.";

}

//Suma de numeros pares

string sumapares(int numero, int sumaPares)
{
    do
    {
        Console.Write("Ingresa un número (0 para terminar): ");
        numero = Convert.ToInt32(Console.ReadLine());  

        if (numero % 2 == 0 && numero != 0)
        {
            sumaPares += numero;
        }

    } while (numero != 0);  

    return ($"La suma de los números pares ingresados es: {sumaPares}");
}

// Conversion de Temperatura

double conversion(double temperatura, double resultado)
{
    Console.WriteLine("Que desea hacer");
    Console.WriteLine("1. Convertir Celsius a Farenheit");
    Console.WriteLine("1. Convertir Farenheit a Celsius");
    int opcion = Convert.ToInt32(Console.ReadLine());

    if (opcion == 1)
    {
        Console.WriteLine("Ingrese la temperatura en Celsius");
        temperatura = Convert.ToDouble(Console.ReadLine());
        resultado = (temperatura * 9 / 5) + 32;
        return resultado;
    }
    else
    {
        Console.WriteLine("Ingrese la temperatura en Farenheit");
        temperatura = Convert.ToDouble(Console.ReadLine());
        resultado = (temperatura - 32) * 5 / 9;
        return resultado;
    }
}

//Contador de Vocales

string contadorvocales(string palabra)
{
        int contador = 0;
        for (int i = 0; i < palabra.Length; i++)
        {
            if (char.IsLetter(palabra[i]))
            {
                contador++;
            }
        }
        return $"La cantidad de letras en la palabra es: {contador}";
    }


//Calculo de factorial

string factorial(int numero)
{
    int resultado = 1;
    for (int i = 1; i <= numero; i++)
    {
        resultado *= i;
    }
    return ($"El factorial del numero es: {resultado}");
}

//Juego de adivinar el numero

string adivinar(int numero, int intentos)
{
    Random aleatorio = new Random();
    int numeroAleatorio = aleatorio.Next(1, 100);
    do
    {
        Console.WriteLine("Adivina el número entre 1 y 100");
        numero = Convert.ToInt32(Console.ReadLine());
        if (numero > numeroAleatorio)
        {
            Console.WriteLine("Demasiado Alto");
        }
        else if (numero < numeroAleatorio)
        {
            Console.WriteLine("Demasiado Bajo");
        }
        intentos++;
    } while (numero != numeroAleatorio);

    return ($"Felicidades, adivinaste el número en {intentos} intentos");
}

//Paso por referencia  

void pasoPorReferencia(ref int numero)
{
    Console.Write("Ingresa el primer número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Ingresa el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine($"Valores originales: num1 = {num1}, num2 = {num2}");

    Intercambiar(ref num1, ref num2);

    Console.WriteLine($"Valores intercambiados: num1 = {num1}, num2 = {num2}");
}

static void Intercambiar(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

//Tabla de multiplicar

void tablamultiplicar(int numero)
{
    Console.WriteLine($"{numero} x 1 = {numero * 1}");
    Console.WriteLine($"{numero} x 2 = {numero * 2}");
    Console.WriteLine($"{numero} x 3 = {numero * 3}");
    Console.WriteLine($"{numero} x 4 = {numero * 4}");
    Console.WriteLine($"{numero} x 5 = {numero * 5}");
    Console.WriteLine($"{numero} x 6 = {numero * 6}");
    Console.WriteLine($"{numero} x 7 = {numero * 7}");
    Console.WriteLine($"{numero} x 8 = {numero * 8}");
    Console.WriteLine($"{numero} x 9 = {numero * 9}");
    Console.WriteLine($"{numero} x 10 = {numero * 10}");
}


string tablademultiplicar(int numero)
{
    Console.WriteLine("Ingrese su numero");
    numero = Convert.ToInt32(Console.ReadLine());
    return tablademultiplicar(numero);
}


//Salida del codigo
|Console.WriteLine("Menu de opciones");
Console.WriteLine("1. Calculadora");
Console.WriteLine("2. Validacion de contraseña");
Console.WriteLine("3. Numeros Primos");
Console.WriteLine("4. Suma de numeros pares");
Console.WriteLine("5. Conversion de Temperatura");
Console.WriteLine("6. Contador de Vocales");
Console.WriteLine("7. Calculo de factorial");
Console.WriteLine("8. Juego de adivinar el numero");
Console.WriteLine("9. Paso por referencia");
Console.WriteLine("10. Tabla de multiplicar");
Console.WriteLine("11. Salir");
Console.WriteLine("Ingrese la opcion que desea realizar");
int opcion = Convert.ToInt32(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese el primer numero");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo numero");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la operacion que desea realizar");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicacion");
        Console.WriteLine("4. Division");
        int operacion1 = Convert.ToInt32(Console.ReadLine());

        switch (operacion1)
        {
            case 1:
                Console.WriteLine(suma(num1, num2));
                break;
            case 2:
                Console.WriteLine(resta(num1, num2));
                break;
            case 3:
                Console.WriteLine(multiplicacion(num1, num2));
                break;
            case 4:
                Console.WriteLine(division(num1, num2));
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
        break;

    case 2:

        Console.WriteLine(validacion(1234, 0));
        break;

    case 3:

        Console.WriteLine("Ingrese el numero que desea verificar");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(primos(numero));
        break;

    case 4:

        Console.WriteLine(sumapares(0, 0));
        break;

    case 5:

        Console.WriteLine(conversion(0, 0));
        break;

    case 6:
        Console.WriteLine("Ingrese la palabra para saber cuantas letras tiene");
        string palabra = Console.ReadLine();
        Console.WriteLine(contadorvocales(palabra));
        break;

    case 7:
        Console.WriteLine("Ingrese el numero que desea Saber el Factorial");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(factorial(numero1));
        break;

    case 8:
        Console.WriteLine(adivinar(0, 0));
        break;

    case 9:
        int numero2 = 0;
        pasoPorReferencia(ref numero2);
        break;

    case 10:
        Console.WriteLine("Ingrese el numero del cual desea saber la tabla de multiplicar");
        int numero3 = Convert.ToInt32(Console.ReadLine());
        tablamultiplicar(numero3);
        break;

        case 11:
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;

}
