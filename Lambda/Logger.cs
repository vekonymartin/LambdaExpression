using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Logger
    {
        private Action<string> logMethod;
        
        public void AddLogMehtod(Action<string> method)
        {
            logMethod += method;
        }

        public void Log(string message)
        {
            logMethod?.Invoke(DateTime.Now.ToString() + ": " + message); // An object containing the return value of the invoked method, or null in the case of a constructor.
        }
    }
}
