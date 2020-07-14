using System;

namespace Rock__Paper__Scissors
{
    class Program
    {
        private static int _playerScore = 0;
        private static int _pcScore = 0;
        static void Main(string[] args)
        {
            while(_playerScore<3 && _pcScore<3)
            {
                Console.Write("Choose between: rock, paper and scissors: ");
                var userChoice = Console.ReadLine();
                var random = new Random();

                var randomNumber = random.Next(1, 4);
                CheckResult(randomNumber,userChoice);
            }

        }

        public static void CheckResult(int randomNumber, string userChoice)
        {
            string pcChoice;

            switch (randomNumber)
            {
                case 1:
                    pcChoice = "rock";

                    if (userChoice == "rock")
                        Console.WriteLine("\t\t--> Draw! <--");

                    else if (userChoice == "paper")
                    {
                        Console.WriteLine("\t\t--> You WIN! <--");
                        _playerScore++;
                    }

                    else
                    {
                        Console.WriteLine("\t\t--> Computer WIN! <--");
                        _pcScore++;
                    }
                    break;

                case 2:
                    pcChoice = "paper";

                    if (userChoice == "paper")
                        Console.WriteLine("\t\t--> Draw! <--");

                    else if (userChoice == "scissors")
                    {
                        Console.WriteLine("\t\t--> You WIN! <--");
                        _playerScore++;
                    }

                    else
                    {
                        Console.WriteLine("\t\t--> Computer WIN! <--");
                        _pcScore++;
                    }
                    break;

                case 3:
                    pcChoice = "scissors";

                    if (userChoice == "scissors")
                        Console.WriteLine("\t\t--> Draw! <--");

                    else if (userChoice == "rock")
                    {
                        Console.WriteLine("\t\t--> You WIN! <--");
                        _playerScore++;
                    }

                    else
                    {
                        Console.WriteLine("\t\t--> Computer WIN! <--");
                        _pcScore++;
                    }
                    break;
            }

            Console.WriteLine("Your score is {0}, computer's score is {1}\n",_playerScore,_pcScore);
        }
    }
}
