static Boolean isPresent(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
    }
    return false;
}
static void generateCouponCode()
{
    Console.Write("Enter the value of n: ");
    int n = int.Parse(Console.ReadLine());
    int[] couponCode = new int[n];
    int randomNo = 0;
    Boolean check;
    Random random = new Random();
    for (int i = 0; i < couponCode.Length; i++)
    {
        randomNo = random.Next(100, 1000);
        check = isPresent(couponCode, randomNo);
        if (check != true)
        {
            couponCode[i] = randomNo;
        }
        else
        {
            --i;
        }
    }
    Console.WriteLine("The unique coupon numbers are :");
    for (int i = 0; i < couponCode.Length; i++)
    {
        Console.WriteLine(couponCode[i] + " ");
    }
}
generateCouponCode();