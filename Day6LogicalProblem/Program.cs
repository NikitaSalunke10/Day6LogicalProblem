<<<<<<< HEAD
﻿Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); // From user we are taking a value and checking for that value if palindrome or not
int originalNum = num; // we are storing the num value in originalnum so we can compare it afterwards
int palin = 0, ans;
while(num > 0) //in this loop when the number is greater the 0 then it will go inside the loop
{
    ans = num % 10; // In this, remainder is calculated
    palin = palin * 10 + ans; //from this formula we will get one by one value from end and store in palin
    num /= 10; //in this, quotient is calculated
}
if(originalNum == palin) // if originalNum and palin value is same then it will print number is palindrome
{
    Console.WriteLine("Number is Palindrome");
}
else
{
    Console.WriteLine("Number is not Palindrome");
}
=======
﻿using System;
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
>>>>>>> P-6-StopWatchProgram
