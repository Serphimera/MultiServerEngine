using System;
using MultiServerEngine.Peer.Server.Interfaces;

namespace MultiServerEngine.Peer.Server.Implementation
{
    [Flags]
    public enum SType : byte
    {
        MasterServer = 0x00,
        LoginServer = 0x10,
        ChatServer = 0x20
    }

    public class ServerType : IServerType
    {
        private SType Type { get; }
    }
}