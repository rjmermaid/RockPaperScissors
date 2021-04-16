using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int winscore = 0;
            int tiescore = 0;
            int losescore = 0;
            string ans = "Yes";
            while (ans.ToUpper() == "Yes".ToUpper())
            {
                string userInput;
                Console.WriteLine("Please enter an option: R for Rock, P for Paper, S for Scissors");
                string[] choices = new string[3] { "R", "P", "S" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                userInput = Console.ReadLine();
                Console.WriteLine(userInput);
                userInput = userInput.ToUpper();
                Console.WriteLine("Computer's choice is - " + choices[n]);

                if ((userInput == "R" && choices[n] == "S") || (userInput == "S" && choices[n] == "P") || (userInput == "P" && choices[n] == "R"))
                { 
                    Console.WriteLine("You win :)");
                    winscore++;
                    Console.WriteLine("Wins:" + winscore);
                    Console.WriteLine("Ties:" + tiescore);
                    Console.WriteLine("Loses:" + losescore);
                }
                else if ((userInput == "R" && choices[n] == "P") || (userInput == "S" && choices[n] == "R") || (userInput == "P" && choices[n] == "S"))
                {
                    Console.WriteLine("You loose :(");
                    losescore++;
                    Console.WriteLine("Wins:" + winscore);
                    Console.WriteLine("Ties:" + tiescore);
                    Console.WriteLine("Loses:" + losescore);
                }
                else
                {
                    Console.WriteLine("It's a tie :|");
                    tiescore++;
                    Console.WriteLine("Wins:" + winscore);
                    Console.WriteLine("Ties:" + tiescore);
                    Console.WriteLine("Loses:" + losescore);
                }
                Console.WriteLine("Do you want to continue?");
                ans = Console.ReadLine().ToUpper();

            }
            Console.WriteLine("Press any key to exit, thank you");
            Console.ReadKey();   


        }
    }
}
