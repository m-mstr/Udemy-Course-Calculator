using System.Threading.Channels;
using System.Xml.Serialization;
Console.WriteLine("Hello, ");
Console.WriteLine("Input the first number:");

string userInput = Console.ReadLine();
int number1 = int.Parse(userInput);

Console.WriteLine("Input the second number:");

userInput = Console.ReadLine();
int number2 = int.Parse(userInput);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var choice = Console.ReadLine();
if (EqualsCaseInsensitive(choice, "a"))
{
    var sum = number1 + number2;
    PrintFinalEquation(number1, number2, sum, "+");
}
else if (EqualsCaseInsensitive(choice, "b"))
{
    var difference = number1 - number2;
    PrintFinalEquation(number1, number2, difference, "-");
}
else if (EqualsCaseInsensitive(choice, "m"))
{
    var product = number1 * number2;
    PrintFinalEquation(number1, number2, product, "*");
}
else
{
    Console.WriteLine("Invalid input!");
}

void PrintFinalEquation (int number1, int number2, int result, string @operator)
{
    Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
}
bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}

Console.WriteLine("Press any key to close...");
Console.ReadKey();