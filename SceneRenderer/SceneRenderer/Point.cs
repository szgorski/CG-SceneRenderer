using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneRenderer
{
    public partial class SceneRenderer
    {
        public class LPoint                 // Local Point
        {
            public Vector<double> point;
            public Vector<double> normal;   // not used in this solution

            public LPoint(Vector<double> p, Vector<double> n)
            {
                point = p;
                normal = n;
            }
        }
    }
}
