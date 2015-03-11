using System.Windows.Forms;
using StructureMap;

namespace OPENCBS.Client
{
    public class Bootstrapper
    {
        private readonly IContainer _container;

        public Bootstrapper()
        {
            _container = new Container();
        }

        public ApplicationContext GetApplicationContext()
        {
            _container.Configure(c => c.AddRegistry<DefaultRegistry>());
            _container.Inject<ApplicationContext>(new AppContext(_container));
            return _container.GetInstance<ApplicationContext>();
        }
    }
}
