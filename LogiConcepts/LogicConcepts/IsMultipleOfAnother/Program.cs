using Shared;


do
{
    var a = ConsoleExtension.GetInt("ingrese primer numero:  ");
    var b = ConsoleExtension.GetInt("ingrese segundo numero: ");
    if (b % a == 0)
    {
        Console.WriteLine($"{a} es multiplo {b}");
    }
    else
    {
        Console.WriteLine($"{a} no es multiplo {b}");
    }
} while (true);
