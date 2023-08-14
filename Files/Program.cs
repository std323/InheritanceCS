using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace Files
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string currentDerectory = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(currentDerectory);
			
			StreamWriter sw = new StreamWriter("File.txt");
			sw.Write("Hello");
			sw.Close();
			Console.WriteLine(currentDerectory);
			Console.WriteLine(filename);
			string cmd = currentDerectory + "\\" + filename;
			Console.WriteLine(cmd);
			System.Diagnostics.Process.Start("notepad", cmd);
		}
	}
}
