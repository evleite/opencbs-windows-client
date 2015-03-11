using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace OPENCBS.Client
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry ()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
            });
        }
    }
}
