using System;
namespace WorkingWithVariables
{
  public class Logic
  {
    public void ReturnHardCodedVariables()
    {
      int numberOfCupsOfCoffee = 2;
      string fullName = "Stefan Bettaglio";
      var today = DateTime.Today.ToString("dd/MM/yyyy");
      Console.WriteLine($"{fullName} drank {numberOfCupsOfCoffee} cups of coffee, on {today}");


    }
    public double Sum(double firstOperand, double secondOperand)
    {
      return firstOperand + secondOperand;
    }
    public double Difference(double firstOperand, double secondOperand)
    {
      return firstOperand - secondOperand;
    }
    public double Product(double firstOperand, double secondOperand)
    {
      return firstOperand * secondOperand;
    }
    public double Quotient(double firstOperand, double secondOperand)
    {
      return firstOperand / secondOperand;
    }
    public double Remainder(double firstOperand, double secondOperand)
    {
      return firstOperand % secondOperand;
    }
    public void Alice(string userName)
    {
      switch (userName)
      {
        case "Alice":
          Console.WriteLine($"What is up {userName}!");
          break;
        default:
          Console.WriteLine($"Hello, {userName}");
          break;
      }
    }
  }
}