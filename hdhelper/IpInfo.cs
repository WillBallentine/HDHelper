using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class IpInfo
    {
        public void IpInfoMethod()
        {
            string strCmdText;
            strCmdText = "/k ipconfig /all";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
