using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopClasses
{
	internal class Circle : Shape
	{
		public double Radius;
		private int Pi = 3;

		public Circle(string color,double radius) : base(color)
		{
			this.Radius = radius;
			Area = Pi * Radius * Radius;
		}

	}
}
