using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal abstract class Triangle : Shape 
	{
		public static double height;
		

		public double Height
		{
			get { return height; }
			set
			{ 
				if (value < 20) value = 20;
				if (value > 200) value = 200;
				height = value; 
			}
		}

		public Triangle
			(
			int start_x, int start_y, int line_width, Color color)
			:base(start_x, start_y, line_width, color)
		{
			Height = height;
		}
		





	}


}
