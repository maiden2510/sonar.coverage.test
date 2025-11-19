namespace Sonar.Coverage.Service2.Test;

public class CalculatorTest
{
    [Test]
    public void Test1()
    {
        Calculator.Decrement(10);
        Calculator.Decrement(20);
        Assert.Pass();
    }
}