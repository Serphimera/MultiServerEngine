namespace MultiServerEngine.Peer.Server.Interfaces
{
    public interface IServerPeer
    {
        bool Register();
        bool Connect();
        bool Disconnect();
    }
}