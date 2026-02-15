using Shared;

do
{
    var a = ConsoleExtension.GetInt("ingrese priner numero:   ");
    var b = ConsoleExtension.GetInt("ingrese segundo numero:  ");
    var c = ConsoleExtension.GetInt("ingrese tercer numero:   ");

    if (a > b && a > c)
    {
        Console.WriteLine($"El numero mayor es: {a}");
    }
    else if (b > a && b > c)
    {
        Console.WriteLine($"El numero mayor es: {b}");
    }
    else
    {
        Console.WriteLine($"El numero mayor es: {c}");
    }

} while (true);