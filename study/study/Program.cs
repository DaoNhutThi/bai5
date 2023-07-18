//VONG LAP WHILE
//BAI1
/*int i = 1;
while (i < 11)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine("End code!");
 */

//BAI2
/*int i = 1;
int sum = 0;
while (i < 101)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
    i++;
}
Console.WriteLine("Endter sum " + sum);
Console.WriteLine("End code!");
*/

//BAI3
/*Console.WriteLine("Nhap so n: ");
int n = int.Parse(Console.ReadLine());
while (n > 0)
{
    Console.WriteLine(n);
    n--;
}
Console.WriteLine("End code!");
 */

//VONG LAP DO WHILE
//BAI1
/*int i = 1;
do
{
    Console.WriteLine(i);
    i++;
} while (i <= 10);
Console.WriteLine("End code!");*/

//BAI2
/*int i = 1;
int sum = 0;
do
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        sum += i;
    }
    i++;
} while (i <= 100);
Console.WriteLine("Sum " + sum);*/

//BAI3
/*Console.WriteLine("Nhap so n: ");
int n = int.Parse(Console.ReadLine());

do
{
    Console.WriteLine(n);
    n--;
}while (n >= 0);
Console.WriteLine("End code!");*/


//GAME
/*
int randomNumber = Random.Shared.Next(0, 100);

int guessNumber = -1;
while (randomNumber != guessNumber)
{
    Console.WriteLine("Moi ban doan so: ");
    guessNumber = int.Parse(Console.ReadLine());
    if (guessNumber == randomNumber)
    {
        Console.WriteLine("Chuc mung ban! Ban da doan dung");
    } else if (guessNumber > randomNumber)
    {
        Console.WriteLine("So ban doan thap xuong ");
    } else
    {
        Console.WriteLine("So ban doan cao len");
    }
}
Console.WriteLine(randomNumber);
*/
/*for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}
*/

//BAI1
/*for (int i = 0;
    i <=10;
    i++)
{
    Console.WriteLine(i);
}*/

//BAI2
/*int i = 1;
int sum = 0;
for (i = 0; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        sum += i;
    }
}
Console.WriteLine("Sum is: " + sum);*/

//BAI3
/*Console.WriteLine("Nhap so n: ");
int n = int.Parse(Console.ReadLine());

for(int i = n; i >= 0; i--)
    {
    Console.WriteLine(i);
}*/

