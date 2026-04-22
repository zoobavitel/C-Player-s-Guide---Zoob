// Question 1
int num = 1;
double num2 = 2.0;
bool flag = true;
string str = "Hello, World!";

Console.WriteLine($"I have {num} phone. I have version {num2}. This statement is {flag}. Anyways, {str}");

// Question 2
Console.WriteLine("Enter 2 numbers.");
int num3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter another number.");
int num4 = int.Parse(Console.ReadLine() ?? "0");

int sum = num3 + num4;
Console.WriteLine($"The sum of {num3} and {num4} is {sum}.");
if (sum > 100)
{
    Console.WriteLine("That's a big number!");
}


// Question 3
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
}


// Question 4
int[] numbers = { 1, 2, 4, 3, 5 };
int total = 0;
int check = 0;
foreach (int number in numbers)
{
    Console.WriteLine(number);
    total += number;
    if (number > check)
    {
        check = number;
    }
}
Console.WriteLine("The sum total is " + total);
Console.WriteLine("The largest number is " + check);



// Question 5
Console.WriteLine(Greet("Cris", 30));
string Greet(string name, int age)
    {
        return $"Hello, {name}! You are {age} years old.";
    }




// Level 8 Defense of Consolas
Console.Title = "Defense of Consolas";
Console.WriteLine("Target Row?");
int targetRow = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Target Column?");
int targetColumn = int.Parse(Console.ReadLine() ?? "0");
int up = targetRow - 1;
int down = targetRow + 1;
int left = targetColumn - 1;
int right = targetColumn + 1;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"{targetRow}, {left}");
Console.WriteLine($"{up}, {targetColumn}");
Console.WriteLine($"{targetRow}, {right}");
Console.WriteLine($"{down}, {targetColumn}");
Console.Beep(1000, 500);
