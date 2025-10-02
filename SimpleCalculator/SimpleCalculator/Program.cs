Console.WriteLine("Simple Calculator v1.0");

Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Choose the mathematical operation: \n a. Addition \n b. Subtraction \n с. Multiplication \n d. Division");
string userAnswer = Console.ReadLine() ?? "0";

float result;

switch (userAnswer)
{
    case "a":
        result = Add(firstNumber, secondNumber);
        Console.WriteLine("Answer: " + result);
        break;
    case "b":
        result = Subtract(firstNumber, secondNumber);
        Console.WriteLine("Answer: " + result);
        break;
    case "c":
        result = Multiply(firstNumber, secondNumber);
        Console.WriteLine("Answer: " + result);
        break;
    case "d":
        result = Division(firstNumber, secondNumber);
        Console.WriteLine("Answer: " + result);
        break;
    default:
        Console.WriteLine("This operation is not provided");
        break;
}

Console.WriteLine("Thanks for using Simple Calculator v1.0");

Console.WriteLine("Press any key to exit the program");
Console.ReadKey();

float Add(float firstNumber, float secondNumber)
{
    result = firstNumber + secondNumber;

    return result;
}

float Subtract(float firstNumber, float secondNumber)
{
    result = firstNumber - secondNumber;

    return result;
}

float Multiply(float firstNumber, float secondNumber)
{
    result = firstNumber * secondNumber;

    return result;
}

float Division(float firstNumber, float secondNumber)
{
    result = firstNumber / secondNumber;

    return result;
}