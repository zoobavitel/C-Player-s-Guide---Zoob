// 300XP
// The Thing Namer 3000

string c = "Doom"; // This is a phrase that adds dramatic effect.
string d = "3000"; // This is a number that makes it sound futuristic.

Console.WriteLine("What kind of thing are we talking about?");
string ?a = Console.ReadLine(); // This is the noun, the name of the thing.
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string ?b = Console.ReadLine(); // This is the adjective, the word that describes the thing.

Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!"); 
Console.ReadKey(); // This is to keep the console window open until the user presses Enter.