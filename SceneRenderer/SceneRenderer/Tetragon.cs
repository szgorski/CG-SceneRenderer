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
        public class Tetragon
        {
            public Point edge1;
            public Point edge2;
            public Point edge3;
            public Point edge4;

            public Tetragon(Point e1, Point e2, Point e3, Point e4)
            {
                edge1 = e1;
                edge2 = e2;
                edge3 = e3;
                edge4 = e4;
            }
        }

        public (Triangle, Triangle) BreakTetragon(Tetragon tetragon)
        {
            Triangle t1 = new Triangle(tetragon.edge1, tetragon.edge2, tetragon.edge3);
            Triangle t2 = new Triangle(tetragon.edge1, tetragon.edge3, tetragon.edge4);
            return (t1, t2);
        }
    }
}
