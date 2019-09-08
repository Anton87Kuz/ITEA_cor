using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Date doj = new Date(9);
            var obj = new Date();
            List<int> sum = new List<int>();
            sum.

            //doj.SetDay(5);
               
            Console.WriteLine(doj.getDay()+"  " +obj.getDay());
            Console.ReadKey();
        }

        class Date
        {
            private int _day;
            
            public Date(int day)
            {
                
                _day = day;
            }

            public Date()
            {
                _day = 100;
            }
        
            public int getDay()
            {
                return _day;
            }

            public void SetDay(int day)
            {
                _day= day;
            }
        }
    }
}
