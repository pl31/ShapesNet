using System;
using MathNet.Numerics.LinearAlgebra;
using Pl31.ShapesNet.Entities;

namespace Pl31.ShapesNet.Solver
{
    public abstract class BaseSolver
    {
        public BaseSolver(int size)
        {
            solver = Matrix<double>.Build.Dense(size, size, 0);
        }

        public Entity Fit<T>() where T: Entity, new()
        {

            var evd = solver.Evd(Symmetricity.Symmetric);
            var entity = new T();
            entity.Raw = evd.EigenVectors.Column(entity.RawSize - 1);
            Console.WriteLine(evd.EigenValues);
            Console.WriteLine(evd.EigenVectors);
            Console.WriteLine(entity);
            return entity;
        }

        protected Matrix<double> solver;
    }
}
