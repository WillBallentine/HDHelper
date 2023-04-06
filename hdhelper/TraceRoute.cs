using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class TraceRoute
    {
        public void TraceRouteMethod()
        {
            Console.WriteLine("What IP would you like to trace to?");
            string ip = Console.ReadLine();

            
            string strCmdText;
            strCmdText = "/k tracert {ip}";
            Process.Start(strCmdText);
        }
    }
}
