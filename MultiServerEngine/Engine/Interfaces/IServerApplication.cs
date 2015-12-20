namespace MultiServerEngine.Engine.Interfaces
{
    public interface IServerApplication
    {
        void Setup();
        void TearDown();
        void OnStopRequested();
        void OnServerConnectionFailed(int errorCode, string errorMessage, object state);
    }
}