using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
