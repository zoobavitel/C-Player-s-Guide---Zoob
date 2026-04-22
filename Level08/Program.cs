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
Console.ReadLine();
