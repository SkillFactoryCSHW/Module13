using System;
using System.IO;

string path = @"D:\Test\Text1.txt";
StreamReader reader = new StreamReader(path);
string text = reader.ReadToEnd();

var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());

var orderedWords = noPunctuationText
  .Split(' ')
  .GroupBy(x => x)
  .Select(x => new {
      KeyField = x.Key,
      Count = x.Count()
  })
  .OrderByDescending(x => x.Count)
  .Take(10);

foreach (var word in orderedWords)
{
    Console.WriteLine(word);
}