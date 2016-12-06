using System.Collections.Generic;

namespace AreaCounting
{
	public class Circle : ICountable
	{
		private double _radius;

		public Circle(double radius)
		{
			this._radius = radius;
		}

		public double CountArea()
		{
			return System.Math.PI * _radius * _radius;
		}
    }
}
