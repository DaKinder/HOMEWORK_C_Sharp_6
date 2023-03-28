using System;

namespace HW6
{
    public class MyClass
    {
        int _sum = 0;
        readonly int _counter = 1;

        int UserInput(int count)
        {
            Console.Write("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        bool CheckNumber(int num)
        {
            if (num > 0) return true;
            return false;
        }

        int CountNumbers(int num)
        {
            return _sum += num;
        }

        public int Processor(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
            {
                int num = UserInput(count);
                bool flag = CheckNumber(num);
                if (flag) result = CountNumbers(_counter);
            }
            return result;
        }
    }
}
