using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

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
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");
