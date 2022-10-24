//Valerie Aguilar
//October 24, 2022

//----------Odd or Even -------//

//Peer Reviewed By:
//Comment:

int num1;
bool validNum1;
bool validInput;
bool playAgain = true;
bool anotherRound = true;

Console.WriteLine("Let's play a game where you type in a number and I tell you whether that number is even or odd.");


while (playAgain)
{
    Console.WriteLine("Please enter a number.");
    validInput = false;

    while(!validInput)
    {
        validNum1 = int.TryParse(Console.ReadLine(), out num1);
        if (!validNum1)
        {
            Console.WriteLine("Please type in a valid whole number.");
        }
        else
        {
            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is an even number.");
                validInput = true;
            }
            else
            {
                Console.WriteLine($"{num1} is an odd number.");
                validInput = true;
            }

        }
    }

Console.WriteLine("Would you like to play again? if so, type Y for yes, or type N for no.");
anotherRound = false;

while(!anotherRound)
{

    if(Console.ReadLine().ToUpper() != "Y")
    {
        playAgain = false;
        anotherRound = true;
    }
  
        anotherRound = true;
  
}

}

Console.WriteLine("Thank you for playing. See ya later!");
