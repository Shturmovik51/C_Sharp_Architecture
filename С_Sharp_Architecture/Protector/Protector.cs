using System;

namespace С_Sharp_Architecture
{
    public class Protector
    {
        public int FoolProtectionInput()    // защита от вода нечисловых значений
        {
            bool notFool = false;
            int num = 0;

            while (!notFool)
            {
                notFool = int.TryParse(Console.ReadLine(), out int number);
                if (!notFool) Console.WriteLine("Саймон сказал, 'число'!");
                num = number;
            }

            return num;
        }
    }
}
