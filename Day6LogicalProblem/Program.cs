using System;
using System.Diagnostics;

Stopwatch timer = new Stopwatch(); // creating a object of StopWatch class
static Boolean startStopwatch(Stopwatch timer) // this function is to start the stopwatch 
{
    Console.WriteLine("Enter 1 to start the stopwatch:");
    int startOption = int.Parse(Console.ReadLine()); // from user we are getting a input to start the timer
    if (startOption == 1) // if startOption value is equals to 1 then only the timer will start and return true or else false
    {
        timer.Start();
        return true;
    }
    else
    {
        return false;
    }
    
}
static Boolean stopStopwatch(Stopwatch timer) // this function is use to stop the stopwatch
{
    Console.WriteLine("Enter 2 to stop the stopwatch:");
    int startOption = int.Parse(Console.ReadLine());// from user we are getting a input to stop the timer
    if (startOption == 2) //if stopOption value is equals to 2 then only the timer will stop and return true or else false
    {
        timer.Stop();
        return true;
    }
    else
    {
        return false;
    }
    
}
static void elapsedTime(Stopwatch timer) // this function will call the start and stop timer functions and calculate elapsed time
{
    Boolean start= startStopwatch(timer); // the value returned from startStopwatch function is stored in start
    if (start) // if start is equals to true it means timer is started and go inside if statement
    {
        Console.WriteLine("Timer started");
        Boolean stop = stopStopwatch(timer);// the value returned from stopStopwatch function is stored in stop
        if (stop)// if stop is equals to true it means timer is stoped and go inside if statement
        {
            Console.WriteLine("Timer stopped");
            Console.WriteLine("The Elapsed time is " + timer.Elapsed); //the elapsed time between start and stop is displayed
        }
        else // the input didn't match that's why it came to else part and display the msg
        {
            Console.WriteLine("Wrong input... Timer didn't stop"); 
        }
    }
    else// the input didn't match that's why it came to else part and display the msg
    {
        Console.WriteLine("Wrong input... Timer didn't start");
    }
    
   
}
elapsedTime(timer); // elapsedTime method is called