// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello, World!");
//         }
//     }
// }
// Console.WriteLine("What is your name?");
// var name = Console.ReadLine();
// var currentDate = DateTime.Now;
// Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
// Console.Write($"{Environment.NewLine}Press any key to exit...");
// Console.ReadKey(true);
// string firstName = "Maria";
// string lastName = "Sage";
// string fullName = firstName + lastName;
// Console.WriteLine($"The first name has {firstName.Length} letters.");

// string greeting = "      Hello World!       ";
// string trimmedGreeting = greeting.TrimStart();
// trimmedGreeting = greeting.TrimEnd();
// trimmedGreeting = greeting.Trim();

// string Hello = "Hello World!";
// Hello = Hello.Replace("Hello", "Greetings");

// Console.WriteLine(Hello.ToUpper());
// Console.WriteLine(Hello.ToLower());

int a = 4;
int b = 5;
int c = 6;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");
int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");
