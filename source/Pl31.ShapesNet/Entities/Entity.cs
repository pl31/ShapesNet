using System;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace Pl31.ShapesNet.Entities
{
    public abstract class Entity
    {
        protected Entity(int size)
        {
            Raw = Vector<double>.Build.Dense(size, 0);
            RawSize = size;
        }

        public Vector<double> Raw { internal set; get; }
        internal int RawSize { get; private set; }

        public abstract Vector<double> Normalize();

        public override string ToString()
        {
            return string.Format("[Entity: Raw={0}]", Raw);
        }
    }
}
