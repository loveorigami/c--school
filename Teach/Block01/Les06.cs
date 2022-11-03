using System;

namespace Teach.Block01
{
    /// <summary>
    /// https://my.mshp.ru/pupil/calendar/1722/units/steps/3011/elements/7096/detail/online/show/391761
    /// Тема: Операторы ветвления и логические операции в языке C#. Занятие 2
    /// </summary>
    public class Les06
    {
        public void Task01()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            if (n >= 2 || k >= 40)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Not enough");
            }
        }
    }
}
