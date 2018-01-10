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

            //ДОДАВАННЯ

            Console.WriteLine("Введіть доданок 1:");
            left = Convert.ToInt32(Console.ReadLine());//зчитуємо ліву частину

            Console.WriteLine("Введіть доданок 2");
            right = Convert.ToInt32(Console.ReadLine());//зчитуємо праву частину

            result = left + right;
            Console.WriteLine(left + " + " + right + " = " + result);

            Console.ReadKey();

        }//Кінець виконання програми 
    }
}
