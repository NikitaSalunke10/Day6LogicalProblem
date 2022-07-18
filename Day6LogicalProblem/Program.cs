using System;
using System.Diagnostics;

Stopwatch timer = new Stopwatch(); 
Console.WriteLine("Enter any key to start the stopwatch");
Console.ReadLine();
timer.Start();
Console.WriteLine("Enter any key to stop the stopwatch");
Console.ReadLine();
timer.Stop();
Console.WriteLine("The Elapsed time is "+timer.Elapsed);