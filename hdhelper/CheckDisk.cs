using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdHelper
{
    internal class CheckDisk
    {
        public void CheckDiskMethod()
        {
            string strCmdText;
            strCmdText = "/k wmic logicaldisk get name,size,freespace,caption";
            Process.Start("CMD.exe", strCmdText);
        }
    }
}
