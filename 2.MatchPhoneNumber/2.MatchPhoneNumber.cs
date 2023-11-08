﻿using System.Text.RegularExpressions;

string pattern = @"\+359([\ \-])2\1\d{3}\1\d{4}\b";

Regex regex = new Regex(pattern);

string inputs = Console.ReadLine();

MatchCollection matches = regex.Matches(inputs);

Console.WriteLine(string.Join(", ", matches));