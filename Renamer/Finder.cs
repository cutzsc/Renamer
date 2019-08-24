using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renamer
{
	class Finder
	{
		public void PrintAllDirs(string path, bool allPath = false, string divChar = "\t", string divStr = "")
		{
			Console.WriteLine(divStr + (allPath ?
					path :
					path.Substring(path.LastIndexOf("\\"))
					));

			string[] dirs = Directory.GetDirectories(path);
			foreach (string dir in dirs)
				PrintAllDirs(dir, allPath, divChar, divStr + divChar);
		}

		public void PrintAllFiles(string path, bool allPath = false, string divChar = "\t", string divStr = "")
		{
			string[] files = Directory.GetFiles(path);
			foreach (string file in files)
				Console.WriteLine(divStr + (allPath ?
					file :
					file.Replace(path + "\\", "")));

			string[] dirs = Directory.GetDirectories(path);
			foreach (string dir in dirs)
				PrintAllFiles(dir, allPath, divChar, divStr + divChar);
		}

		public void GetAllFiles(string path, List<string> fs)
		{
			string[] files = Directory.GetFiles(path);
			foreach (string file in files) fs.Add(file);

			string[] dirs = Directory.GetDirectories(path);
			foreach (string dir in dirs)
				GetAllFiles(dir, fs);
		}

		public void Rename(List<string> fs)
		{

		}

		public void Rename(string file)
		{

		}
	}
}
