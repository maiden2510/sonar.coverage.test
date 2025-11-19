namespace Sonar.Coverage.Service.Test;

public class Tests
{
    [Test]
    public void Test1()
    {
        Calculator.Increment(1);
        Calculator.Increment(2);
        Calculator.Increment(4);
        Calculator.Decrement(1);
        Assert.Pass();
    }
}