using System;
using System.Net;
using ExitGames.Logging;
using MultiServerEngine.Configuration.Implementation;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Engine.Implementation;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Server.Implementation;

namespace MasterServer
{
    public class MasterApplication : IServerApplication
    {
        private ILogger Logger { get; set; }
        private ServerEngine ParentServer { get; set; }
        private IServerData Data { get; set; }

        public MasterApplication(ILogger logger, ServerEngine engine)
        {
            Logger = logger;
            ParentServer = engine;
            Data = new ServerData
            {
                ApplicationName = MasterServer.Default.ApplicationName,
                MasterEndPoint = new IPEndPoint(IPAddress.Parse(MasterServer.Default.MasterServerIP), MasterServer.Default.MasterServerPort),
                ServerPort = MasterServer.Default.TcpPort,
                Type = ServerType.MasterServer
            };
        }

        public void Setup()
        {
            Logger.InfoFormat("Setup for IServerApplication {0} requested.", GetType().Name);
        }

        public void TearDown()
        {
            Logger.InfoFormat("TearDown for application {0} requested.", GetType().Name);
        }

        public void OnStopRequested()
        {
            Logger.InfoFormat("OnStopRequested for application {0} requested.", GetType().Name);
        }

        public void OnServerConnectionFailed(int errorCode, string errorMessage, object state)
        {
            Logger.InfoFormat("OnServerConnectionFailed for application {0} requested with parameters {1} - {2} ",
                GetType().Name, errorCode, errorMessage);
        }

        public string GetApplicationName()
        {
            return Data.ApplicationName;
        }
    }
}