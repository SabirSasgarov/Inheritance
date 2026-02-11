using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
	internal class Rectangle : Shape
	{
		public double Length;

		public Rectangle(string color, double length) : base(color)
		{
			this.Length = length;
			Area = Length * Length;
		}
	}
}
