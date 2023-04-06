using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HdHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thank you for selecting Help Desk Helper!");
            Console.WriteLine();
            Console.WriteLine("This application helps simplify the initial troubleshooting process for Help Desk type employees.");
            Console.WriteLine();
            Console.WriteLine("If you are an end user, please follow the specific directions of the one who is assisting you.");
            Console.WriteLine();
            Thread.Sleep(2000);
            Start();

        }

        static void Start()
        {
            Console.WriteLine("What issue are you having? Pleae select the number of the item as directed and press Enter");
            Console.WriteLine("1. System Running Slow");
            Console.WriteLine("2. Unexpectedly Full Hard Drive");
            Console.WriteLine("3. Unable to Connect to the Internet");
            Console.WriteLine("4. Uninstall Adobe");
            Console.WriteLine("5. Repair Office");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Slow slow = new Slow();
                slow.SlowMethod();
                Console.WriteLine("Need To Run More? 1. Yes   2. No");
                string userInputRepeat = Console.ReadLine();
                if (userInputRepeat == "1")
                {
                    Start();
                }
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Which would you like to do first: 1. Check Disk Space     2. Delete Temporary Files     3. Dism/SFC?");
                string userInput2 = Console.ReadLine();
                if (userInput2 == "1")
                {
                    CheckDisk checkDisk = new CheckDisk();
                    checkDisk.CheckDiskMethod();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else if (userInput2 == "2")
                {
                    TempDelete tempDelete = new TempDelete();
                    tempDelete.TempDeleteMethod();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else if (userInput2 == "3")
                {
                    Slow slow = new Slow();
                    slow.SlowMethod();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
            }
            else if (userInput == "3")
            {
                Console.WriteLine("What would you like to do first: 1. ipconfig    2. ip release/renew   3. flushdns   4. display dns   5. trace route");
                string userInput3 = Console.ReadLine();

                if (userInput3 == "1")
                {
                    IpInfo ipInfo = new IpInfo();
                    ipInfo.IpInfoMethod();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else if (userInput3 == "2")
                {
                    IpWork ipWork = new IpWork();
                    IpWork.IpWorkMethod();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else if (userInput3 == "3")
                {
                    DnsWork dnsWork = new DnsWork();
                    dnsWork.DnsFlush();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else if (userInput3 == "4")
                {
                    DnsWork dnsWork2 = new DnsWork();
                    dnsWork2.DnsDisplay();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else if (userInput3 == "5")
                {
                    TraceRoute traceRoute = new TraceRoute();
                    traceRoute.TraceRouteMethod();
                    Console.WriteLine("Need To Run More? 1. Yes   2. No");
                    string userInputRepeat = Console.ReadLine();
                    if (userInputRepeat == "1")
                    {
                        Start();
                    }
                }
                else
                {
                    Console.WriteLine("You have entered an invalid selection. Please try again.");
                }
            }
            else if (userInput == "4")
            {
                AppWork adobeWork = new AppWork();
                adobeWork.UninstallAdobe();
                Console.WriteLine("Need To Run More? 1. Yes   2. No");
                string userInputRepeat = Console.ReadLine();
                if (userInputRepeat == "1")
                {
                    Start();
                }
            }
            else if (userInput == "5")
            {
                AppWork repair365 = new AppWork();
                repair365.Repair365_64();
                Console.WriteLine("Need To Run More? 1. Yes   2. No");
                string userInputRepeat = Console.ReadLine();
                if (userInputRepeat == "1")
                {
                    Start();
                }
            }
            else
            {
                Console.WriteLine("You have entered an invalid selection. Please try again.");
            }

        }
    }
}

