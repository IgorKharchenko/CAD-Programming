using System;
using System.Collections.Generic;

namespace AreaCounting
{
	public class Triangle : ICountable
	{
		private double _base;
		private double _height;
		
		public Triangle(double triangleBase, double triangleHeight)
		{
			this._base = triangleBase;
			this._height = triangleHeight;
		}

		public double CountArea()
		{
			return (1.0 / 2.0) * _base * _height;
		}
	}
}
