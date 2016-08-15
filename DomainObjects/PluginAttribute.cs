using System;

namespace DomainObjects
{
    /// <summary>
    /// Marks a class as an attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginAttribute : Attribute
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public PluginAttribute(string name)
        {
            _name = name;
        }
        public PluginAttribute() { }
    }
}
