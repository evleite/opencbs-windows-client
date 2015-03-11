using System.Windows.Forms;
using OPENCBS.Client.Interface.View;

namespace OPENCBS.Client.View
{
    public partial class LoginView : Form, ILoginView
    {
        public LoginView()
        {
            InitializeComponent();
        }

        public bool LoggedIn { get; set; }

        public void Run()
        {
            Show();
        }
    }
}
