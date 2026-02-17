using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var name = ConsoleExtension.GetString("Ingrese nombre:....................: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese numero de horas trabajadas.: ");
    var hourValue = ConsoleExtension.GetDecimal("ingrese valor hora.................: ");
    var salaryMimimun = ConsoleExtension.GetDecimal("ingrese valor salario minimo mensual:");

    var salary = (decimal)workHours * hourValue;
    if (salary < salaryMimimun)
    {
        Console.WriteLine($"Nombre................................: {name}");
        Console.WriteLine($"salario...............................: {salaryMimimun:C2}");
    }
    else
    {
        Console.WriteLine($"Nombre..............................: {name}");
        Console.WriteLine($"salario.............................: {salary:C2}");
    }


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");
