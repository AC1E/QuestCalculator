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
            string configFilePath = "C:\\Users\\consani\\source\\repos\\QuestCalculator1\\Pilot-FrameWork\\Utils\\Configuration\\config.txt";
            configFileLines = File.ReadAllLines(configFilePath); 
            var app1Path = GetPath(appname); 
            var app1WindowName = GetWindowName(appname); 
            return app1Path;   
        }
        static string GetPath(string appName)
        {
            
            foreach (var line in configFileLines)
            {
                 if (line.Contains($"{appName} Path:"))
                 {
                        return line.Replace($"{appName} Path: ", "");
                 }
            }
                return null; 
        }
        public static string GetWindowName(string appName)
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
    


