Console.WriteLine("Nhap so N: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for  (int i = 0; i <= n; i++)
{
    if (sum >= 0 )
    {
        Console.WriteLine(i);
        sum += i;
    }
/*    i++;*/
}
Console.WriteLine("sum is: " + sum);
