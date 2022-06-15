string cadena1, cadena2, cadena3, cadena4, resultado, palabra;
char letra, separador;
int extraer, contador, operacion=0;
bool iguales;
string[] resultadoArray;
const double INDEFINIDO = -999999;
double resultadoCalc = 0;

static void Avanzar()
{
    Console.WriteLine("PRESIONE UNA TECLA PARA AVANZAR...");
    Console.ReadLine();
    Console.Clear();
}

int contarLetras(string cadena, char letra)
{
    int contador = 0;

    for (int i = 0; i < cadena.Length; i++)
    {
        if (cadena[i] == letra)
        {
            contador++;
        }
    }
    return contador;
}

double CalculadoraV1(int operacion, double op1, double op2)
{
    switch (operacion)
    {
        case 0:
            resultadoCalc = op1 + op2;
            break;

        case 1:
            resultadoCalc = op1 - op2;
            break;

        case 2:
            resultadoCalc = op1 * op2;
            break;

        case 3:
            if (op2 != 0)
            {
                resultadoCalc = op1 / op2;
            }
            else
            {
                resultadoCalc = INDEFINIDO;
            }
            break;
    }
    return resultadoCalc;
}

Console.WriteLine("Ingrese una frase con la que desea trabajar: ");
cadena1 = Console.ReadLine();
Console.WriteLine($"La longitud de la frase es: {cadena1.Length}");

Console.WriteLine("Ingrese la letra que desea contar: ");
letra = Convert.ToChar(Console.ReadLine());
contador = contarLetras(cadena1, letra);
Console.WriteLine($"La frase ingresada tiene {contador} veces la letra '{letra}'.");

Console.WriteLine("Ingrese otra frase para concatenar con la anterior: ");
cadena2 = Console.ReadLine();
cadena3 = cadena1 + cadena2;
Console.WriteLine(cadena3);

Console.WriteLine("Seleccione la posición para seleccionar una parte de la frase: ");
extraer = Convert.ToInt32(Console.ReadLine());

resultado = cadena3.Substring(extraer);
Console.WriteLine(resultado);

Avanzar();

Console.WriteLine("Mostramos la cadena con un foreach.");
foreach (char c in cadena3)
{
    Console.WriteLine($"{c}");
}

Console.WriteLine("Ingrese una palabra para buscar en la cadena: ");
palabra = Console.ReadLine();

extraer = cadena3.IndexOf(palabra);
if (extraer >= 0)
{
    Console.WriteLine($"La palabra {palabra} si está contenida en la frase.");
}
else
{
    Console.WriteLine($"La palabra {palabra} NO está contenida en la frase.");
}

Avanzar();

Console.WriteLine("Paso toda la cadena a mayus: ");
resultado = cadena3.ToUpper();
Console.WriteLine(resultado);

Console.WriteLine("Paso toda la cadena a minus: ");
resultado = cadena3.ToLower();
Console.WriteLine(resultado);

Console.WriteLine("Ingrese una nueva cadena para comparar con la que venimos trabajando: ");
cadena4 = Console.ReadLine();
iguales = String.Equals(cadena3, cadena4);
if (iguales)
{
    Console.WriteLine($"Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas NO son iguales");
}

Avanzar();

Console.WriteLine("Ingrese una cadena separada por un caracter especial: ");
cadena4 = Console.ReadLine();
Console.WriteLine("Indique el caracter separador: ");
separador = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Presentamos la cadena como array: ");
resultadoArray = cadena4.Split($"{separador}");
Array.ForEach(resultadoArray, x => Console.WriteLine(x));

Avanzar();

Console.WriteLine("Ingrese una operacion simple, ejemplo x*y: ");
cadena4 = Console.ReadLine();

if (cadena4.Contains("+"))
{
    operacion = 0;
}

if (cadena4.Contains("-"))
{
    operacion = 1;
}

if (cadena4.Contains("*"))
{
    operacion = 2;
}

if (cadena4.Contains("/"))
{
    operacion = 3;
}

resultadoArray = cadena4.Split($"{operacion}");

resultadoCalc = CalculadoraV1(operacion, Convert.ToDouble(resultadoArray[0]), Convert.ToDouble(resultadoArray[1]));

Console.WriteLine($"El resultado de sumar ambas cadenas es: {resultadoCalc}");
