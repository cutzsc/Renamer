using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Renamer
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"D:\TEST\Animations";
			Finder finder = new Finder();
			List<string> files = new List<string>();

			//finder.PrintAllFiles(path);
			//finder.GetAllFiles(path, files);
			//finder.PrintAllDirs(path, false, " ");

			Console.WriteLine("\n===============================================================================================\n");

			finder.GetAllFiles(path, files);


			Regex reg = new Regex("^peace.*anim$", RegexOptions.IgnoreCase);
			foreach (string file in files)
			{
				FileInfo fi = new FileInfo(file);
				if (reg.IsMatch(fi.Name))
				{
					Console.WriteLine(fi.Name);
					Console.WriteLine(fi.DirectoryName);
					fi.MoveTo(fi.DirectoryName + "\\_" + fi.Name);
				}
					
			}

			Console.ReadLine();
		}
	}
}
