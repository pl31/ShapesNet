using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Pl31.ShapesNet.Homogeneous2D.Entities
{
	public class Point2D
	{
		public Point2D ()
		{
			Raw = new DenseVector (3);
		}

		public static Point2D FromPoint(IList<double> point)
		{
			if (point == null)
				throw new ArgumentNullException ("Parameter point must not be null");
			if (point.Count != 2)
				throw new ArgumentException ("Parameter point must have size 2");

			Point2D newPoint = new Point2D ();
			newPoint.Raw [0] = point [0];
			newPoint.Raw [1] = point [1];
			newPoint.Raw [2] = 1;
			return newPoint;
		}

		public IList<double> ToPoint()
		{
			return Raw.SubVector (0, 2) / Raw [2];
		}

		public DenseVector Raw { private set; get; }
	}
}

