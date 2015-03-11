using System;
using System.Windows.Forms;
using OPENCBS.Client.Interface.Presenter;
using OPENCBS.Client.Interface.View;
using StructureMap;

namespace OPENCBS.Client
{
    public class AppContext : ApplicationContext
    {
        readonly IContainer _container;

        public AppContext(IContainer container)
        {
            _container = container;
            MainForm = GetLoginForm();
        }

        private Form GetMainForm()
        {
            var presenter = _container.GetInstance<IMainPresenter>();
            presenter.Run();
            return (Form) presenter.View;
        }

        private Form GetLoginForm()
        {
            var presenter = _container.GetInstance<ILoginPresenter>();
            presenter.Run();
            return (Form) presenter.View;
        }

        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            var view = sender as ILoginView;
            if (view != null)
            {
                if (view.LoggedIn)
                {
                    MainForm = GetMainForm();
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
            else
            {
                base.OnMainFormClosed(sender, e);
            }
        }
    }
}
