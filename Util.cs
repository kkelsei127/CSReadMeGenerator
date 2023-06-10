//import correct packages

using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
//might not need this
using SkiaSharp;

namespace ReadMeGeneratorCS
{
    class Util
    {
        public static void PrintReadMe(List<Prompt> prompts)
        {
            for (int i = 0; i < prompts.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, prompts[i].GetAppName()));
            }
        }

        public static void MakeReadMe(List<Prompt> prompts){
            if (!Directory.Exists("readmedata"))
            {
                //if no directory exists, create it
                Directory.CreateDirectory("readmedata");
            }
            using (StreamWriter file = new StreamWriter("readmedata/readme.md")){
                file.WriteLine("AppName");
                
                for (int i=0; i < prompts.Count; i++)
                {
                    string template = "{0}";
                    file.WriteLine(String.Format(template, prompts[i].GetAppName()))
                }
            }
        }

        
    }
}

