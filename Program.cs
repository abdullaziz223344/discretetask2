// See https://aka.ms/new-console-template for more information

static bool checkifperfect(int n)
{
    
    int sum = 1;

   
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            if (i * i != n)
                sum = sum + i + n / i;
            else
                sum = sum + i;
        }
    }
   
    if (sum == n && n != 1)
        return true;

    return false;
}


   
    for (int n = 5; n < 30; n++)
        if (checkifperfect(n))
        {
        
            Console.WriteLine(n + " is a perfect number");
        }



