//#define WRITE_TO_FILE
#define READ_FROM_FILE
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
#if WRITE_TO_FILE
			string currentDerectory = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(currentDerectory);

			StreamWriter sw = new StreamWriter(filename, true);
			sw.WriteLine("Hello");
			sw.Close();
			Console.WriteLine(currentDerectory);
			Console.WriteLine(filename);
			string cmd = currentDerectory + "\\" + filename;
			Console.WriteLine(cmd);
			System.Diagnostics.Process.Start("notepad", cmd); 
			sw.Close();
#endif
#if READ_FROM_FILE
			string currentDerectory = Directory.GetCurrentDirectory();
			string filename = "File.txt";
			Console.WriteLine(currentDerectory);
			StreamReader sr = new StreamReader(filename);
			for (int i=1; !sr.EndOfStream; i++)
			{
				string buffer = sr.ReadLine();
				Console.WriteLine(i + " " + buffer);
			} 
			sr.Close();
#endif
		}
	}
}
