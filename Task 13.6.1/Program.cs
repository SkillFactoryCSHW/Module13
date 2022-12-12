using System.Collections.Generic;
using System.Diagnostics;

StreamReader sr = new StreamReader(@"D:\Test\Text1.txt");
List<string> myList = new List<string>();
var timer = new Stopwatch();
timer.Start();

while (!sr.EndOfStream)
{
    myList.Add(sr.ReadLine());
}

timer.Stop();
Console.WriteLine(timer.ElapsedMilliseconds + " : ms for <List> add.");

StreamReader sr2 = new StreamReader(@"D:\Test\Text1.txt");
LinkedList<string> myList2 = new LinkedList<string>();
timer.Restart();

timer.Start();
while (!sr2.EndOfStream)
{
    myList2.AddFirst(sr2.ReadLine());
}
timer.Stop();
Console.WriteLine(timer.ElapsedMilliseconds + " : ms for <LinkedList> add.");
