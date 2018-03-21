using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;
using Pl31.ShapesNet.Entities;

namespace Pl31.ShapesNet.Homogeneous2D.Entities
{
    public class Point2D : Entity
    {
        public Point2D() : base(3) {}

        public static Point2D FromPoint(double x, double y)
        {
            Point2D newPoint = new Point2D();
            newPoint.Raw[0] = x;
            newPoint.Raw[1] = y;
            newPoint.Raw[2] = 1;
            return newPoint;
        }

        public static Point2D FromPoint(IList<double> point)
        {
            if (point == null)
                throw new ArgumentNullException("Parameter point must not be null");
            if (point.Count != 2)
                throw new ArgumentException("Parameter point must have size 2");

            return Point2D.FromPoint(point[0], point[1]);
        }

        public override Vector<double> Normalize()
        {
            return Raw / Raw[2];
        }

        public Vector<double> ToPoint()
        {
            return Raw.SubVector(0, 2) / Raw[2];
        }
    }
}

