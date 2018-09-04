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
			var cmdOptions = new CommandLineOptions();
			string versionNumber = cmdOptions.Version ?? "3.17.1.0";
			
			Console.WriteLine("This Program lists and updates AssemblyInfo.cs files in RRPS");
			DirectoryInfo dir = new DirectoryInfo(cmdOptions.OptionsFilePath) ?? new DirectoryInfo(@"C:\Users\justin.stonecipher\OneDrive - Centeva\Downloads\rpssource\");
			try
			{
				foreach (DirectoryInfo directory in dir.GetDirectories())
				{
					switch (directory.Name)
					{
						case "ol":
							UpdateOltsAssemblyInfo(versionNumber, directory);
							break;
						case "licensing":
							UpdateLicensingAssemblyInfo(versionNumber, directory);
							break;
						case "inspections":
							UpdateInspectionsAssemblyInfo(versionNumber, directory);
							break;
						case "istar":
							UpdateIstarAssemblyInfo(versionNumber, directory);
							break;
						case "oversight":
							UpdateOversightAssemblyInfo(versionNumber, directory);
							break;
						case "ROP":
							UpdateRopAssemblyInfo(versionNumber, directory);
							break;
						case "dataman":
							UpdateDatamanAssemblyInfo(versionNumber, directory);
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

		private static void UpdateOltsAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("OLTS.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("OLTS AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("OLTS.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!");
			}
		}

		private static void UpdateLicensingAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("Licensing.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("Licensing AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("Licensing.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!");
			}
		}

		private static void UpdateInspectionsAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("Inspections.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("Inspections AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("Inspections.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!");
			}
		}

		private static void UpdateIstarAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("Inspections.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("iSTAR AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("Inspections.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!");
			}
		}

		private static void UpdateOversightAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("Oversight.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("Oversight AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("Oversight.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!");
			}
		}

		private static void UpdateRopAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("ROP.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("ROP AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("ROP.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!");
			}
		}

		private static void UpdateDatamanAssemblyInfo(string versionNumber, DirectoryInfo directory)
		{
			var files = directory.GetFiles("RPS.DataMan.BLL\\Properties\\AssemblyInfo.cs");
			if (files.Length == 0)
			{
				throw new Exception("RPS.DataMan AssemblyInfo.cs file does not exist");
			}
			foreach (FileInfo file in directory.GetFiles("RPS.DataMan.BLL\\Properties\\AssemblyInfo.cs"))
			{
				File.WriteAllText(file.FullName, File.ReadAllText(file.FullName).Replace("1.0.0.0", versionNumber));
				Console.WriteLine("{0}", directory.Name + " " + file.Name + " Success!" + " Success!");
			}
		}
	}

	public class CommandLineOptions {
		[Option('f', "optionsFilePath", HelpText = "Specify the RPS folder path.", Required = false)]
		public string OptionsFilePath { get; set; }

		[Option('v', "version", HelpText = "Specify the versionNumber.", Required = false)]
		public string Version { get; set; }
	}
}