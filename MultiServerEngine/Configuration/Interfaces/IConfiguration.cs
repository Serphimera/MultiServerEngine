namespace MultiServerEngine.Configuration.Interfaces
{
    public interface IConfiguration
    {
        void AddConfiguration(object configuration);
        T GetConfiguration<T>() where T : class;
    }
}