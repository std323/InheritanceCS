using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Teacher:Human
	{
		public string Speciality { get; set; }
		public int Experience { get; set; }

		public Teacher
			(
			string lastName, string firstName, int age,
			string speciality, 
			int experience
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Experience = experience;
		}

		public override string ToString()
		{
			return base.ToString() + $" {Speciality} { Experience} лет.";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Speciality:\t" + Speciality);
			Console.WriteLine("Experience:\t" + Experience);
		}
	}
}
