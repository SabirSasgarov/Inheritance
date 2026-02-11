using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
	internal class Shape
	{
		public string Color;
		public double Area;

		public Shape(string color)
		{
			this.Color = color;
		}

		public void GetInfo()
		{
			Console.WriteLine($"Color of this shape is {Color},\narea ==> {Area}\n");
		}

	}
}
