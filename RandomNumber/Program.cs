Random rnd = new Random();

int myRandomNum;

int Randomsum = 0;

for(int i = 0; i < 3; i++)
{


    myRandomNum = rnd.Next(0, 11); // 0 - 10
    Randomsum = Randomsum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {Randomsum}");