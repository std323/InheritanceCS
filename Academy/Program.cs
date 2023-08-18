using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Academy
{
	internal class Program
	{
		const string delimiter = "\n-------------------------------------\n";

		static void Main(string[] args)
		{
			#region INHERITANCE
			/*Human human = new Human("Montana", "Antonio", 25);
				Console.WriteLine(human);

				Student pinkman = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW-220", 80, 95);
				Console.WriteLine(pinkman);

				Teacher whaite = new Teacher("White", "Walter", 50, "Chemistry", 20);
				Console.WriteLine(whaite);

				Graduate hank = new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg");
				Console.WriteLine(hank);*/


			#endregion INHERITANCE

			Student tommi = new Student("Varcetti", "Tomas", 30, "Theft", "Vice", 98, 99);
			Teacher diaz = new Teacher("Diaz", "Ricardo", 50, "Weapons sitribution", 20);

			Human[] group = new Human[]
			{
				new Student("Pinkman", "Jessie", 25, "Chemistry", "WW-220", 80, 95),
				new Teacher("White", "Walter", 50, "Chemistry", 20),
				new Graduate("Schrader", "Hank", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg"),
			    tommi, diaz
			};
			string currentDirectory = Directory.GetCurrentDirectory();
			string filename = "group.txt";
			StreamWriter streamWriter = new StreamWriter(filename);
			for (int i=0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]); 
				streamWriter.WriteLine(group[i]);
				//group[i].Print();
				Console.WriteLine(delimiter);

				//Console.WriteLine(group[i]);

			}
			streamWriter.Close();
			string cmd = currentDirectory + "\\" + filename;
			System.Diagnostics.Process.Start("notepad", cmd);
		}
	}
}
