using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{

		string LastName { get; set; }
		string FirstName { get; set; }
		int Age { get; set; }
		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
		}

		public override string ToString()
		{
			return $"{LastName}	{FirstName} {Age} лeт.	";

		}
		public virtual void Print()
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine("Last name:\t" + LastName);
			Console.WriteLine("First name:\t" + FirstName);
			Console.WriteLine("Age\t\t" + Age);
		}
	}
}
