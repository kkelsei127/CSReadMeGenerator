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
                string license = Console.ReadLine() ?? "";

                Console.WriteLine("What is the purpose of this application? Give a detailed description.");
                string description = Console.ReadLine() ?? "";

                Console.WriteLine("How do you install this application? List any additional tools needed.");
                string installation = Console.ReadLine() ?? "";

                Console.WriteLine("What are the intended uses for this application?");
                string usages = Console.ReadLine() ?? "";

                Console.WriteLine("Who are the contributors to this application?");
                string contributors = Console.ReadLine() ?? "";
                
                Console.WriteLine("How do you test this application?");
                string testing = Console.ReadLine() ?? "";

                Console.WriteLine("What is your Github username?");
                string github = Console.ReadLine() ?? "";

                Console.WriteLine("Do you have any other contact info to add?");
                string contactInfo = Console.ReadLine() ?? "";

                Prompt currentPrompt = new Prompt(applicationName, license, description, installation, usages, contributors, testing, github, contactInfo);
                prompts.Add(currentPrompt);
            }
            return prompts;
        }


        async static Task Main(string[] args)

        {
            List<Prompt> prompts = GetPrompts();
            Util.PrintReadMe(prompts);
            Util.MakeCSV(prompts);
            //not sure how to make a md file, currently will have it made into a csv?
            await Util.MakeReadMe(prompts);
        }
    }
}

