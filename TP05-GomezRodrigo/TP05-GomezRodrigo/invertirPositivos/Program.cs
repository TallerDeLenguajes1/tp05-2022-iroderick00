int numero, cociente, resto;
string numeroParaMostrar = "";

Console.WriteLine("Ingrese el numero a invertir: ");
numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"El número ingresado es: {numero}");

cociente = numero;
if (numero <= 0)
{
    Console.Clear();
    Console.WriteLine("Solo está permitido invertir números positivos");
}
else
{
    while (cociente > 0)
    {
        resto = cociente % 10;
        cociente = cociente / 10;
        numeroParaMostrar += resto.ToString();
    }
    Console.Clear();
    Console.WriteLine($"El número ingresado es: {numero}");
    Console.WriteLine($"El número invertido es: {numeroParaMostrar}");
}