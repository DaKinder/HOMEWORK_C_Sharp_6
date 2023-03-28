using System;

namespace HW6
{
    internal class Program
    {
        static void Main()
        {
            //Задача 41: Пользователь вводит с клавиатуры M чисел.
            //Посчитайте, сколько чисел больше 0 ввёл пользователь.

            //Стартовый блок
            Console.WriteLine("Подсчитаем сколько чисел больше нуля");
            Console.Write("Сколбко чисел будем считать? ");
            int count = Convert.ToInt32(Console.ReadLine());

            //Создание экземпляра класса
            MyClass counter= new MyClass();

            //Блок вызова методов
            int result = counter.Processor(count);

            //Блок вывода в консоль
            Console.WriteLine($"количество положительных чисел = {result}");
            Console.ReadLine();


            //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
            //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
            //значения b1, k1, b2 и k2 задаются пользователем.


        }
    }
}
