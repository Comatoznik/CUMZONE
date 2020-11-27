using System;

namespace ProjectApps
{
    class Program
    {
        static void Main(string[] args)
        { //Задания Д27  № 7321
            Console.Write("Input area count: ");
            int area_count = int.Parse(Console.ReadLine());//количество участков
            Console.WriteLine("Input time: ");
            int time = Convert.ToInt32(Console.ReadLine());//время переезда
            var x = 0;// текущее значение х
            int y = time;//текущее значение y
            int y1, y2; // переменные, необходимы для подсчета
            for(int i=0;i<area_count;i++) // проходимся по участкам
            {
                Console.WriteLine("Input first time: ");
                int first = Convert.ToInt32(Console.ReadLine()); // ввод первого числа (секунд)
                Console.WriteLine("Input second time: ");
                int second = int.Parse(Console.ReadLine()); // ввод второго числа
                x += first; // значение х увеличивается на первое введенное число
                y1 = y + second; // увеличивается значение переменной у1 на второе введенное число
                y2 = x + time; // переменная у1 принимает значение х и времени
                if (y1 < y2) // если у1 меньше у2
                {
                    y = y1; // сумма будет у1
                }
                else //если наоборот
                {
                    y = y2; //сумма будет у2
                }
            }
            Console.WriteLine(y);
        }
    }
}
