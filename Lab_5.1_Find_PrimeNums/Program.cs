using Lab_5._1_Find_PrimeNums;
Console.WriteLine("This Application will find you any prime number, from first prime number on.");
Console.WriteLine("Which Prime Number are you looking for?");
int usernum = int.Parse(Console.ReadLine());

if (usernum == 0)
{
    Console.WriteLine("Zero is not a prime");
}
else if (usernum == 1)
{
    Console.WriteLine("The number 1 prime is 1");

}
else
{
    int output = Lab5_1.GetPrime(usernum);
    Console.WriteLine($"The Prime {usernum} is {output} ");
}