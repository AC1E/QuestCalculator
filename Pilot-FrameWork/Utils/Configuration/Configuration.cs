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
using NLog;
using Pilot_FrameWork.Utils.Loggers;

namespace Pilot_FrameWork.Utils.Configuration
{ 
         public class Configuration
           {
            private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();
            private static string[] configFileLines;
            public static string Path(string appName)
            {
            try
            {
                var currentPath = Directory.GetCurrentDirectory();
                Console.WriteLine(currentPath);
                var absoultePath = $"{currentPath}/../../../../Pilot-FrameWork/Utils/Configuration/Config.txt";
                configFileLines = File.ReadAllLines(absoultePath);
                return GetPath(appName);
            }
            catch (Exception ex)
            {
                Nlogger.Log("Error", $"Error reading configuration file:");
                 return null;
                
            }
        }
            private static string GetPath(string appName)
            {
                try
                {
                    foreach (var line in configFileLines)
                    {
                        if (line.Contains($"{appName} Path:"))
                        {
                            return line.Replace($"{appName} Path: ", "");
                        }
                    }
                   Nlogger.Log("Warn" ,$"Path for {appName} not found in the configuration file.");
                    return null;
                }
                catch (Exception ex)
                {
                    Nlogger.Log("Error",$"Error getting path for {appName}:");
                    return null;
                }
            
            }
            public static string GetWindowName(string appName)
            {
                try
                {
                    foreach (var line in configFileLines)
                    {
                        if (line.Contains($"{appName} WindowName:"))
                        {
                            return line.Replace($"{appName} WindowName: ", "");
                        }
                    }
                    Nlogger.Log("Error",$"WindowName for {appName} not found in the configuration file.");
                    return null;
                }
                catch (Exception ex)
                {
                    Nlogger.Log("Error",$"Error getting window name for {appName}");
                    return null;
                }
            }
        }
    }

    


