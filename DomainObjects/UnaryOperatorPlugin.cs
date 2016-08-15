
using System.Reflection;
namespace DomainObjects
{
    public class UnaryOperatorPlugin : Plugin
    {
        public UnaryOperatorPlugin(string name, object assemblyInstance, object invokeableMethod, string operatorSymbol)
            : base(name, assemblyInstance, invokeableMethod, operatorSymbol)
        {

        }

        public override double Calculate(string value1, string value2)
        {
            //Value2
            string[] args = { value1 };
            var result = (base.InvokableMethod as MethodInfo).Invoke(base.AssemblyInstance, args);
            return (double)result;
        }
    }
}
