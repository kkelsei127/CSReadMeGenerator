// See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReadMeGeneratorCS
{
    class Program
    {
        static List<Prompt> GetPrompts(){
            List<Prompt> prompts = new List<Prompt>();
            while (true) {
                Console.WriteLine("What is the name of the application? (Press enter to exit): ");

                string applicationName = Console.ReadLine() ?? "";
                    // ?? coalescing operator - if null return empty string

                if (applicationName == "") {break;}
                // exit from app if no name entered

                Console.WriteLine("What license did the application use?");

            }
        }
    }
}

