string input;
int numberGuess = 0;

do
{
    Console.WriteLine("What is a reserve?");
    if(numberGuess>5)
    {
        Console.WriteLine("hint");
    }
    input= Console.ReadLine();
    numberGuess++;
}
while(input != "answer");

Console.WriteLine("answer is correct");
numberGuess = 0;
