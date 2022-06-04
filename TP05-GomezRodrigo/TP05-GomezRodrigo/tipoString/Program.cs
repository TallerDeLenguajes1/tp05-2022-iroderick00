string cadena1, cadena2, cadena3, cadena4, resultado, palabra;
char letra;
int extraer, contador;
bool iguales;

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

Console.WriteLine("PRESIONE UNA TECLA PARA AVANZAR A LA CALCULADORA...");
Console.ReadLine();
Console.Clear();
