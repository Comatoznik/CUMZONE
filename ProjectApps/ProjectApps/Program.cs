using System;
using System.IO;

namespace ProjectApps
{
    class Program
    {
        static void Main(string[] args)
        { //Задания Д27  № 7321
            Log("_________SESSION STARTED__________"+'\n');
            Console.Write("Input area count: ");
            int area_count = int.Parse(Console.ReadLine());//количество участков
            Log("Area count : " + area_count.ToString()+ '\n');
            Console.WriteLine("Input time: ");
            int time = Convert.ToInt32(Console.ReadLine());//время переезда
            Log("Time : " + time + '\n');
            var x = 0;// текущее значение х
            Log("X = " + x + '\n');
            int y = time;//текущее значение y
            Log("y = " + y + '\n');
            int y1, y2; // переменные, необходимы для подсчета
            for (int i = 0; i < area_count; i++) // проходимся по участкам
            {
                
                Console.WriteLine("Input first time: ");
                int first = Convert.ToInt32(Console.ReadLine()); // ввод первого числа (секунд)
                Log("First value is " + first + '\n');
                Console.WriteLine("Input second time: ");
                int second = int.Parse(Console.ReadLine()); // ввод второго числа
                Log("Second value is : " + second + '\n');
                x += first; // значение х увеличивается на первое введенное число
                Log("x is " + x + '\n');
                y1 = y + second; // увеличивается значение переменной у1 на второе введенное число
                Log("First result is " + y1 + '\n');
                y2 = x + time; // переменная у1 принимает значение х и времени
                Log("Second result is : " + y2 + '\n');
                if (y1 < y2) // если у1 меньше у2
                {
                    y = y1; // сумма будет у1
                    Log("First value smaller, y is :" + y + '\n');
                }
                else //если наоборот
                {
                    y = y2; //сумма будет у2
                    Log("Second value smaller, y is :" + y + '\n');
                }
            }
            Console.WriteLine(y);
            Log("Result is :" + y+'\n');
            Log("_______SESSION FINISHED_________"+'\n');
        }

        public static void Log(string message)
        {
            File.AppendAllText("D:\\log.txt", message);
        }
    }
}
