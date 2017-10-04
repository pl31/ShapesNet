using System;
using NUnit.Framework;
using MathNet.Numerics.LinearAlgebra.Double;
using Pl31.ShapesNet.Homogeneous2D.Entities;

namespace Tests
{
	[TestFixture ()]
	public class Test_Point2D
	{
		[Test ()]
		public void Test_FromPoint01 ()
		{
			Point2D.FromPoint (new double[] { 0, 1 });
		}

		[Test ()]
		[ExpectedException (typeof(ArgumentNullException))]
		public void Test_FromPoint02 ()
		{
			Point2D.FromPoint (null);
		}

		[Test ()]
		[ExpectedException (typeof(ArgumentException))]
		public void Test_FromPoint03 ()
		{
			Point2D.FromPoint (new double[] { 0 });
		}

		[Test ()]
		[ExpectedException (typeof(ArgumentException))]
		public void Test_FromPoint04 ()
		{
			Point2D.FromPoint (new double[] { 0, 1, 2 });
		}

		[Test ()]
		public void Test_ToPoint01 ()
		{
			var originalPoint = new DenseVector (new double[] { 0, 1 });
			var convertedPoint = (DenseVector)(Point2D.FromPoint (originalPoint).ToPoint ());

			Assert.AreEqual((originalPoint - convertedPoint).L2Norm (), 0);
		}

		[Test ()]
		public void Test_ToPoint02 ()
		{
			// Test using line-line
			throw new NotImplementedException ();
		}


	}
}

