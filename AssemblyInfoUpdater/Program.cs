using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace AssemblyInfoUpdater
{
	public class Program
	{
		static void Main(string[] args)
		{
            string versionNumber = "";
            DirectoryInfo dir = new DirectoryInfo("C:\\");

            Parser.Default.ParseArguments<CommandLineOptions>(args).WithParsed(c =>
            {
                versionNumber = c.Version ?? throw new Exception("please include a version number '-v version number'");
                dir = new DirectoryInfo(c.OptionsFilePath) ?? throw new Exception("please include main repo folder '-f c:\\user\\first.last\\documents\\repo"); ;
            });

            Console.WriteLine(versionNumber + " " + dir);
			Console.WriteLine("This Program lists and updates AssemblyInfo.cs files in RRPS");
			
			try
			{
				foreach (DirectoryInfo directory in dir.GetDirectories())
				{
					switch (directory.Name)
					{
						case "ol":
							FileInfoUpdates.UpdateOltsAssemblyInfo(versionNumber, directory);
							break;
						case "licensing":
                            FileInfoUpdates.UpdateLicensingAssemblyInfo(versionNumber, directory);
							break;
						case "inspections":
                            FileInfoUpdates.UpdateInspectionsAssemblyInfo(versionNumber, directory);
							break;
						case "istar":
                            FileInfoUpdates.UpdateIstarAssemblyInfo(versionNumber, directory);
							break;
						case "oversight":
                            FileInfoUpdates.UpdateOversightAssemblyInfo(versionNumber, directory);
							break;
						case "ROP":
                            FileInfoUpdates.UpdateRopAssemblyInfo(versionNumber, directory);
							break;
						case "dataman":
                            FileInfoUpdates.UpdateDatamanAssemblyInfo(versionNumber, directory);
							break;
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				Console.ReadLine();
			}
		}
	}
}