using System;

namespace С_Sharp_Architecture
{
    public class InputController
    {
        private Protector _protector;

        public InputController()
        {
            _protector = new Protector();
        }

        public void InputNumber()
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа");
            Console.WriteLine("пожалуйста, введите число. ");
            

            int number = _protector.FoolProtectionInput();

            new ProgramController(_protector).OperationController(number);
        }        
    }
}
