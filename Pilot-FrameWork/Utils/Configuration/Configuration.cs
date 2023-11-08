using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;
using NUnit.Framework;
using Gherkin.CucumberMessages.Types;


namespace Pilot_FrameWork.Utils.Configuration
{ 
    public class Configuration
    {
        static string[] configFileLines;
        public static string path(string appname)
        {
            string configFilePath = "C:\\Users\\consani\\source\\repos\\Pilot-FrameWork\\Pilot-FrameWork\\Utils\\Configuration\\config.txt";
            configFileLines = File.ReadAllLines(configFilePath); 
            var app1Path = GetPath(appname); 
            var app1WindowName = GetWindowName(appname); 
            Console.WriteLine($"Application 1 Path: {app1Path}");
            Console.WriteLine($"Application 1 Window Name: {app1WindowName}");
            return app1Path;   
        }
        static string GetPath(string appName)
        {
            Console.WriteLine($" abcd {appName}");
            foreach (var line in configFileLines)
            {
                 if (line.Contains($"{appName} Path:"))
                 {
                        return line.Replace($"{appName} Path: ", "");
                 }
            }
                return null; 
        }
        static string GetWindowName(string appName)
        {
              foreach (var line in configFileLines)
              {
                    if (line.Contains($"{appName} WindowName:"))
                    {
                        return line.Replace($"{appName} WindowName: ", "");
                    }
              }
                return null; 
        }
    }
}
    


