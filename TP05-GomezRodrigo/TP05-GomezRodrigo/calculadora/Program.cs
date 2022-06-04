int operacion, flag;
double operando1, operando2;
const double INDEFINIDO = -999999;


void CalculadoraV1(int operacion, double op1, double op2)
{
    double resultado = 0; //por que me obliga a inicializar solo esta variable
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
    if (resultado == INDEFINIDO)
    {
        Console.WriteLine("No está definida la división por 0!");
    }
    else
    {
        Console.WriteLine(resultado);
    }
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

    Console.WriteLine("Desea seguir usando la calculadora? [0]:NO - [1]:SI");
    flag = Convert.ToInt32(Console.ReadLine());
} while (flag == 1);
