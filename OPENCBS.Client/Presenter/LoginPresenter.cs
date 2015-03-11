using OPENCBS.Client.Interface.Presenter;
using OPENCBS.Client.Interface.View;

namespace OPENCBS.Client.Presenter
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _view;

        public LoginPresenter(ILoginView view)
        {
            _view = view;
        }

        public void Run()
        {
            _view.Run();
        }

        public object View
        {
            get { return _view; }
        }
    }
}
