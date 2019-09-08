using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework3
{
    class TaskContent
    {
        public List<Question> FirstSection = new List<Question>(5);
        public List<Question> SecondSection = new List<Question>(5);
        public List<Question> ThirdSection = new List<Question>(5);
       
        /// <summary>
        /// show question from given section "data" and correct answer on it
        /// </summary>
        /// <param name="data"></param>
        public void ShowContent(List<Question> data)
        {     
            foreach (Question Q in data)
            {
                Console.WriteLine(Q.Ask+" "+Q.Answers[Q.CorrAnswer]);
            }
        }

        /// <summary>
        /// Ask question 'questNumber' from Section 'secNumber' to user, return true if answer was correct
        /// </summary>
        /// <param name="secNumber"></param>
        /// <param name="questNumber"></param>
        /// <returns></returns>
        public Boolean AskQuestion(int secNumber, int questNumber)
        {
            int tempAnswer = -1;
            switch (secNumber)
            {   case 1:
                    {
                        Console.WriteLine(this.FirstSection[questNumber].Ask+"?");
                        Console.WriteLine("Choose the number of correct answer from list below and type it:");
                        for (int i = 0; i < this.FirstSection[questNumber].Answers.Length; i++)
                        {
                            if (i != this.FirstSection[questNumber].Answers.Length - 1)
                            {
                                Console.Write(i+1+". "+this.FirstSection[questNumber].Answers[i] + ", ");
                            }
                            else Console.WriteLine(i + 1 + ". "+this.FirstSection[questNumber].Answers[i] + ";");
                        }
                        var s = Console.ReadLine();
                        if (int.TryParse(s, out tempAnswer))
                        {
                            if ((tempAnswer-1) == this.FirstSection[questNumber].CorrAnswer)
                            {
                                Console.WriteLine("You are right!"); return true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong answer!"); return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!"); return false;
                        }

                     }
                case 2:
                    {
                        Console.WriteLine(this.SecondSection[questNumber].Ask);
                        Console.WriteLine("Choose correct answer from list below:");
                        for (int i = 0; i < this.SecondSection[questNumber].Answers.Length; i++)
                        {
                            if (i != this.SecondSection[questNumber].Answers.Length - 1)
                            {
                                Console.Write(i + 1 + ". " + this.SecondSection[questNumber].Answers[i] + ", ");
                            }
                            else Console.WriteLine(i + 1 + ". " + this.SecondSection[questNumber].Answers[i] + ";");
                        }
                        var s = Console.ReadLine();
                        if (int.TryParse(s, out tempAnswer))
                        {
                            if ((tempAnswer-1) == this.SecondSection[questNumber].CorrAnswer)
                            {
                                Console.WriteLine("You are right!"); return true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong answer!"); return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!"); return false;
                        }
                    }
                case 3:
                    {
                        Console.WriteLine(this.ThirdSection[questNumber].Ask);
                        Console.WriteLine("Choose correct answer from list below:");
                        for (int i = 0; i < this.ThirdSection[questNumber].Answers.Length; i++)
                        {
                            if (i != this.ThirdSection[questNumber].Answers.Length - 1)
                            {
                                Console.Write(i + 1 + ". " + this.ThirdSection[questNumber].Answers[i] + ", ");
                            }
                            else Console.WriteLine(i + 1 + ". " + this.ThirdSection[questNumber].Answers[i] + ";");
                        }
                        var s = Console.ReadLine();
                        if (int.TryParse(s, out tempAnswer))
                        {
                            if ((tempAnswer-1) == this.ThirdSection[questNumber].CorrAnswer)
                            {
                                Console.WriteLine("You are right!"); return true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong answer!"); return false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer!"); return false;
                        }
                    }
                default: return false;
            }
                
        }

        



    }


}
