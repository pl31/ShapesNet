using System;
using System.Collections.Generic;
using MathNet.Numerics.LinearAlgebra;
using Pl31.ShapesNet.Entities;

namespace Pl31.ShapesNet.Homogeneous2D.Entities
{
    public class Line2D : Entity
    {
        public Line2D() : base(3) { }

        public override Vector<double> Normalize()
        {
            return Raw / Raw.SubVector(0, 2).L2Norm();
        }

        public Vector<double> NormalVector
        {
            get
            {
                return Normalize().SubVector(0, 2);
            }
        }

        public double DistanceFromOrigin
        {
            get
            {
                return Raw[2] / Raw.SubVector(0, 2).L2Norm();
            }

        }

        public override string ToString()
        {
            return string.Format("[Line2D: NormalVector={0}, DistanceFromOrigin={1}]", NormalVector, DistanceFromOrigin);
        }
    }
}

