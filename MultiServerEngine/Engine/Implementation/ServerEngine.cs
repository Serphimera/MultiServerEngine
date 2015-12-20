using System.IO;
using Autofac;
using Autofac.Configuration;
using ExitGames.Logging;
using ExitGames.Logging.Log4Net;
using log4net;
using log4net.Config;
using MultiServerEngine.Configuration.Implementation;
using MultiServerEngine.Configuration.Interfaces;
using MultiServerEngine.Engine.Interfaces;
using MultiServerEngine.Peer.Client.Interfaces;
using MultiServerEngine.Peer.Server.Interfaces;
using Photon.SocketServer;
using Photon.SocketServer.ServerToServer;
using LogManager = ExitGames.Logging.LogManager;

namespace MultiServerEngine.Engine.Implementation
{
    public class ServerEngine : ApplicationBase
    {
        private ILogger Logger { get; set; }
        private IServerPeerFactory ServerFactory { get; set; }
        private IClientPeerFactory ClientFactory { get; set; }
        private IServerApplication Server { get; set; }

        protected override PeerBase CreatePeer(InitRequest initRequest)
        {
            IConfiguration conf = new ClientConfiguration();
            conf.AddConfiguration(initRequest);
            return ClientFactory.CreateClientPeer<PeerBase>(conf);
        }

        protected override ServerPeerBase CreateServerPeer(InitResponse initResponse, object state)
        {
            IConfiguration conf = new ServerConfiguration();
            conf.AddConfiguration(initResponse);
            return ServerFactory.CreateServerPeer<ServerPeerBase>(conf);
        }

        protected override void Setup()
        {
            #region Logging

            LogManager.SetLoggerFactory(Log4NetLoggerFactory.Instance);
            GlobalContext.Properties["LogFileName"] = ApplicationName;
            GlobalContext.Properties["LogFilePath"] = Path.Combine(BinaryPath, "logs");
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Path.Combine(BinaryPath, "log4net.config")));
            Logger = LogManager.GetCurrentClassLogger();

            #endregion

            Logger.InfoFormat("Setup for application {0} requested.", ApplicationName);

            #region Autofac

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterInstance(this).SingleInstance();
            builder.RegisterType<IServerPeerFactory>();
            builder.RegisterType<IClientPeerFactory>();
            builder.RegisterType<IServerApplication>();
            builder.RegisterInstance(Logger).As<ILogger>();
            builder.RegisterModule(new XmlFileReader(Path.Combine(BinaryPath, "Modules\\" + ApplicationName + ".config")));

            #endregion

            IContainer container = builder.Build();

            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                ServerFactory = scope.Resolve<IServerPeerFactory>();
                ClientFactory = scope.Resolve<IClientPeerFactory>();
                Server = scope.Resolve<IServerApplication>();
            }

            Server.Setup();
        }

        protected override void TearDown()
        {
            Logger.InfoFormat("TearDown for application {0} requested.", ApplicationName);
            Server.TearDown();
        }

        protected override void OnStopRequested()
        {
            Logger.InfoFormat("OnStopRequested for application {0} requested.", ApplicationName);
            Server.OnStopRequested();
            base.OnStopRequested();
        }

        protected override void OnServerConnectionFailed(int errorCode, string errorMessage, object state)
        {
            Logger.InfoFormat("OnServerConnectionFailed for application {0} requested with parameters {1} - {2} ",
                ApplicationName, errorCode, errorMessage);
            Server.OnServerConnectionFailed(errorCode, errorMessage, state);
        }
    }
}