using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class Slow
    {
        public void SlowMethod()
        {
            string strCmdText;
            strCmdText = "/k dism /online /cleanup-image /restorehealth && sfc /scannow";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
