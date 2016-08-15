
using System.IO;
using System.Reflection;
namespace ApplicationHelpers
{
    public static class DirectoryHelper
    {
        public static string ExecutingAssemblyLocation
        {
            get { return new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName; }
        }

        public static string ExecutingAssemblyTopDirectoryLocation
        {
            get { return Directory.GetParent(ExecutingAssemblyLocation).FullName; }
        }

        public static string PluginComplationDirectory
        {
            get { return Path.Combine(ExecutingAssemblyTopDirectoryLocation, @"UserPlugins\Plugins\PluginLibrary"); }
        }

        public static string PluginDLLsDirectory
        {
            get { return Path.Combine(ExecutingAssemblyTopDirectoryLocation, @"UserPlugins\Assembly"); }
        }

        public static string DomainObjectsAssemblyLocation
        {
            get { return Path.Combine(ExecutingAssemblyLocation, "DomainObjects.dll"); }
        }
    }
}
