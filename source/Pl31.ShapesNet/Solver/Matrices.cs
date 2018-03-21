using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Pl31.ShapesNet.Solver
{
    public static class Matrices
    {

        public static Matrix<double> S(Vector<double> x)
        {
            double[,] _S = {
                {     0, -x[2],  x[1]},
                {  x[2],     0, -x[0]},
                { -x[1],  x[0],     0},
            };
            return Matrix<double>.Build.DenseOfArray(_S);
        }
    }
}
