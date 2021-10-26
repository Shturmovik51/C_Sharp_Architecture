namespace С_Sharp_Architecture
{
    public class Methods
    {
        private double _factorialResult;
        private int _summResult;
        private int _maxEvenResult;

        public double Factorial(int number)
        {
            _factorialResult = 1;

            for (int i = 1; i <= number; i++)
            {
                _factorialResult *= i;                 
            }
            return _factorialResult;
        }

        public int SummOfAllNumbers(int number)
        {
            _summResult = 0;

            for (int i = 1; i <= number; i++)
            {
                _summResult += + i;
            }
            return _summResult;
        }

        public int MaxEvenNumber(int number)
        {
            _maxEvenResult = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    _maxEvenResult = i;
                }
            }
            return _maxEvenResult;
        }            
    }
}
