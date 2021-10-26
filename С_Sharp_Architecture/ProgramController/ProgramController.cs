using System;

namespace С_Sharp_Architecture
{
    public class ProgramController
    {
        private Protector _protector;
        private Methods _methods;
        private View _view;
        public ProgramController(Protector protector)
        {
            _protector = protector;
            _methods = new Methods();
            _view = new View();
        }

        public void OperationController(int number)
        {
            Console.WriteLine("Введите операцию:\n" +
                "1: Найти факториал числа\n" +
                "2: Найти сумму всех чисел от 0 до N\n" +
                "3: Найти наибольшее четное число в диапазоне от 0 до N");       

            switch (_protector.FoolProtectionInput())
            {
                case (1):
                    _view.FactorialAnswer(_methods.Factorial(number));
                    break;
                case (2):
                    _view.SummOfAllNumbersAnswer(_methods.SummOfAllNumbers(number));
                    break;
                case (3):
                    _view.MaxEvenNumberAnswer(_methods.MaxEvenNumber(number));
                    break;
                default:
                    Console.WriteLine("Мимо");
                    OperationController(number);
                    break;
            }

            Console.WriteLine("Еще что-нибудь?\n");
            OperationController(number);
        }
    }
}
