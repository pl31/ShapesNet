using System;
using Xunit;
using MathNet.Numerics.LinearAlgebra.Double;
using Pl31.ShapesNet.Homogeneous2D.Entities;

namespace Tests
{
    public class Test_Point2D
    {
        [Fact]
        public void Test_FromPoint01()
        {
            Point2D.FromPoint(new double[] { 0, 1 });
        }

        [Fact]
        public void Test_FromPoint02()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Point2D.FromPoint(null);
            });
        }

        [Fact]
        public void Test_FromPoint03()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Point2D.FromPoint(new double[] { 0 });
            });
        }

        [Fact]
        public void Test_FromPoint04()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Point2D.FromPoint(new double[] { 0, 1, 2 });
            });
        }

        [Fact]
        public void Test_ToPoint01()
        {
            var originalPoint = new DenseVector(new double[] { 0, 1 });
            var convertedPoint = (DenseVector)(Point2D.FromPoint(originalPoint).ToPoint());

            Assert.StrictEqual((originalPoint - convertedPoint).L2Norm(), 0);
        }

        [Fact(Skip = "Feature not implemented yet")]
        public void Test_ToPoint02()
        {
            // Test using line-line
            //throw new NotImplementedException();
        }
    }
}

