using System.Security.Cryptography.X509Certificates;

namespace RockPaperScissors;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rock, paper scissors!");
        bool? win = null;
        while (win == null)
        {
            string choice = Console.ReadLine().ToLower();
            if (choice == "rock" || choice == "paper" || choice == "scissors")
            {
                string foe = FoeChoice();
                Console.WriteLine($"Bot: {foe}!");
                if (choice == "rock" && foe == "scissors")
                {
                    win = true;
                }
                else if (choice == "paper" && foe == "rock")
                {
                    win = true;
                }
                else if (choice == "scissors" && foe == "paper")
                {
                    win = true;
                }
                else if (choice == foe)
                {
                    Console.WriteLine("Tie!");
                }
                else
                {
                    win = false;
                }
            }
            else
            {
                Console.WriteLine("Invalid input try again.");
            }
        }

        if (win == true)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }

    }

    public static string FoeChoice()
    {
        string set = null;
        Random r = new Random();
        int random = r.Next(1, 4);
        switch (random)
        {
            case 1:
                set = "rock";
                break;
            case 2:
                set = "paper";
                break;
            case 3:
                set = "scissors";
                break;
        }

        return set;
    }
}