namespace MultiServerEngine.Engine.Interfaces
{
    public interface IServerApplication
    {
        void Setu();
        void TearDown();
        void OnStopRequested();
        void OnServerConnectionFailed(int errorCode, string errorMessage, object state);
    }
}