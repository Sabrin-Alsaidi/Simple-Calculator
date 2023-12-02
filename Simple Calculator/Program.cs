using System;

namespace Simple_Calculator;
class Program
{
    static void Main()
    {
        int result;
        Boolean Calculate = true; 
        
            Console.WriteLine("Welcome to the Simple Calculator!");
            string[] MathOperations = { "Addition", "Subtraction", "Multiplication", "Division", "Exit" };
            //For loop to display the elements from the array 
            for (int opertaion = 0; opertaion < 5; opertaion++)
            {
                Console.WriteLine($"{opertaion + 1}. {MathOperations[opertaion]}");
            }

            //Read the operation number from the user 
            Console.WriteLine("Select an operation (1-5): ");
            int operationNum = Convert.ToInt16(Console.ReadLine());
            // if the user selected number 5 the program will exit 
            if (operationNum == 5)
            {
                Calculate = false;
            }
            else
            {
                while (Calculate == true)
                {
                    //Ask the user to inter the numbers 
                    Console.WriteLine("Enter the first operand: ");
                    int FirstNumber = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter the second operand: ");
                    int SecondNumber = Convert.ToInt16(Console.ReadLine());

                     switch (operationNum)
                     {
                         case 1:
                              result = FirstNumber + SecondNumber;
                             Console.WriteLine($" The Resilt is : {result}");
                             break;
                         case 2:
                              result = FirstNumber - SecondNumber;
                             Console.WriteLine($" The Resilt is : {result}");
                             break;
                         case 3:
                              result = FirstNumber * SecondNumber;
                             Console.WriteLine($" The Resilt is : {result}");
                             break;
                         case 4:

                              result = FirstNumber / SecondNumber;
                             Console.WriteLine($" The Resilt is : {result}");
                             break;
                         case 5:
                             Calculate = false;
                             break;
                     }
                    #region other solution using if else 
                    /*if (operationNum == 1)
                    {
                        result = FirstNumber + SecondNumber;
                        Console.WriteLine($" The Resilt is : {result}");
                    }
                    else if (operationNum == 2)
                    {
                        result = FirstNumber - SecondNumber;
                        Console.WriteLine($" The Resilt is : {result}");
                    }
                    else if (operationNum == 3)
                    {
                        result = FirstNumber * SecondNumber;
                        Console.WriteLine($" The Resilt is : {result}");
                    }
                    else if (operationNum == 4)
                    {
                        result = FirstNumber / SecondNumber;
                        Console.WriteLine($" The Resilt is : {result}");
                    }
                    else if (operationNum == 5)
                    {
                        Calculate = false;

                    }*/
                    #endregion

                    // To repeate the process again 
                    Console.WriteLine("Perform another operation? (yes/no):");
                    String anotherOpration = Console.ReadLine();
                    if (anotherOpration == "Yes" || anotherOpration == "yes")
                    {
                        //Read the operation number from the user 
                        Console.WriteLine("Select an operation (1-5): ");
                         operationNum = Convert.ToInt16(Console.ReadLine());

                        Calculate = true;
                    }
                    else
                    {
                        Calculate = false;

                    }
                }
            }
            // if the user selected 5 then the program will exit 
            if (Calculate == false)
            {
               Console.WriteLine("Thank you for using the Simple Calculator!");
            
        }

    }
}

