using Autofac;
using MultiServerEngine.Engine.Interfaces;

namespace LoginServer
{
    public class LoginServerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoginApplication>().As<IServerApplication>();
            base.Load(builder);
        }
    }
}