using System;
using Pl31.ShapesNet.Homogeneous2D.Entities;
using Pl31.ShapesNet.Homogeneous2D.Solver;
using Xunit;

namespace tests.Homogeneous2D.Solver
{
    public class Test_Line2DSolver
    {
        [Fact]
        public void Test_Line2DSolver_Fit01()
        {
            var solver = new Line2DSolver();

            var line = solver
                .Join(Point2D.FromPoint(1,0))
                .Join(Point2D.FromPoint(2,1))
                .Fit<Line2D>();

            // TODO: test line values

        }
    }
}
