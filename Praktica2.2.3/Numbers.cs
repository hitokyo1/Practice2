using System;
class Numbers
{
    public int firstNum = 0;
    public int secondNum = 0;
    public Numbers(int num1, int num2)
    {
        this.firstNum = num1;
        this.secondNum = num2;
    }
    public void changOfNumbers(int num1, int num2)
    {
        this.firstNum = num1;
        this.secondNum = num2;
    }
    public void conclusionOfNumbers()
    {
        Console.WriteLine($"Первое число: {this.firstNum}, второе число: {this.secondNum}");
    }
    public int sumOfNumbers()
    {
        return this.firstNum + this.secondNum;
    }
    public int maxOfNumbers()
    {
        if (this.firstNum > this.secondNum)
        {
            return this.firstNum;
        }
        return this.secondNum;
    }
}