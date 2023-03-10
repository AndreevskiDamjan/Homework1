Console.WriteLine("Please insert two numbers.");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result;
Console.WriteLine("Please insert ans operator: +, -, / or * ");
string operationSymbol = Console.ReadLine();
if (operationSymbol == "+")
{
    result = firstNumber + secondNumber;
    Console.WriteLine(result);
}
if (operationSymbol == "-")
{
    result = firstNumber - secondNumber;
    Console.WriteLine(result);
}
if (operationSymbol == "*")
{
    result = firstNumber * secondNumber;
    Console.WriteLine(result);
}
if (operationSymbol == "/")
{
    result = firstNumber / secondNumber;
    Console.WriteLine(result);
}
