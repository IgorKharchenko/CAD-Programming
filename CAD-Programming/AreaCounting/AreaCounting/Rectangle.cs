using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCounting
{
	public class Rectangle : ICountable
	{
		private double _width;
		private double _height;

		public Rectangle(double width, double height)
		{
			this._width = width;
			this._height = height;
		}

		public double CountArea()
		{
			return _width * _height;
		}
	}
}
