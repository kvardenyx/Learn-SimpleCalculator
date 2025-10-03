Console.WriteLine("Simple Calculator v2.0");

bool exitProgram = false;
while (!exitProgram)
{
    Console.Write("Enter the first number: ");
    string firstInput = Console.ReadLine() ?? "0";

    float firstNumber;
    while (!float.TryParse(firstInput.Replace(".", ","), out firstNumber))
    {
        Console.Write("Invalid number! Enter again: ");
        firstInput = Console.ReadLine() ?? "0";
    }

    Console.Write("Enter the second number: ");
    string secondInput = Console.ReadLine() ?? "0";

    float secondNumber;
    while (!float.TryParse(secondInput.Replace(".", ","), out secondNumber))
    {
        Console.Write("Invalid number! Enter again: ");
        secondInput = Console.ReadLine() ?? "0";
    }

    bool validOperation = false;
    while (!validOperation)
    {
        Console.WriteLine("Choose the mathematical operation: \n a. Addition \n b. Subtraction \n с. Multiplication \n d. Division");
        string userOperation = Console.ReadLine() ?? "0";
        
        switch (userOperation.ToLower())
        {
            case "a":
                Console.WriteLine($"{firstNumber} + {secondNumber} = {Math.Round(firstNumber + secondNumber, 2)}");
                validOperation = true;
                break;
            case "b":
                Console.WriteLine($"{firstNumber} - {secondNumber} = {Math.Round(firstNumber - secondNumber, 2)}");
                validOperation = true;
                break;
            case "c":
                Console.WriteLine($"{firstNumber} * {secondNumber} = {Math.Round(firstNumber * secondNumber, 2)}");
                validOperation = true;
                break;
            case "d":
                if (secondNumber != 0)
                {
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {Math.Round(firstNumber / secondNumber, 2)}");
                    validOperation = true;
                }
                else
                {
                    Console.WriteLine("It cannot be divided by 0! \n Select another operation");
                }
                break;
            default:
                Console.WriteLine("This operation is not provided");
                break;
        }
    }

    bool validAnswer = false;
    while (!validAnswer)
    {
        Console.WriteLine("Do you want to continue the calculations? \n a. Yes \n b. No");
    
        string userAnswer = Console.ReadLine() ?? "0";
    
        switch (userAnswer.ToLower())
        {
            case "a":
                validAnswer = true;
                break;
            case "b":
                validAnswer = true;
                exitProgram = true;
                
                Console.WriteLine("Thanks for using Simple Calculator");
                
                Console.WriteLine("Press any key to exit the program");
                Console.ReadKey();
                break;
            default:
                Console.WriteLine("An impossible choice!");
                break;
        } 
    }
}