using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    //Клас з якого починається виконання програми
    class Program
    {
        //метод з якого починається виконання програми
        static void Main(string[] args)
        {//Початок виконання програми

            int left;//ліва частина арифметичної операції
            int right;// права частина арифметичної операції

            int result;//результат арифметичної операції

            string Action; // арифметична дія, яку будемо виконувати

            while (true)
            {
                Console.WriteLine("Введiть арифметичну дiю або 0 для виходу з програми:");
                Action = Console.ReadLine();

                //Вихід з програми
                if (Action == "0")
                    break;//оператор виходу з циклу

                //ДОДАВАННЯ
                if (Action == "+")
                {
                    Console.WriteLine("Введiть доданок 1:");
                    left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

                    Console.WriteLine("Введiть доданок 2");
                    right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

                    result = left + right;
                    Console.WriteLine(left + " + " + right + " = " + result);
                }

                //ВІДНІМАННЯ
                if (Action == "-")
                {
                    Console.WriteLine("Введiть зменшуване:");
                    left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

                    Console.WriteLine("Введiть вiд'ємник:");
                    right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

                    result = left - right;
                    Console.WriteLine(left + " - " + right + " = " + result);
                }

                //МНОЖЕННЯ
                if (Action == "*")
                {
                    Console.WriteLine("Введiть множник 1:");
                    left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

                    Console.WriteLine("Введiть множник 2:");
                    right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

                    result = left * right;
                    Console.WriteLine(left + " * " + right + " = " + result);
                }
            }
        }//Кінець виконання програми 
    }
}
