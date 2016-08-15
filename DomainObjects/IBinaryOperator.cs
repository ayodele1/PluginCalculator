
namespace DomainObjects
{
    /// <summary>
    /// Defines methods a calculator Operator plugin must implement
    /// </summary>
    public interface IBinaryOperator
    {
        string ArithmeticOperator { get; }

        double PerformCalculation(string value1, string value2);
    }
}
