using System;

namespace WorkingWithVariables
{
  class Alice
  {
    public static void Run()
    {
      //Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day
      var numberOfCupsOfCoffee = 2;
      //Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
      var fullName = "Stefan Bettaglio";
      //Create a variable (use your best judgment for type) call today and set it equal to today's date
      var today = "02/10/2020";
      //using your variables, numberOfCupsOfCoffee, fullNameand today, Console.WriteLine out all three on one line.
      Console.WriteLine(fullName + " drank " + numberOfCupsOfCoffee + " cups of coffee on " + today);
      //Ask the user for their name and store it in a variable called 'user'.
      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();
      //Print out a greeting to the user, using their name
      Console.WriteLine("Hello, " + user);
      //*Epic*Some logic to your program that prints our a special message for a user with the of Alice
      //*Epic*Use the type DateTime to represent today.
      //*Epic*Move all of your logic to separate file and Call it from the Main method
      if (user == "Alice")
      {
        DateTime ThisDay = DateTime.Today;
        Console.WriteLine("Today is: " + ThisDay);
      }
      //Ask the user to input two numbers
      //Convert a String to a double using double.parse. Save the first double value in an operand1 variable and the second double value in an operand2 variable
      Console.WriteLine("Please input a number");
      var operand1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Please input another number");
      var operand2 = double.Parse(Console.ReadLine());
      //Add the operands and save in a sum variable
      var sum = operand1 + operand2;
      //Subtract the operands and save in a difference variable
      var difference = operand1 - operand2;
      //Divide the operands and save in a quotient variable
      var quotient = operand1 / operand2;
      //Multiply the operands and save in a product variable
      var product = operand1 * operand2;
      //Find the remainder when one operand is divided by the other and save in a remainder variable. See this page if you need to learn more about the modulo operator.
      var remainder = operand1 % operand2;
      //print all the results to the screen in a meaningful way.
      Console.WriteLine("The sum of the two operands is: " + sum);
      Console.WriteLine("The difference of the two variable is: " + sum);
      Console.WriteLine("The quotient of " + operand1 + " divided by " + operand2 + " is: " + quotient);
      Console.WriteLine("The product of " + operand1 + " multiplied by " + operand2 + " is: " + product);
      Console.WriteLine("The remainder of " + operand1 + " divided by " + operand2 + " is: " + remainder);
    }

  }
}
