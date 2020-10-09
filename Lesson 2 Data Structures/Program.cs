using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lesson_2_Data_Structures
{
    class Program
    {
        private static void Task1()
        {
            //Initialzation
            string[] names = { "Ivan", "Peter", "John", "Jane", "Maria" };
            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 22);
            bdays[1] = new DateTime(2001, 01, 02);
            bdays[2] = new DateTime(2002, 01, 02);
            bdays[3] = new DateTime(2003, 01, 02);
            bdays[4] = new DateTime(2004, 01, 02);

            //User Input
            Console.Write("Please select index (0-4): ");
            int index = int.Parse(Console.ReadLine());

            //Program Logic
            string periodOfMonth  = GetPeriodOfMonth(bdays, index);

            string monthName = GetNameOfMonth(bdays[index].Month);

            //Output
            Console.WriteLine($"{names[index]} is born in the {periodOfMonth} of {monthName} ");
        }

        private static string GetNameOfMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "february";
            if (month == 3) return "march";
            if (month == 4) return "april";
            if (month == 5) return "may";
            if (month == 6) return "june";
            if (month == 7) return "july";
            if (month == 8) return "august";
            if (month == 9) return "september";
            if (month == 10) return "october";
            if (month == 11) return "november";
            if (month == 12) return "december";

            return "Unknown";
        }

        private static string GetPeriodOfMonth(DateTime[] bdays, int index)
        {
            int day = bdays[index].Day;
            string periodOfMonth = "beginning";

            if (day > 10)
            {
                periodOfMonth = "middle";
            }
            if (day > 20)
            {
                periodOfMonth = "end";
            }

            return periodOfMonth;
        }

        private static void Task2()
        {
            //Initialization and Input
            string sentence = "Write a C# Sharp Program to display the following pattern using the alphabet.";

            //Program Logic
            string[] words = sentence.Split(' ');
            string longest = "";
            foreach (string word in words)
            {
                if(longest.Length < CleanWord(word).Length)
                {
                    longest = word;
                }
            }

            //Output
            Console.WriteLine($"The longest word is '{longest}' ");
        }

        private static string CleanWord(string word)
        {
            return word.Replace(".", " ");
        }

        private static void Task3()
        {
            //Initialization
            string sentence = "Display the pattern like pyramid using the alphabet";

            //Program Logic
            string[] words = sentence.Split(' ');
            Stack<string> stack = new Stack<string>();

            foreach (string word in words)
            {
                stack.Push(word);
            }

            //Output
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }

        private static void Array()
        {
            int[] tab = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.Write("Please select index (0-9): ");
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine("Index selected send back : " + tab[index]);

            for(int i = 0; i<tab.Length; i++)
            {
                if (i < tab.Length - 1)
                    Console.Write(tab[i] + "; ");
                else
                    Console.Write(tab[i]);
            }
        }

        private static void Stack_Queue()
        {
            Stack stack = new Stack();
            Queue file = new Queue();

            for(int i = 0; i<10; i++)
            {
                stack.Push(i);
                file.Enqueue(10 + i);
            }
            Console.WriteLine("First element extract from the stack (9) = " + stack.Peek());
            Console.WriteLine("First element extract from the queue (10) = " + file.Peek());

            int stackLength = stack.Count;
            int fileLength = file.Count;
            for(int i = 0; i<(stackLength + fileLength); i++)
            {                
                if(i<stackLength)
                {
                    Console.Write(stack.Pop() + " ");
                    if (i == stackLength - 1)
                        Console.WriteLine();
                }
                else
                {
                    Console.Write(file.Dequeue() + " ");
                }
            }
            //The stack and the queue are now empty
        }

        private static void List()
        {
            List<int> list = new List<int>(10);

            for(int i = 0; i< list.Capacity; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("Number of elements in the list = " + list.Count);

            for(int i = 0; i<list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            //Task3();

            //Array();

            //Stack_Queue();

            //List();

            Console.ReadKey();
        }
    }
}
