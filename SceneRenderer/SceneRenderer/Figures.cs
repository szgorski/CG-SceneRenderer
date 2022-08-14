using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SceneRenderer
{
    public partial class SceneRenderer
    {
        public enum FigureType
        {
            Cuboid,
            Sphere,
            Cylinder,
            Cone
        }

        public class Figure
        {
            public FigureType type { get; set; }

            public decimal width { get; set; }
            public decimal height { get; set; }
            public decimal depth { get; set; }
            public decimal radius { get; set; }

            public int subdivisions { get; set; }
            public double[,] figureMatrix { get; set; }

            [JsonIgnore]
            public Matrix<double> affineMatrix;

            public Figure(FigureType t, decimal w, decimal h, decimal d,
                          decimal r, int s, Matrix<double> a)
            {
                type = t;
                width = w;
                height = h;
                depth = d;
                radius = r;
                subdivisions = s;
                affineMatrix = a;
                figureMatrix = a.ToArray();
                Console.Error.WriteLine(a);
            }

            [JsonConstructor]
            public Figure(FigureType t, decimal w, decimal h, decimal d,
              decimal r, int s, double[,] m)
            {
                type = t;
                width = w;
                height = h;
                depth = d;
                radius = r;
                subdivisions = s;
                figureMatrix = m;
            }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }

        public void AddFigure(FigureType type)
        {
            double[,] init = new double[,]
            {
                 { 1, 0, 0, 0 },
                 { 0, 1, 0, 0 },
                 { 0, 0, 1, 0 },
                 { 0, 0, 0, 1 }
            };
            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(init);

            int n;
            decimal w, h, d, r;
            if (type == FigureType.Cuboid) w = numericUpDownWidth.Value;
            else w = 0;
            if (type == FigureType.Sphere) h = 0;
            else h = numericUpDownHeight.Value;
            if (type == FigureType.Cuboid) d = numericUpDownDepth.Value;
            else d = 0;
            if (type == FigureType.Cuboid) r = 0;
            else r = numericUpDownRadius.Value;
            if (type == FigureType.Cuboid) n = 0;
            else n = (int)numericUpDownDensity.Value;

            matrix = RotateX(matrix, Math.PI);
            matrix = RotateY(matrix, Math.PI / 2);

            matrix = RotateX(matrix, Math.PI * ((double)numericUpDownRotationX.Value) / 180);
            matrix = RotateY(matrix, Math.PI * ((double)numericUpDownRotationY.Value) / 180);
            matrix = RotateZ(matrix, Math.PI * (double)numericUpDownRotationZ.Value / 180);
            matrix = Translate(matrix, (double)-numericUpDownPositionX.Value,
                (double)-numericUpDownPositionY.Value, (double)-numericUpDownPositionZ.Value);

            Figure f = new Figure(type, w, h, d, r, n, matrix);
            Variables.figures.Add(f);
            ClearScene();
            RenderScene(Variables.figures);
        }

        public void RenderCuboid(Figure f)
        {
            List<LPoint> LPoints = new List<LPoint>();
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { 0, 0, 0, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { (double)f.width, 0, 0, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { (double)f.width, 0, (double)f.depth, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { 0, 0, (double)f.depth, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { 0, (double)f.height, 0, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { (double)f.width, (double)f.height, 0, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { (double)f.width, (double)f.height, (double)f.depth, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { 0, (double)f.height, (double)f.depth, 1 }), Variables.normal));

            List<Point> points = GetPoints(f.affineMatrix, LPoints);

            List<Tetragon> tetragons = new List<Tetragon>();
            tetragons.Add(new Tetragon(points[0], points[3], points[2], points[1]));
            tetragons.Add(new Tetragon(points[0], points[1], points[5], points[4]));
            tetragons.Add(new Tetragon(points[0], points[4], points[7], points[3]));
            tetragons.Add(new Tetragon(points[1], points[2], points[6], points[5]));
            tetragons.Add(new Tetragon(points[2], points[3], points[7], points[6]));
            tetragons.Add(new Tetragon(points[4], points[5], points[6], points[7]));

            for (int i = 0; i < tetragons.Count; i++)
            {
                (Triangle t1, Triangle t2) = BreakTetragon(tetragons[i]);
                AddTriangle(t1);
                AddTriangle(t2);
            }
        }

        public void RenderSphere(Figure f)
        {
            double r = (double)f.radius;
            int n = f.subdivisions;
            int c = n / 3;
            if (c % 2 == 0) c++;

            double[] nAngles = new double[n];
            double[] nCosines = new double[n];
            double[] nSines = new double[n];

            double[] cCosines = new double[c];
            double[] cSines = new double[c];

            for (int i = 0; i < n; i++)
            {
                nAngles[i] = Math.PI * 2 * i / n;
                nCosines[i] = Math.Cos(nAngles[i]);
                nSines[i] = Math.Sin(nAngles[i]);
            }

            for (int i = 0; i < c; i++)
            {
                cCosines[i] = Math.Cos(-Math.PI / 2 + (i + 1) * Math.PI / (c + 1));
                cSines[i] = Math.Sin(-Math.PI / 2 + (i + 1) * Math.PI / (c + 1));
            }

            List<LPoint> LPoints = new List<LPoint>();

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4]
                        { r + r * cCosines[i] * nSines[j], r + r * cSines[i], r + r * cCosines[i] * nCosines[j], 1 }), Variables.normal));
                }
            }

            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { r, 0, r, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { r, 2 * r, r, 1 }), Variables.normal));

            List<Point> points = GetPoints(f.affineMatrix, LPoints);

            List<Tetragon> tetragons = new List<Tetragon>();
            for (int i = 0; i < c - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    tetragons.Add(new Tetragon(points[i * n + j], points[(i + 1) * n + j], points[(i + 1) * n + j + 1], points[i * n + j + 1]));
                }
                tetragons.Add(new Tetragon(points[(i + 1) * n - 1], points[(i + 2) * n - 1], points[(i + 1) * n], points[i * n]));
            }

            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < tetragons.Count; i++)
            {
                (Triangle t1, Triangle t2) = BreakTetragon(tetragons[i]);
                triangles.Add(t1);
                triangles.Add(t2);
            }

            for (int i = 0; i < n; i++)
            {
                triangles.Add(new Triangle(points[i], points[i + 1], points[c * n]));
            }
            triangles.Add(new Triangle(points[n - 1], points[0], points[c * n]));
            for (int i = 0; i < n; i++)
            {
                triangles.Add(new Triangle(points[(c - 1) * n + i + 1], points[(c - 1) * n + i], points[c * n + 1]));
            }
            triangles.Add(new Triangle(points[(c - 1) * n], points[c * n - 1], points[c * n + 1]));

            for (int i = 0; i < triangles.Count; i++)
            {
                AddTriangle(triangles[i]);
            }
        }

        public void RenderCylinder(Figure f)
        {
            double r = (double)f.radius;
            double h = (double)f.height;
            int n = f.subdivisions;

            double[] nAngles = new double[n];
            double[] nCosines = new double[n];
            double[] nSines = new double[n];

            for (int i = 0; i < n; i++)
            {
                nAngles[i] = Math.PI * 2 * i / n;
                nCosines[i] = Math.Cos(nAngles[i]);
                nSines[i] = Math.Sin(nAngles[i]);
            }

            List<LPoint> LPoints = new List<LPoint>();

            for (int i = 0; i < n; i++)
            {
                LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4]
                    { r + r * nSines[i], 0, r + r * nCosines[i], 1 }), Variables.normal));
            }
            for (int i = 0; i < n; i++)
            {
                LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4]
                    { r + r * nSines[i], h, r + r * nCosines[i], 1 }), Variables.normal));
            }

            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { r, 0, r, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { r, h, r, 1 }), Variables.normal));

            List<Point> points = GetPoints(f.affineMatrix, LPoints);

            List<Tetragon> tetragons = new List<Tetragon>();

            for (int i = 0; i < n - 1; i++)
            {
                tetragons.Add(new Tetragon(points[i], points[n + i], points[n + i + 1], points[i + 1]));
            }
            tetragons.Add(new Tetragon(points[n - 1], points[2 * n - 1], points[n], points[0]));

            List<Triangle> triangles = new List<Triangle>();
            for (int i = 0; i < tetragons.Count; i++)
            {
                (Triangle t1, Triangle t2) = BreakTetragon(tetragons[i]);
                triangles.Add(t1);
                triangles.Add(t2);
            }

            for (int i = 0; i < n - 1; i++)
            {
                triangles.Add(new Triangle(points[i], points[i + 1], points[2 * n]));
            }
            triangles.Add(new Triangle(points[n - 1], points[0], points[2 * n]));
            for (int i = 0; i < n - 1; i++)
            {
                triangles.Add(new Triangle(points[n + i], points[2 * n + 1], points[n + i + 1]));
            }
            triangles.Add(new Triangle(points[2 * n - 1], points[2 * n + 1], points[n]));

            for (int i = 0; i < triangles.Count; i++)
            {
                AddTriangle(triangles[i]);
            }
        }

        public void RenderCone(Figure f)
        {
            double r = (double)f.radius;
            double h = (double)f.height;
            int n = f.subdivisions;

            double[] nAngles = new double[n];
            double[] nCosines = new double[n];
            double[] nSines = new double[n];

            for (int i = 0; i < n; i++)
            {
                nAngles[i] = Math.PI * 2 * i / n;
                nCosines[i] = Math.Cos(nAngles[i]);
                nSines[i] = Math.Sin(nAngles[i]);
            }

            List<LPoint> LPoints = new List<LPoint>();

            for (int i = 0; i < n; i++)
            {
                LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4]
                    { r + r * nSines[i], 0, r + r * nCosines[i], 1 }), Variables.normal));
            }
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { r, 0, r, 1 }), Variables.normal));
            LPoints.Add(new LPoint(Vector<double>.Build.DenseOfArray(new double[4] { r, h, r, 1 }), Variables.normal));

            List<Point> points = GetPoints(f.affineMatrix, LPoints);

            List<Triangle> triangles = new List<Triangle>();

            for (int i = 0; i < n - 1; i++)
            {
                triangles.Add(new Triangle(points[i], points[i + 1], points[n]));
            }
            triangles.Add(new Triangle(points[n - 1], points[0], points[n]));

            for (int i = 0; i < n - 1; i++)
            {
                triangles.Add(new Triangle(points[i], points[n + 1], points[i + 1]));
            }
            triangles.Add(new Triangle(points[n - 1], points[n + 1], points[0]));

            for (int i = 0; i < triangles.Count; i++)
            {
                AddTriangle(triangles[i]);
            }
        }
    }
}
