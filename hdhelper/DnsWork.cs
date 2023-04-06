using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class DnsWork
    {
        public void DnsFlush()
        {
            string strCmdText;
            strCmdText = "/k ipconfig /flushdns";
            Process.Start("CMD.exe", strCmdText);
        }

        public void DnsDisplay()
        {
            string strCmdText;
            strCmdText = "/k ipconfig /displaydns";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
