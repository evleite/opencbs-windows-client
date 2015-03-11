namespace OPENCBS.Client.Interface.View
{
    public interface ILoginView
    {
        bool LoggedIn { get; set; }
        void Run();
    }
}
