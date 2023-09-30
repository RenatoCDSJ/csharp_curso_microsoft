// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string aFriend = "Bill \n";
aFriend = "Maira";
Console.WriteLine(aFriend);
Console.WriteLine("Hello, " + aFriend);
Console.WriteLine($"Hello {aFriend}! \n");

String friend1 = "Maria";
String friend2 = "Sage";
Console.WriteLine($"My friend are {friend1} and {friend2} \n");

Console.WriteLine($"The name {friend1} has {friend1.Length} letters.");
Console.WriteLine($"The name {friend2} has {friend2} letters. \n");

String greeting = "       Hello World!       ";
Console.WriteLine($"[{greeting}]");
String  trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}] \n");

String sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower() + "\n");

string songLyric = "You say goodbye, and I say hello";
Console.WriteLine(songLyric.Contains("goodbye"));
Console.WriteLine(songLyric.Contains("greeting \n"));

Console.WriteLine(songLyric.StartsWith("You"));
Console.WriteLine(songLyric.StartsWith("goodbye"));
Console.WriteLine(songLyric.EndsWith("Hello"));
Console.WriteLine(songLyric.EndsWith("goodbye"));


