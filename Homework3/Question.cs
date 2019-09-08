using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Question
    {
        public string Ask { get; set; }
        public string[] Answers { get; set; }
        public int CorrAnswer { get; set; }
        public int Price { get; set; }

        public Question(int m, string text)
        {
            this.Answers = new string[5];
            string[] words = text.Split(new char[] { ' ' });
            this.Ask = words[0];
            this.Answers[0] = words[1];
            this.Answers[1] = words[2];
            this.Answers[2] = words[3];
            this.Answers[3] = words[4];
            this.Answers[4] = words[5];
            this.CorrAnswer = int.Parse(words[6]) - 1;
            this.Price = m * words[0].Length;
        }

    }
}
