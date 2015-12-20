using Autofac;
using MultiServerEngine.Engine.Interfaces;

namespace MasterServer
{
    public class MasterServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MasterApplication>().As<IServerApplication>();
            base.Load(builder);
        }
    }
}