﻿using MathNet.Numerics.LinearAlgebra.Double;

namespace Transformations2D.Transformations
{
	public class YReflectionTransformation2D : ITransformation2D
	{
		public string Description { get; private set; }
		public DenseMatrix Matrix { get; private set; }

		public YReflectionTransformation2D(string name)
		{
			Description = name;
			Matrix = Transform2DService.MakeYReflectionMatrix();
		}
	}
}
