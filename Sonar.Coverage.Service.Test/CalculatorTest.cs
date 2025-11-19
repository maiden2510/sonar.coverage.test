namespace Sonar.Coverage.Service.Test;

public class CalculatorTest
{
    [Test]
    public void Test1()
    {
        Calculator.Increment(1);
        Calculator.Increment(2);
        Calculator.Increment(4);
        
        Calculator.Decrement(1);
        Calculator.Decrement(2);
        Calculator.Decrement(4);
        Assert.Pass();
    }
}