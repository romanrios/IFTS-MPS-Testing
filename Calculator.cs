namespace Testing;

public class Calculator
{
    public int Add(int num1, int num2) => num1 + num2;
    public int Substract(int num1, int num2) => num1 - num2;

    public int Multiply(int num1, int num2) => num1 * num2;

    public int Divide(int num1, int num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("You can't divide by zero");
        }
        return num1 / num2;
    }

    public bool IsEven(int num1) => num1 % 2 == 0;

}