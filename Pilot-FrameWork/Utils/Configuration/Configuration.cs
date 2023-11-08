using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using System.Configuration;
using Newtonsoft.Json;
using System.IO;

namespace Pilot_FrameWork.Utils.Configuration
{
    
    public class Configuration
    {
        public static string path()
        {
            string path = File.ReadAllText("Apppath.txt");
            Console.WriteLine(path);
            return path;
        }
    }
    }

