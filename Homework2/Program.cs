using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //generating array with random integer elements in range [0..GetMaxValue] of random size in range [100..200]

            var firstArray = GetRandomizedArray(GetMaxValue());

            //output generated array
            ShowArray(firstArray);

            // find the most frequently used element of array
            MostFrequentlyUsed(firstArray);

            // find frequencies of all elements in array
            GetFrequency(firstArray);

            Console.ReadKey();                                  
        }


        public static void MostFrequentlyUsed(int[] data)
        {
            int tempElementFrequency = 1;
            int resElementNumber = 0;
            int resElementFrequency = 1;

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)// evaluating of frequency of data[i]
                {
                    if ((i != j) && (data[i] == data[j])) { tempElementFrequency += 1; }
                }
                if (tempElementFrequency > resElementFrequency) // if current element has bigger frequency we'll remember it
                {
                    resElementNumber = i;
                    resElementFrequency = tempElementFrequency;
                }
                tempElementFrequency = 1;

            }
            Console.WriteLine($"The most frequently used element is number {data[resElementNumber]} with frequency {resElementFrequency}");
        }

        public static void GetFrequency(int[] data)
        {
            var arrayElement = new int[2, data.Length]; //array with elements and frequencies
            int tempElementFrequency = 1;
            int tempIndex = -1;
            bool IsElement = false; // true if element of data is in arrayElement
            for (int i = 0; i < data.Length; i++) // first initialization
            {
                arrayElement[0, i] = -1;
            }

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)// evaluating of frequency of data[i]
                {
                    if ((i != j) && (data[i] == data[j])) { tempElementFrequency += 1; }
                }
                //input elements and their frequencies without iterations

                for (int j = 0; j < data.Length; j++)
                {
                    if (arrayElement[0, j] == data[i])
                    {
                        IsElement = true;
                    }
                }
                if (!IsElement)
                {
                        tempIndex += 1;
                        arrayElement[0, tempIndex] = data[i];
                        arrayElement[1, tempIndex] = tempElementFrequency;
                       
                }
                IsElement = false;
                tempElementFrequency = 1;
            }

            Console.WriteLine("Frequencies of elements in array");
            tempIndex = 0;
            while (arrayElement[0, tempIndex] >= 0)
            {
                Console.WriteLine($"Element {arrayElement[0, tempIndex]} has frequency {arrayElement[1, tempIndex]}");
                tempIndex++;
            }

        }



        public static int GetMaxValue()
        {
            int result;
            Console.Write("Please input maximum range for values of elements of an array being generated \nMax value = ");
            var temp_maxValue = Console.ReadLine();
            while (!int.TryParse(temp_maxValue, out result))
            {
                Console.Write("Uncorrect input! Try again! \nMax value = ");
                temp_maxValue = Console.ReadLine();
            }
            Console.WriteLine(result);
            return result;
        }
        public static int[] GetRandomizedArray(int maxItem = 100)
        {
            var rand = new Random();
            var n = rand.Next(100, 200);
            var result = new int[n];
            

            for (int i = 0; i < n; i++)
            {
                result[i] = rand.Next(maxItem);
            }


            return result;

        }

        public static void ShowArray(int[] data)
        {
            Console.WriteLine($"This array has {data.Length} items:");

            for (int i = 0; i < data.Length; i++)
            {
                if ((i % 25 == 0)&&(i!=0)) // output elements of array by 25 in line
                {
                    if (i == data.Length - 1)
                    {
                        Console.WriteLine($"{data[i]}");
                    }
                    else
                    {
                        Console.WriteLine($"{data[i]}, ");
                    }
                }
                else
                {
                    if (i == data.Length - 1)
                    {
                        Console.Write($"{data[i]}");
                    }
                    else
                    {
                        Console.Write($"{data[i]}, ");
                    }
                }
            }
            Console.WriteLine();
        }
    }


}
