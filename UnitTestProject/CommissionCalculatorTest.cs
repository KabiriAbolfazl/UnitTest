using BusinessLogic;

namespace UnitTestProject;

public class CommissionCalculatorTest
{
    [Fact]
    public void Test_CalculateVisitorCommission()
    {
        CommissionCalculator calculator = new();
        var result = calculator.CalcCommission(1000, Enums.AgentType.Visitor);
        Assert.Equal(4_000_000_000, result);
    }

    [Fact]
    public void Test_CalculateSupervisorCommission()
    {
        CommissionCalculator calculator = new();
        var result = calculator.CalcCommission(200, Enums.AgentType.Supervisor);
        Assert.Equal(1_200_000_000, result);
    }
}