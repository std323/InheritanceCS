using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle(Console.WindowLeft, Console.WindowTop, Console.WindowWidth, Console.WindowHeight);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);
			Rectangle rect = new Rectangle(200, 70, 150, 150, 5, Color.AliceBlue);
			Console.WriteLine($"Cторона 'А': {rect.SideA}");
			Console.WriteLine($"Cторона 'B': {rect.SideB}");
			Console.WriteLine($"Площадь прямоуголика: {rect.GetArea()}");
			Console.WriteLine($"Периметр прямоуголика: {rect.GetPerimeter()}");
			rect.Draw(e);
			Square square = new Square(100, 500, 150, 5, Color.Blue);
			Console.WriteLine($"Стороны квадрата: {square.SideA}");
			Console.WriteLine($"Площадь квадрата: {square.GetArea()}");
			Console.WriteLine($"Периметр квадрата: {square.GetPerimeter()}");
			square.Draw(e);
			Circle circle = new Circle(70, 130, 280, 5, Color.Coral);
			Console.WriteLine($"Радиус окружности: {circle.Radius}");
			Console.WriteLine($"Площадь круга: {circle.GetArea()}");
			Console.WriteLine($"Периметр круга: {circle.GetPerimeter()}");
			circle.Draw(e);

		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hwnd);
	}
}
