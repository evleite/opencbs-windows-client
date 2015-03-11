namespace OPENCBS.Client.Interface.View
{
    public interface IView<in TCallbacks>
    {
        void Attach(TCallbacks presenterCallbacks);
    }
}
