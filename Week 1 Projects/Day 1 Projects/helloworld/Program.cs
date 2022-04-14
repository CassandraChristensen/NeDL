namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // Prompt for number of pennies
      Console.WriteLine("Enter number of pennies:");

      // Create variable and get user input from the keyboard and store it in the variable
      int numPennies = Convert.ToInt32(Console.ReadLine());

      // Prompt for number of nickels
      Console.WriteLine("Enter number of nickels");
      int numNickels = Convert.ToInt32(Console.ReadLine());

      //Prompt for number of dimes
      Console.WriteLine("Enter number of dimes");
      int numDimes = Convert.ToInt32(Console.ReadLine());

      //Prompt for number of quarters
      Console.WriteLine("Enter number of quarters");
      int numQuarters = Convert.ToInt32(Console.ReadLine());

      
    }
  }
}