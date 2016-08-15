namespace DomainObjects
{
    public abstract class Plugin : IPlugin
    //where T: class
    {
        private string _name;
        private string _description;
        private object _assemblyInstance;
        private object _invokeableMethod;
        private string _operatorSymbol;

        public string OperatorSymbol
        {
            get { return _operatorSymbol; }
            set { _operatorSymbol = value; }
        }


        public object InvokableMethod
        {
            get { return _invokeableMethod; }
            set { ; }
        }


        public Plugin(string name, object assemblyInstance, object invokeableMethod, string operatorSymbol)
        {
            _name = name;
            _assemblyInstance = assemblyInstance;
            _invokeableMethod = invokeableMethod;
            _operatorSymbol = operatorSymbol;
            _description = "This is a test Description";
        }

        public object AssemblyInstance
        {
            get { return _assemblyInstance; }
            set { _assemblyInstance = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public abstract double Calculate(string value1, string value2);

    }
}
