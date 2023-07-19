bool exit = false;

while (!exit)
{
    DisplayMenu();
    Console.Write("Your choice:");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Option1();
            break;
        case "2":
            Option2();
            break;
        default:
            Console.WriteLine("End");
            return;
    }
}

static void DisplayMenu()
{
    Console.WriteLine("Chuong trinh Menu");
    Console.WriteLine("1.Tinh tong hai so.");
    Console.WriteLine("2. Tinh lap phuong cua mot so.");
    Console.WriteLine("3. Thoat.\n");
}

void Option1()
{
    Console.Write("So thu nhat: ");
    int num = int.Parse(Console.ReadLine());

    Console.Write("So thu hai: ");
    int num1 = int.Parse(Console.ReadLine());

    int kq = num + num1;
    Console.WriteLine("Tong hai so la: " + kq + "\n");
}
void Option2()
{
    Console.Write("\n Nhap so de tinh lap phuong: ");
    int num = int.Parse(Console.ReadLine());

    int num2 = num * num * num;
    Console.WriteLine("Lap phuong cua so num la: "+ num2 + "\n");
}




