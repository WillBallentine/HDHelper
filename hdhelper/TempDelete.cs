using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class TempDelete
    {
        public void TempDeleteMethod()
        {
            string strCmdText;
            strCmdText = "/k del /f /s /q %temp%\\*.*";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
