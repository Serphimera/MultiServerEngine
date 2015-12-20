using System;
using System.Net;
using ExitGames.Logging;
using MultiServerEngine.Configuration.Implementation;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Engine.Implementation;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Server.Implementation;
using MultiServerEngine.Peer.Server.Interfaces;

namespace LoginServer
{
    public class LoginApplication : IServerApplication
    {
        private ILogger Logger { get; set; }
        private ServerEngine ParentServer { get; set; }
        private IServerData Data { get; set; }

        public LoginApplication(ILogger logger, ServerEngine engine)
        {
            Logger = logger;
            ParentServer = engine;
            Data = new ServerData
            {
                ApplicationName = LoginServer.Default.ApplicationName,
                MasterEndPoint = new IPEndPoint(IPAddress.Parse(LoginServer.Default.MasterServerIP), LoginServer.Default.MasterServerPort),
                ServerPort = LoginServer.Default.TcpPort,
                Type = ServerType.LoginServer
            };
        }

        public void Setup()
        {
            Logger.InfoFormat("Setup for IServerApplication {0} requested.", GetType().Name);
            Logger.InfoFormat("Trying to connect to MasterServer on {0} for application {1} of type {2}", Data.MasterEndPoint, Data.ApplicationName, Data.Type);
            ParentServer.ConnectToServerTcp(Data.MasterEndPoint, LoginServer.Default.MasterServerName, Data);
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