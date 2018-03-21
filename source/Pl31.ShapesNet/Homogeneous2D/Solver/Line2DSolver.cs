using System;
using MathNet.Numerics.LinearAlgebra;
using Pl31.ShapesNet.Solver;
using Pl31.ShapesNet.Homogeneous2D.Entities;

namespace Pl31.ShapesNet.Homogeneous2D.Solver
{
    public class Line2DSolver : BaseSolver
    {
        public Line2DSolver() : base(3)
        {
        }

        public Line2DSolver Join(Point2D point)
        {
            var A = Matrices.S(point.Raw);
            solver += A.Transpose() * A;
            return this;
        }

    }
}
