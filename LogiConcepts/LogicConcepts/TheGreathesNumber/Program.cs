using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };


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

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]i, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");
