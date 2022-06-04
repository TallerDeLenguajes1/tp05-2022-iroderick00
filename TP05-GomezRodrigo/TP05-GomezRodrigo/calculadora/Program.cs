int operacion, flag;
double operando1, operando2, resultado = 0; //por que me obliga a inicializar solo esta variable

const double INDEFINIDO = -999999;


double CalculadoraV1(int operacion, double op1, double op2)
{
    switch (operacion)
    {
        case 0:
            resultado = op1 + op2;
            break;

        case 1:
            resultado = op1 - op2;
            break;

        case 2:
            resultado = op1 * op2;
            break;

        case 3:
            if (op2 != 0)
            {
                resultado = op1 / op2;
            }
            else
            {
                resultado = INDEFINIDO;
            }
            break;
    }
    return resultado;
}

void CalculadoraV2()
{
    double numero, num1, num2;

    Console.Clear();
    Console.WriteLine("Ingrese un número para operar: ");
    numero = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"El número ingresado es: {numero}");
    Console.WriteLine($"Valor absoluto: {Math.Abs(numero)}");
    Console.WriteLine($"Cuadrado: {Math.Pow(numero, 2)}");
    Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(numero)}");
    Console.WriteLine($"Seno: {Math.Sin(numero)}");
    Console.WriteLine($"Coseno: {Math.Cos(numero)}");
    Console.WriteLine($"Parte entera: {Math.Truncate(numero)}");

    Console.WriteLine("Ingrese un número: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese otro número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"El número mas grande entre los últimos dos ingresados es: {Math.Max(num1, num2)}");
    Console.WriteLine($"El número mas chico entre los últimos dos ingresados es: {Math.Min(num1, num2)}");
}

do
{
    Console.Clear();
    Console.WriteLine("Ingrese la operación que desea realizar: [0]:SUMA - [1]:RESTA - [2]:MULTIPLICACIÓN - [3]:DIVISIÓN");
    operacion = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el primer operando: ");
    operando1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo operando: ");
    operando2 = Convert.ToDouble(Console.ReadLine());
    Console.Clear();

    CalculadoraV1(operacion, operando1, operando2);
    if (resultado == INDEFINIDO)
    {
        Console.WriteLine("No está definida la división por 0!");
    }
    else
    {
        Console.WriteLine($"El resultado de la operacion es {resultado}");
    }
    CalculadoraV2();

    Console.WriteLine("Desea seguir usando la calculadora? [0]:NO - [1]:SI");
    flag = Convert.ToInt32(Console.ReadLine());
} while (flag == 1);