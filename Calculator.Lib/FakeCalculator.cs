namespace Calculator.Lib
{
    public class FakeCalculator
    {
        public decimal Add(decimal numb1 , decimal numb2)
        {
            return numb1 + numb2;   
        }
        public decimal Divide(decimal num1, decimal num2)
        {
            throw new NotImplementedException();
        }
        public decimal Multiply(decimal num1, decimal num2)
        {
           return num1 * num2;
        }
        public decimal Subtract(decimal num1, decimal num2)
        {
            throw new NotImplementedException();
        }


    }
}