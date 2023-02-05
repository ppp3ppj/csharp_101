// See https://aka.ms/new-console-template for more information
// Contains
string songLyrics = "You say greetings, and I say Hello";

var result = songLyrics.Contains("goodbye");
Console.WriteLine(result);
Console.WriteLine(songLyrics.Contains("greetings"));

// StartsWith, EndsWith
var resultStartsWith = songLyrics.StartsWith("You");
var resultEndsWith = songLyrics.EndsWith("greetings");
Console.WriteLine($"StartsWith result is {resultStartsWith}");
Console.WriteLine($"EndsWith result is {resultEndsWith}");
