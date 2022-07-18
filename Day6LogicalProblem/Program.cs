int num1 = 0, num2 = 1, num3; 
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); // from user the value of num is taken so we can print the series till that number.
Console.WriteLine(num1);
for(int i = 2; i <= num; i++) // for loop is used to add next number 
{
    num3 = num1 + num2; // here we are adding num1 and num2 and finding the next number to continue the same process.
    Console.WriteLine(num3);
    num1 = num2; 
    num2 = num3;
}
