using System;

namespace AlgorithmProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure and Algorithm Program");

            Console.WriteLine("Select Program to Execute:\n" +
                "1)Program for the Insertion Sort of String\n" +
                "2)Program for the Bubble Sort of Integer\n");

            int option=Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Performing Insertion Sort:");
                    string[] words = { "Hemant", "Arun", "Dhurve", "John Cena", "Triple H" };

                    InsertionSort sort = new InsertionSort();
                    sort.InsertSort(words);

                    foreach(var item in words)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 2:

                    BubbleSort bubble=new BubbleSort();
                    bubble.BubbleSrt();

                    break;


                default:
                    Console.WriteLine("Please Select Proper Option");
                    break;
            }
        }
    }
}