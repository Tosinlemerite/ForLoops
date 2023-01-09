
string ans = "yes";


while (ans.ToLower() == "yes" || ans.ToLower() == "y")
{

  Console.Clear();
  Console.Beep();
  Console.WriteLine("******************************");
  Console.WriteLine("Compute the sum of odd numbers");
  Console.WriteLine("******************************");

  long sum = 0;
  Console.Write("Enter a number:");
  long number = Convert.ToInt32(Console.ReadLine());
  for (long i = 1; i <= number; i += 2)
  {
    sum += i;
  }
  Console.Write($"Sum of odd numbers from 1 to {number} is : {sum}");
  

  Console.WriteLine();
  Console.Beep();
  Console.Write("Do you want to continue? Yes(Y) | No(N): ");
  ans = Console.ReadLine();

}

Console.WriteLine();
Console.Beep();
Console.WriteLine("Thank you for using this app.");