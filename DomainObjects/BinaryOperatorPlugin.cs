using System.Reflection;

namespace DomainObjects
{
    public class BinaryOperatorPlugin : Plugin
    {
        public BinaryOperatorPlugin(string name, object assemblyInstance, object invokeableMethod, string operatorSymbol)
            : base(name, assemblyInstance, invokeableMethod, operatorSymbol)
        {

        }
        public override double Calculate(string value1, string value2)
        {
            string[] args = { value1, value2 };
            var result = (base.InvokableMethod as MethodInfo).Invoke(base.AssemblyInstance, args);
            return (double)result;
        }
    }
}
