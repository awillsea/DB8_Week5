using CalcApp;

Console.WriteLine("welcome to the calculator!");
Console.WriteLine("1.Factorial");
Console.WriteLine("2. Factors");
Console.WriteLine("Which would you liek to do? ");
string choice = Console.ReadLine();

Console.WriteLine("Great! What Number? ");
string entry = Console.ReadLine();
int number = int.Parse(entry);

Calculator calc = new Calculator(number);
if (choice == "1")
{
    int factorial = calc.Findfactorial();
    Console.WriteLine($"The Factorial of {number} is {factorial}");
}
else if (choice == "2")
{
    Console.WriteLine("COMING SOON.");
}
