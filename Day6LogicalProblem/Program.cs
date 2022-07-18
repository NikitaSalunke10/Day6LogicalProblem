Console.Write("Enter the number: ");
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