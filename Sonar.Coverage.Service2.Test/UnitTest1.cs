namespace Sonar.Coverage.Service2.Test;

public class CalculatorTest
{
    [Test]
    public void Test1()
    {
        Calculator.Decrement(1);
        Calculator.Decrement(2);
        Assert.Pass();
    }
}