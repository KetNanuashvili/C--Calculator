
while (true)
{

    int numberFirst = 0;
    int numberSecond = 0;

    try
    {
        Console.WriteLine("First number: ");
        numberFirst = int.Parse(Console.ReadLine());

        Console.WriteLine("Second number: ");
        numberSecond = int.Parse(Console.ReadLine());
    }
    catch (OverflowException)
    {
        Console.WriteLine("Your number can't be this size.");
        continue;
    }
    catch (FormatException)
    {
        Console.WriteLine("Input must be a number.");
        continue;
    }
    catch (Exception)
    {
        Console.WriteLine("Something went wrong.");
        continue;
    }




    char operation = ' ';

    try
    {
        Console.Write("Choose operation (+, -, *, /): ");
        string input = Console.ReadLine();

        if (input.Length == 1)
        {
            char[] validOperations = new[] { '+', '-', '*', '/' };
            bool isValidOperation = false;

            foreach (char validOperation in validOperations)
            {

                if (input[0] == validOperation)
                {
                    isValidOperation = true;
                    operation = input[0];
                    break;
                }
            }

            if (!isValidOperation)
            {
                Console.WriteLine("Error: Invalid operation. Please choose from +, -, *, /.");
                continue;
            }
        }
        else
        {
            Console.WriteLine("Error: Please enter only one character.");
            continue;
        }
    }
    catch (Exception)
    {
        Console.WriteLine("An unexpected error occurred.");
        continue;
    }



    int result = 0;
    switch (operation)
    {
        case '+':
            result = numberFirst + numberSecond;
            break;

        case '-':
            result = numberFirst - numberSecond;
            break;

        case '*':
            result = numberFirst * numberSecond;
            break;

        case '/':
            if (numberSecond != 0)
            {
                result = numberFirst / numberSecond;
            }
            else
            {
                Console.WriteLine("Cannot divide by 0.");
                continue;
            }
            break;

        default:
            Console.WriteLine("Please use: +, -, *, or /.");
            continue;
    }


    Console.WriteLine("Result: " + result);


    Console.WriteLine("type 'quit' and  enter to leave or type 'enter' to continue calculation ...");
    string continueInput = Console.ReadLine();

    if (continueInput == "quit")
    {
        break;
    }
}

Console.ReadKey();

