

int playerScore = 0;
int enemyScore = 0;

Random random = new Random();

Console.WriteLine("Welcome to Game ");


while(playerScore !=3 &&  enemyScore !=3 )
{
    Console.WriteLine("Player Score - " + playerScore +   "Enemy Score -" + enemyScore);
    Console.WriteLine("Please enter 'r' for rock 'p' for paper or anything else for scissors ");
    string playerChoise=Console.ReadLine();

    int enemyChoise=random.Next(0,3);


    if(enemyChoise == 0 )
    {
        Console.WriteLine("EnemChoise rock");

        switch(playerChoise)
        {
            case "r":
                Console.WriteLine("Tie");
                break;
            case "p":
                Console.WriteLine("Player wins in this round");
                playerScore++;
                break;
            default:
                Console.WriteLine("Enemy wins this round");
                break;
                
        }
    }
    else if(enemyChoise == 1 )
    {
        Console.WriteLine("Enemy choises paper");
        switch (playerChoise)
        {
            case "r":
                Console.WriteLine("Enemy wins this round");
                break;
            case "p":
                Console.WriteLine("Tie");
                break;
            default:
                Console.WriteLine("Player is wins");
                playerScore++;
                break;
        }
    }
    else 
    {
        Console.WriteLine("Enemy choises scissors");
        switch (playerChoise)
        {
            case "r":
                Console.WriteLine("Player wins in this round");
                break;
            case "p":
                Console.WriteLine("Enemy wins this round");
                enemyScore++;
                break;
                default:
                Console.WriteLine("Tie")
                    ; break;

        }
    }
}
if(playerScore ==3 )
{
    Console.WriteLine("you win");
}
else
{
    Console.WriteLine("You lose");
}