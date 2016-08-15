
using ApplicationHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
namespace DomainObjects
{
    public class PluginManager
    {
        private List<Plugin> _plugins;
        /// <summary>
        /// Loads all Dlls found in the executing assembly
        /// </summary>
        ///

        public List<Plugin> LoadedPlugins
        {
            get { return _plugins; }
            set { _plugins = value; }
        }

        public PluginManager()
        {
            _plugins = new List<Plugin>();
            LoadPluginsFromCompiledDLL();
        }
        public void LoadPluginsFromCompiledDLL()
        {
            var pluginAssemblies = Directory.GetFiles(DirectoryHelper.PluginDLLsDirectory, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".dll"));
            pluginAssemblies = GetPluginsAssembliesByAttribute<PluginAttribute>(pluginAssemblies, "CalculatorPlugin");
            foreach (var assembly in pluginAssemblies)
            {
                var assemblyInstance = Assembly.LoadFrom(assembly);
                var t = assemblyInstance.ExportedTypes.First();
                if (t != null)
                {
                    Plugin p;
                    var o = Activator.CreateInstance(t);
                    MethodInfo mi = t.GetMethod("PerformCalculation");
                    String arithmeticOperator = (String)t.GetProperty("ArithmeticOperator").GetValue(o);
                    var inheritedInterface = t.GetInterfaces().SingleOrDefault(x => x == typeof(IBinaryOperator) || x == typeof(IUnaryOperator));
                    if (inheritedInterface != null)
                    {
                        if (inheritedInterface == typeof(IBinaryOperator))
                        {
                            p = new BinaryOperatorPlugin(t.Name, o, mi, arithmeticOperator);
                        }
                        else
                        {
                            p = new UnaryOperatorPlugin(t.Name, o, mi, arithmeticOperator);
                        }

                        _plugins.Add(p);
                    }


                    ///Plugin p = new Plugin(t.Name, o);

                }

            }

        }


        private IEnumerable<string> GetPluginsAssembliesByAttribute<T>(IEnumerable<string> pluginDlls, string constructorArgument = "")
            where T : Attribute
        {
            List<string> result = new List<string>();
            if (pluginDlls != Enumerable.Empty<string>())
            {
                foreach (var dllFile in pluginDlls)
                {
                    var pluginAssembly = Assembly.ReflectionOnlyLoadFrom(dllFile);
                    LoadReferencedAssemblies(pluginAssembly);

                    var plugins =
                        from type in pluginAssembly.ExportedTypes
                        let pluginOfType = type.GetCustomAttributesData().SingleOrDefault(
                            attrData => attrData.AttributeType.Name == typeof(T).Name)

                        where pluginOfType != null

                        let constructorArg = pluginOfType.ConstructorArguments.SingleOrDefault(
                            carg => string.Compare(carg.Value.ToString(), constructorArgument, false) == 0)
                        select new
                        {
                            pluginOfType,
                            targ = constructorArg == null ? null : constructorArg.Value.ToString()

                        };

                    if (plugins.Any())
                    {
                        result.Add(dllFile);
                    }
                }
            }
            return result.AsEnumerable();
        }

        private static void LoadReferencedAssemblies(Assembly pluginAssembly)
        {
            foreach (var referencedAssembly in pluginAssembly.GetReferencedAssemblies().Where(assbly => string.Compare(assbly.Name, "mscorlib") != 0))
            {
                try
                {
                    Assembly.ReflectionOnlyLoadFrom(Path.Combine(DirectoryHelper.ExecutingAssemblyLocation, string.Concat(referencedAssembly.Name, ".dll")));
                }
                catch (Exception)
                {
                    Assembly.ReflectionOnlyLoadFrom(DirectoryHelper.DomainObjectsAssemblyLocation);
                }

            }
        }

        /// <summary>
        /// Loads all created plugins that are serialized to file.
        /// </summary>
        public void LoadPluginsFromFile() { }

        /// <summary>
        /// Saves all created plugins (name and description) to file.
        /// </summary>
        public void SavePluginsToFile() { }
    }
}
