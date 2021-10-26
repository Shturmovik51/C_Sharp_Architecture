using System;

namespace С_Sharp_Architecture
{
    public class View
    {
        public void FactorialAnswer(double answer)
        {
            Console.WriteLine($"Факториал равет {answer}");
        }
        public void SummOfAllNumbersAnswer(int answer)
        {
            Console.WriteLine($"Сума от 1 до N равна {answer} ");
        }
        public void MaxEvenNumberAnswer(int answer)
        {
            Console.WriteLine($"максимальное четное число меньше N равно {answer}");
        }
    }
}
