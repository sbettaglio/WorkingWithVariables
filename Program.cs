using System;

namespace WorkingWithVariables
{
  class Program
  {
    static void Main(string[] args)
    {
      var logic = new Logic();

      logic.ReturnHardCodedVariables();

      Console.WriteLine($"What is your name?");
      var userName = Console.ReadLine();
      logic.Alice(userName);
      Console.WriteLine($"What's your favorite number?");
      var firstOperand = double.Parse(Console.ReadLine());
      Console.WriteLine($"What's your least favorite number?");
      var secondOperand = double.Parse(Console.ReadLine());

      var sum = logic.Sum(firstOperand, secondOperand);
      var difference = logic.Difference(firstOperand, secondOperand);
      var product = logic.Product(firstOperand, secondOperand);
      var quotient = logic.Quotient(firstOperand, secondOperand);
      var remainder = logic.Remainder(firstOperand, secondOperand);
      Console.WriteLine($"If you add {firstOperand} and {secondOperand} you get {sum}.");
      Console.WriteLine($"If you subtract {secondOperand} from {firstOperand}  you get {difference}.");
      Console.WriteLine($"If you multiply {firstOperand} and {secondOperand}  you get {product}.");
      Console.WriteLine($"If you divide {firstOperand} and {secondOperand}  you get {quotient}.");
      Console.WriteLine($"The remainder of {firstOperand} divided by the {secondOperand}  is {remainder}.");
    }
  }
}

