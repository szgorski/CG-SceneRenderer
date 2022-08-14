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
        public class Triangle
        {
            public Point edge1;
            public Point edge2;
            public Point edge3;

            public Triangle(Point e1, Point e2, Point e3)
            {
                edge1 = e1;
                edge2 = e2;
                edge3 = e3;
            }
        }

        public void AddTriangle(Triangle t)
        {
            if (!Variables.lines.Contains((t.edge1, t.edge2)) &&
                !Variables.lines.Contains((t.edge2, t.edge1)))
                Variables.lines.Add((t.edge1, t.edge2));
            if (!Variables.lines.Contains((t.edge2, t.edge3)) &&
                !Variables.lines.Contains((t.edge3, t.edge2)))
                Variables.lines.Add((t.edge2, t.edge3));
            if (!Variables.lines.Contains((t.edge3, t.edge1)) &&
                !Variables.lines.Contains((t.edge1, t.edge3)))
                Variables.lines.Add((t.edge3, t.edge1));
        }
    }
}
