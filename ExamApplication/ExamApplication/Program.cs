using System;
using System.Threading;

namespace ExamApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rand = new Random();
                int num = rand.Next(1, 14);
                
                Console.WriteLine("Корт 1:");
                if (num > 1 && num < 14)
                {
                    Random rand1 = new Random();
                    int num1 = rand.Next(0, 2);
                    if (num1 == 0)
                    {
                        new Pro("Pro1").Play();
                        new Pro("Pro2").Play();
                    }
                    else if(num1==1)
                    {
                        new Regular("Regular1").Play();
                        new Regular("Regular2").Play();
                    }
                }
                else if(num==1)
                {
                    new Pro("Pro1").Play();
                    new Regular("Regular1").Play();
                }
                Console.WriteLine("\nКорт 2:");
                if (num > 1 && num < 14)
                {
                    Random rand1 = new Random();
                    int num1 = rand.Next(0, 2);
                    if (num1 == 0)
                    {
                        new Pro("Pro1").Play();
                        new Pro("Pro2").Play();
                    }
                    else if (num1 == 1)
                    {
                        new Regular("Regular1").Play();
                        new Regular("Regular2").Play();
                    }
                }
                else if (num == 1)
                {
                    new Pro("Pro1").Play();
                    new Regular("Regular1").Play();
                }
                Console.WriteLine(new string('-',30));
                Thread.Sleep(2500);
            }
        }
    }
}
