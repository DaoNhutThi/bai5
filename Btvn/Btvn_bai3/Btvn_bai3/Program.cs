int numOne = 0;
int numTwo = 1;
Console.WriteLine("Nhap so N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    if (i == 0)
    {
        Console.WriteLine(i);
        i++;
    }
    int num = numOne + numTwo;
    Console.WriteLine(num);

    numOne = numTwo;
    numTwo = num;
}