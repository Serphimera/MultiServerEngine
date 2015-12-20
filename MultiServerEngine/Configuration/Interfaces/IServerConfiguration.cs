namespace MultiServerEngine.Configuration.Interfaces
{
    public interface IServerConfiguration
    {
        void AddConfigutation(object configuration);
        T GetConfiguration<T>() where T : class;
    }
}