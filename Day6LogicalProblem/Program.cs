static Boolean isPresent(int[] arr, int num) //this method checks whether the no is already present in array or not
{
    for (int i = 0; i < arr.Length; i++) // for loop is used so we can compare the value present in num with each value present in array
    {
        if (arr[i] == num)  //if this condition becomes true it means that num is present in array and will return value true
        {
            return true;
        }
    }
    return false;
}
static void generateCouponCode(int totalNum)
{
    int[] couponCode = new int[totalNum];  //creating a array to store the distinct coupon code
    int randomNo = 0, count=0;
    Boolean check;
    Random random = new Random();
    for (int i = 0; i < couponCode.Length; i++) // for loop is used to generate n no of random number
    {
        randomNo = random.Next(1000, 10000);
        count++;
        check = isPresent(couponCode, randomNo); //the value true or false return from isPresent function is store in check variable
        if (check != true) // if this condition becomes true then it means the value is not already present in array and stores in couponCode array
        {
            couponCode[i] = randomNo;
        }
        else
        {
            --i; // if condition becomes false it means the number is already present in array and decrements the value of i so we can store the next value in same current index
        }
    }
    Console.WriteLine("The unique coupon numbers are :");
    for (int i = 0; i < couponCode.Length; i++) //this for loop is used to print the values in array one by one
    {
        Console.WriteLine(couponCode[i] + " ");
    }
    Console.WriteLine("Total random number needed to have all distinct numbers are : "+count);
}
Console.Write("Enter the number of coupon codes to be generated : ");
int totalNum = int.Parse(Console.ReadLine());  //taking value of n from user
generateCouponCode(totalNum); // calling the function