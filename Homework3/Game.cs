using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework3
{
    class Game
    {
       /// <summary>
       /// generates questions at start of the game from files
       /// </summary>
       /// <param name="T"></param>
        public void InitializePlay(TaskContent T)
        {
            Console.WriteLine("Ok! Lets start the game!\n");
            var rand = new Random();
            
            this.AddContent(rand.Next(1, 10), 10, T.FirstSection, @"QA1.txt");
            this.AddContent(rand.Next(1, 10), 100, T.SecondSection, @"QA2.txt");
            this.AddContent(rand.Next(1, 10), 1000, T.ThirdSection, @"QA3.txt");

        }
        /// <summary>
        /// Ask question from first block, return winner's prize
        /// </summary>
        /// <param name="T"></param>
        /// <param name="prize"></param>
        /// <returns></returns>
        public int PlayFirstSect(TaskContent T, int prize)
        {
            int endprize=prize;
            Console.WriteLine("We start the first block of questions. Your current pize is "+prize);
            for (int i = 0; i < T.FirstSection.Capacity; i++)
            {
                if (T.AskQuestion(1,i))
                {
                    prize += T.FirstSection[i].Price;
                    Console.WriteLine("You won " + prize);
                }
                else
                {
                    return endprize;
                }
            }
            return prize;
        }
        /// <summary>
        /// Ask question from second block, return winner's prize
        /// </summary>
        /// <param name="T"></param>
        /// <param name="prize"></param>
        /// <returns></returns>
        public int PlaySecondSect(TaskContent T, int prize)
        {
            int endprize = prize;
            Console.WriteLine("We start the second block of questions. Your current pize is " + prize);
            for (int i = 0; i < T.SecondSection.Capacity; i++)
            {
                if (T.AskQuestion(2, i))
                {
                    prize += T.SecondSection[i].Price;
                    Console.WriteLine("You won " + prize);
                }
                else
                {
                    return endprize;
                }
            }
            return prize;
        }


        public int PlayThirdSect(TaskContent T, int prize)
        {
            int endprize = prize;
            Console.WriteLine("We start the last block of questions. Your current pize is " + prize);
            for (int i = 0; i < T.ThirdSection.Capacity; i++)
            {
                if (T.AskQuestion(3, i))
                {
                    prize += T.ThirdSection[i].Price;
                    Console.WriteLine("You won " + prize);
                }
                else
                {
                    return endprize;
                }
            }
            return prize;
        }
        public void Run()
        {
            var currentTasks = new TaskContent();
            int tempPrize = 0, Prize=0;
            int Answer;

            this.InitializePlay(currentTasks);
            Console.Clear();
            Prize = this.PlayFirstSect(currentTasks, tempPrize);
            if (Prize > tempPrize)
            {
                Console.Clear();
                tempPrize = Prize;
                Prize = this.PlaySecondSect(currentTasks, tempPrize);
                if (Prize > tempPrize)
                {
                    Console.Clear();
                    tempPrize = Prize;
                    Prize = this.PlayThirdSect(currentTasks, tempPrize);
                    if (Prize > tempPrize)
                    {
                        Console.WriteLine("Congratulation! You succesfully answer all questions! You won " + Prize);

                    }
                    else
                    {
                        Console.WriteLine("Sorry, your answer was wrong! Your total prize is " + Prize);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, your answer was wrong! Your total prize is " + Prize);
                }
            }
            else
            {
                Console.WriteLine("Sorry, your answer was wrong! Your total prize is " + Prize);
            }
            Console.ReadKey();
        }

        

        /// <summary>
        /// add questions to given gamelist from given textfile starting from line "rnd"
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="mult">multiplier for cost of quaestions</param>
        /// <param name="data"></param>
        /// <param name="path"></param>
        public void AddContent(int rnd, int mult, List <Question> data, string path)
        {
            
            int m = 0, j = 0;
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    m++;
                    if ((m >= rnd) && (j < 5))
                    {
                        data.Add(new Question(mult, line));
                        j++;
                    }
                    if (j == 5) { break; }

                }
            }
           
        }

    }
}
