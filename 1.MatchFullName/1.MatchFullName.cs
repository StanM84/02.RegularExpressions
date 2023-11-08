using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";

Regex regex =  new Regex(pattern);

string inputs = Console.ReadLine();

MatchCollection matches = regex.Matches(inputs);

Console.WriteLine(string.Join(" ", matches));