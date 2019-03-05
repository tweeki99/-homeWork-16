using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = File.ReadAllText("1.txt").Split(' ').Select(n => int.Parse(n)).ToArray();

            int sizeNumbers = numbers.Length;

            for (int i = 0; i < sizeNumbers; i++)
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = numbers[numbers.Length - 2] + numbers[numbers.Length - 3];
            }

            foreach (var i in numbers)                                                                //первое задание
            {
                Console.WriteLine(i);
            }

            using (var stream = new StreamWriter("1.txt"))
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (i == numbers.Length - 2)
                        stream.Write(numbers[i]);
                    else
                        stream.Write(numbers[i] + " ");
                }
            }

            //int[] numbers = File.ReadAllText("INPUT.txt").Split(' ').Select(n => int.Parse(n)).ToArray();

            //using (var stream = new StreamWriter("OUTPUT.txt"))                                     //второе задание
            //{
            //    stream.Write(numbers[0]+ numbers[1]);
            //}

            Console.ReadKey();
        }
    }
}
