using static BusinessLogic.Enums;

namespace BusinessLogic;
public class CommissionCalculator
{
    private const decimal _baseCommission = 2_000_000;
    private const byte _visitorCoefficient = 2;
    private const byte _supervisorCoefficient = 3;

    public decimal CalcCommission(uint sellCount, AgentType agentType)
    {
        switch (agentType)
        {
            case AgentType.Visitor:
                return sellCount * _baseCommission * _visitorCoefficient;
            case AgentType.Supervisor:
                return sellCount * _baseCommission * _supervisorCoefficient;
            default:
                return 0;
        }
    }
}

public static class Enums
{
    public enum AgentType : byte
    {
        Visitor = 0,
        Supervisor = 1
    }
}