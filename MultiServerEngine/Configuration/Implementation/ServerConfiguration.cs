using System.Collections.Generic;
using System.Linq;
using MultiServerEngine.Configuration.Interfaces;

namespace MultiServerEngine.Configuration.Implementation
{
    public class ServerConfiguration : IServerConfiguration
    {
        private readonly IList<object> _configuration = new List<object>();

        public void AddConfigutation(object configuration)
        {
            if (!_configuration.Contains(configuration))
            {
                _configuration.Add(configuration);
            }
        }

        public T GetConfiguration<T>() where T : class
        {
            return _configuration.FirstOrDefault(c => c is T) as T;
        }
    }
}