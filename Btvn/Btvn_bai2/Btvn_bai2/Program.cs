Console.WriteLine("Nhap so nguyen N: ");
int n = int.Parse(Console.ReadLine());
int giaiThua = 1;
for  (int i = 1; i <= n; i++)
{
    Console.WriteLine(i);
    giaiThua *= i;
}
Console.WriteLine("giai thua: " + giaiThua);