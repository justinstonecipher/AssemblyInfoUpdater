using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyInfoUpdater
{
    class CommandLineOptions
    {
       [Option('f', "optionsFilePath", HelpText = "Specify the RPS folder path.", Required = true)]
       public string OptionsFilePath { get; set; }

       [Option('v', "version", HelpText = "Specify the versionNumber.", Required = true)]
       public string Version { get; set; }
    }
}
