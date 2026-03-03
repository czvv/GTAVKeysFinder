// Copyright © Neodymium, carmineos and contributors. See LICENSE.md in the repository root for more information.

using RageLib.GTA5.Cryptography;
using System.IO;

namespace GTAVKeysFinder
{
    //
    // Example command for running the tool:
    // GTAVKeysFinder.exe -executableFile "C:\Path\To\Your\GTA5_dump.exe" -keyPath "C:\Path\To\OutputFolder"
    //
    public class Program
    {
        private readonly string[] arguments;

        public Program(string[] arguments)
        {
            this.arguments = arguments;
        }

        public void Run()
        {
            string executableFile = GetArgument("-executableFile");
            string keyPath = GetArgument("-keyPath");
            ExtractKeysIntoDirectory(executableFile, keyPath);
        }

        private string GetArgument(string argumentName)
        {
            for (int i = 0; i < arguments.Length; i++)
            {
                if (arguments[i].Equals(argumentName))
                {
                    return arguments[i + 1];
                }
            }
            return null;
        }

        private void ExtractKeysIntoDirectory(string executableFile, string keyPath)
        {
            GTA5Constants.Generate(File.ReadAllBytes(executableFile));
            GTA5Constants.SaveToPath(keyPath);
        }

        static void Main(string[] args)
        {
            new Program(args).Run();
        }
    }
}
