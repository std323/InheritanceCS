using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Specialist:Graduate
	{
		public int Grade { get; set; }
		public Specialist
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string subject,
			int grade
			) : base(lastName, firstName, age, speciality, group, rating, attendance, subject)
		{
			Grade = grade;
		}
		public override string ToString()
		{
			return base.ToString() + $", {Grade}";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Exit grade:\t" + Grade);
		}
	}
}
