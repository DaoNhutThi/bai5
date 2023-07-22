bool Exit = false;
int time = 0;

int randomNumber = Random.Shared.Next(0, 100);
int guessNumber = 1;

while (!Exit)
{
    Console.WriteLine("TRo choi doan so");
    Console.WriteLine("1. Play Game");
    Console.WriteLine("2. View Time");
    Console.WriteLine("3. Thoat\n");

    Console.Write("Your choice: ");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            playGame();
            break;
        case "2":
            viewTime();
            break;
        default:
            Console.WriteLine("Exit");
            return;
    }
}

void viewTime()
{
    //time++;
    Console.WriteLine("Time is: " + time + "\n");

}

void playGame()
{
    while (randomNumber != guessNumber)
    {
        Console.Write("Moi ban doan so: ");
        guessNumber = int.Parse(Console.ReadLine());
        if (guessNumber == randomNumber)
        {
            Console.WriteLine("Chuc mung ban! Ban da doan dung \n ");

        }
        else if (guessNumber > randomNumber)
        {
            Console.WriteLine("So ban doan thap xuong \n ");
        }
        else
        {
            Console.WriteLine("So ban doan cao len \n ");
        }
        time++;

    }
}
Console.WriteLine("Ket qua random la: " + randomNumber);