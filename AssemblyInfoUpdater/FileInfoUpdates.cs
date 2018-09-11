using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyInfoUpdater
{
    public class FileInfoUpdates
    {
        public static void UpdateOltsAssemblyInfo(string versionNumber, DirectoryInfo directory)
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

        public static void UpdateLicensingAssemblyInfo(string versionNumber, DirectoryInfo directory)
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

        public static void UpdateInspectionsAssemblyInfo(string versionNumber, DirectoryInfo directory)
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

        public static void UpdateIstarAssemblyInfo(string versionNumber, DirectoryInfo directory)
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

        public static void UpdateOversightAssemblyInfo(string versionNumber, DirectoryInfo directory)
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

        public static void UpdateRopAssemblyInfo(string versionNumber, DirectoryInfo directory)
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

        public static void UpdateDatamanAssemblyInfo(string versionNumber, DirectoryInfo directory)
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
}
