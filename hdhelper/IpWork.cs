using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class IpWork
    {
        public static void IpWorkMethod()
        {
            string strCmdText;
            strCmdText = "/k ipconfig /release";
            Process.Start("CMD.exe", strCmdText);

            Thread.Sleep(2000);

            strCmdText = "/k ipconfig /renew";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
