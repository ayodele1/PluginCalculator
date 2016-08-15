
namespace DomainObjects
{
    /// <summary>
    /// To specify unary operations
    /// </summary>
    public interface IUnaryOperator
    {
        string ArithmeticOperator { get; }


        /// <summary>
        /// Operation would be performed on one variable
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        double PerformCalculation(string value);
    }
}
