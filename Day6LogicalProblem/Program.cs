Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()); // we are taking the input from user of which we have to check if prime or not
int ans,count = 0;
for(int i = 2; i <= num/2; i++)
{
    ans = num % i; // remainder is calculated 
    if(ans == 0) // check whether remainder is 0 or not if yes then increament the count value else conditnue the loop
    {
        count++;
    }
}
if(count == 0) // if count value is 0 then the number is a prime number
{
    Console.WriteLine(num+ " is a Prime Number");
}
else
{
    Console.WriteLine(num + " is not a Prime Number");
}