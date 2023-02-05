using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class telephone
    {
        public double time;
        public double price;
        public int day;
        public double Summ()
        {
            double result = time * price;
            if (day == 6 || day == 7)
            {
                result *= 0.9;
            }
            return result;

        }
    }
    public class sqrt1
    {
        public void Repeat()
        {
            int Pow;
            for (int i = 1; i < 11; i++)
            {
                Pow = Convert.ToInt32(Math.Pow(i, 2));
                Console.WriteLine($"{i} в квадрате = {Pow}");
                sqrt2 stop1 = new sqrt2();
                stop1.Stop(Pow);
            }
        }
    }

    public class sqrt2
    {
        public void Stop(int number)
        {
            if (number > 25)
            {
                Console.WriteLine("Квадрат числа больше 25!");
            }
        }
    }

    public class App
    {
        static void Main()
        {
            static void Zadanie1()
            {
                
                    try
                    {
                        telephone phone = new telephone();
                    while (phone.day < 1 || phone.day > 7)
                    {
                        Console.WriteLine("Введите день недели ");
                        phone.day = int.Parse(Console.ReadLine());
                        if (phone.day < 1 || phone.day > 7)
                            Console.WriteLine("ошибка");
                    }
                            Console.WriteLine("Введите время ");
                            phone.time = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Введите стоимость в минуту ");
                            phone.price = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Стоимость разговора {phone.Summ()}");
                    }
                    catch
                    {
                        Console.WriteLine("вы ввели не число");
                    }
            }
            Zadanie1();

            static void Zadanie2()
            {
                try
                {
                    sqrt1 cycle = new sqrt1();
                    cycle.Repeat();
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка!");
                }
            }
            Zadanie2();

        }

    }
}
