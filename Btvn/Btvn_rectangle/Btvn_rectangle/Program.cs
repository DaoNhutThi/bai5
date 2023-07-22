Console.Write("Nhap chieu rong cua hinh chu nhat: ");
int width = int.Parse(Console.ReadLine());


Console.Write("Nhap chieu cao cua hinh chu nhat: ");
int heigh = int.Parse(Console.ReadLine());

Console.WriteLine("Hinh chu nhat");

for (int i = 0; i < heigh; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}