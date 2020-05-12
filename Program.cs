using System;

namespace Variables
{
  class Program
  {
    static void Main(string[] args)
    {
      var fullName = "Carla Joseph";
      var numberOfCupsOfCoffee = "1";
      var todaysDate = "May 12, 2020";

      Console.WriteLine($"{fullName} {numberOfCupsOfCoffee} {todaysDate}");

      Console.Write("What is your name? ");
      var username = Console.ReadLine();
      
      var greeting = $"Nice to meet you, {username}.";
      Console.WriteLine(greeting);

      Console.Write("Write a number ");
      var firstNumberAsString = Console.ReadLine( );

      Console.Write("Write another number ");
      var secondNumberAsString = Console.ReadLine( );

      double firstOperand = Double.Parse(firstNumberAsString);
      double secondOperand = Double.Parse(secondNumberAsString);

      var sum = firstOperand + secondOperand;
      var difference = secondOperand - firstOperand;
      var quotient = firstOperand / secondOperand;
      var product = firstOperand * secondOperand;
      var remainder = secondOperand % firstOperand;
      Console.WriteLine($"The sum to your numbers is {sum} ");
      Console.WriteLine($"The answer to your subtraction is {difference} ");
      Console.WriteLine($"The answer to your division is {quotient} ");
      Console.WriteLine($"The answer to your multiplication is {product} ");
      Console.WriteLine($"Your remainder is {remainder}");


    }
  }
}
