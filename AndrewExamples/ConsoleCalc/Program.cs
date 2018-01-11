﻿using System;
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

            string arithmeticAction; // арифметична дія, яку будемо виконувати

            Console.WriteLine("Введіть арифметичну дію:");
            arithmeticAction = Console.ReadLine();
           
            //ДОДАВАННЯ
            if (arithmeticAction == "+")
            {
                Console.WriteLine("Введіть доданок 1:");
                left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

                Console.WriteLine("Введіть доданок 2");
                right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

                result = left + right;
                Console.WriteLine(left + " + " + right + " = " + result);
            }

            //ВІДНІМАННЯ
            if (arithmeticAction == "-")
            {
                Console.WriteLine("Введіть зменшуване:");
                left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

                Console.WriteLine("Введіть від'ємник:");
                right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

                result = left - right;
                Console.WriteLine(left + " - " + right + " = " + result);
            }

            //МНОЖЕННЯ
            if (arithmeticAction == "*")
            {
                Console.WriteLine("Введіть множник 1:");
                left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

                Console.WriteLine("Введіть множник 2:");
                right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

                result = left * right;
                Console.WriteLine(left + " * " + right + " = " + result);
            }

            Console.ReadKey();
        }//Кінець виконання програми 
    }
}
