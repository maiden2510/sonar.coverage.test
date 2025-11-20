namespace Sonar.Coverage.Service.Test;

public class CalculatorTest
{
    [Test]
    public void Test1()
    {
        Calculator.Increment(1);
        Calculator.Increment(2);
        Calculator.Increment(4);

        Assert.Pass();
    }
}