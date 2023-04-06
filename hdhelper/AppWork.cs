using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class AppWork
    {
        public void UninstallAdobe()
        {
            string strCmdText;
            strCmdText = "/k wmic product where name=\"Adobe Acrobat Reader DC\" call uninstall";
            Process.Start("CMD.exe", strCmdText);
        }

        public void Repair365_64()
        {
            string strCmdText;
            strCmdText = "/k \"C:\\\\Program Files\\\\Microsoft Office 15\\\\ClientX64\\\\OfficeClicktoRun.exe\" scenario=repair platform=x86 culture=en-us DisplayLevel=True";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
