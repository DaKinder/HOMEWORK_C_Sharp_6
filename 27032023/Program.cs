using System;
using System.Net.Http.Headers;

namespace HW6
{
    internal class Program
    {
        const int K1 = 0;
        const int K2 = 1;
        const int B1 = 2;
        const int B2 = 3;

        static void Main()
        {
            #region//ПЕРВАЯ ЗАДАЧА

            //Задача 41: Пользователь вводит с клавиатуры M чисел.
            //Посчитайте, сколько чисел больше 0 ввёл пользователь.

            //Стартовый блок
            Console.WriteLine("Подсчитаем сколько чисел больше нуля");
            Console.Write("Сколбко чисел будем считать? ");
            int count = Convert.ToInt32(Console.ReadLine());

            //Создание экземпляра класса
            MyClass counter = new MyClass();

            //Блок вызова методов
            int result = counter.Processor(count);

            //Блок вывода в консоль
            Console.WriteLine($"количество положительных чисел = {result}");
            Console.ReadLine();


            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
            //значения b1, k1, b2 и k2 задаются пользователем.
            #endregion 

            Program p = new Program();
            double[] userArray = p.UserInput();
            bool flag = p.CompareData(userArray);
            if (flag) p.FindCoordsOfPoint(userArray);
            else p.PrintOtherResult(userArray);
            Console.ReadLine();
        }

        double[] UserInput()
        {
            double[] arrayData = new double[4];
            Console.WriteLine("Найдём точку пересечения двух прямых");
            Console.WriteLine("Даны 2 уравнения: y = k1 * x + b1, y = k2 * x + b2");
            Console.Write($"Введите коэффициент k1: ");
            arrayData[K1] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите коэффициент k2: ");
            arrayData[K2] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите константу b1: ");
            arrayData[B1] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Введите константу b2: ");
            arrayData[B2] = Convert.ToDouble(Console.ReadLine());
            return arrayData;
        }

        bool CompareData(double[] arrayData)
        {
            if(arrayData[K1] != arrayData[K2]) return true;
            else return false;
        }

        void FindCoordsOfPoint(double[] arrayData)
        {
            double x = Math.Round((arrayData[B1] - arrayData[B2]) / (arrayData[K1] - arrayData[K2]), 2);
            double y = Math.Round(arrayData[B1] * x + arrayData[K2], 2);
            Console.WriteLine($"Координаты пересечения двух прямых: x = {x}, y = {y}");
            Console.ReadLine();
        }

        void PrintOtherResult(double[] userArray)
        {
            if (userArray[B1] != userArray[B2]) Console.WriteLine("Прымые параллельны!");
            else Console.WriteLine("Прямые совпадают!");
        }
    }
}
