
namespace DomainObjects
{
    /// <summary>
    /// All plugins have to implement this interface
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Name of the Plugin
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Brief description of what the plugin would do.
        /// </summary>
        string Description { get; set; }
    }
}
