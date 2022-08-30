using PigLatin;

Console.WriteLine("Pig Latin Translator");
Console.Write("Enter a word: ");
string entry = Console.ReadLine().ToLower();
if(entry == "")
{
    Console.WriteLine("Sorry, Please enter a real word.");
}
else
{
    Console.WriteLine(Translator.Piglatinize(entry));
}