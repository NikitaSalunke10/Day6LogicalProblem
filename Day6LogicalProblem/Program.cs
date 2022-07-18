Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); // in num variable we are storing the number of which we are going to check if it is perfect no or not
int total = 0;
for(int i = 1; i < num; i++)//using for loop we are dividing the num with i
{
    if(num % i == 0) // in this if condition we are calculating remainder and checking if it equal or not
    {
        total += i; //if condition becomes true then the i is added with total
    }
}
if(num == total) //if the total is same as num then it will go inside if and print that it is a perfect number
{
    Console.WriteLine("Entered number is a Perfect number.");
}
else
{
    Console.WriteLine("Entered number is not a Perfect number.");
}
