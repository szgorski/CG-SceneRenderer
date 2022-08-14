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
        public int FastRound(double number)
        {
            int floor = (int)number;
            if (number - floor > 0.5)
                return floor + 1;
            else
                return floor;
        }

        public Matrix<double> RotateX(Matrix<double> matrix, double angle)
        {
            double[,] initial =
            {
                { 1, 0, 0, 0 },
                { 0, Math.Cos(angle), -Math.Sin(angle), 0 },
                { 0, Math.Sin(angle), Math.Cos(angle), 0 },
                { 0, 0, 0, 1 }
            };
            Matrix<double> rotationMatrix = Matrix<double>.Build.DenseOfArray(initial);
            return rotationMatrix * matrix;
        }

        public Matrix<double> RotateY(Matrix<double> matrix, double angle)
        {
            double[,] initial =
            {
                { Math.Cos(angle), 0, Math.Sin(angle), 0 },
                { 0, 1, 0, 0 },
                { -Math.Sin(angle), 0, Math.Cos(angle), 0 },
                { 0, 0, 0, 1 }
            };
            Matrix<double> rotationMatrix = Matrix<double>.Build.DenseOfArray(initial);
            return rotationMatrix * matrix;
        }

        public Matrix<double> RotateZ(Matrix<double> matrix, double angle)
        {
            double[,] initial =
            {
                { Math.Cos(angle), -Math.Sin(angle), 0, 0 },
                { Math.Sin(angle), Math.Cos(angle), 0, 0 },
                { 0, 0, 1, 0 },
                { 0, 0, 0, 1 }
            };
            Matrix<double> rotationMatrix = Matrix<double>.Build.DenseOfArray(initial);
            return rotationMatrix * matrix;
        }

        public Matrix<double> Translate(Matrix<double> matrix, double tx, double ty, double tz)
        {
            double[,] initial =
            {
                { 1, 0, 0, tx },
                { 0, 1, 0, ty },
                { 0, 0, 1, tz },
                { 0, 0, 0, 1 }
            };
            Matrix<double> rotationMatrix = Matrix<double>.Build.DenseOfArray(initial);
            return rotationMatrix * matrix;
        }

        public Vector<double> CrossProduct(Vector<double> left, Vector<double> right)
        {
            if ((left.Count == 3 || right.Count == 3))
            {
                Vector<double> result = Vector<double>.Build.Dense(3);
                result[0] = left[1] * right[2] - left[2] * right[1];
                result[1] = -left[0] * right[2] + left[2] * right[0];
                result[2] = left[0] * right[1] - left[1] * right[0];
                return result;
            }
            else
            {
                string message = "Vectors must have a length of 3.";
                throw new Exception(message);
            }
        }

        public Vector<double> ProjectPoint(Vector<double> point)
        {
            Vector<double> newPoint = Variables.projectionMatrix.Multiply(point);
            return newPoint.Divide(newPoint[3]);
        }

        public List<Point> GetPoints(Matrix<double> initMatrix, List<LPoint> lp)
        {
            Matrix<double> xMatrix = RotateY(Variables.cameraMatrix, Variables.xRotation);
            Matrix<double> xyMatrix = RotateX(xMatrix, Variables.yRotation);

            Matrix<double> matrix = xyMatrix.Multiply(initMatrix);
            List<Point> points = new List<Point>();

            for (int i = 0; i < lp.Count; i++)
            {
                Vector<double> vp1 = matrix.Multiply(lp[i].point);
                Vector<double> vp2 = ProjectPoint(vp1);
                Point point = new Point(FastRound(vp2[0] / vp2[3]), FastRound(vp2[1] / vp2[3]));
                points.Add(point);
            }

            return points;
        }

        public Matrix<double> GetCameraMatrix()
        {
            double[] initPos = { 0, Variables.distance, Variables.distance };
            double[] initTarget = { 0, 0, 0 };
            double[] initUp = { 0, 1, 0 };

            Vector<double> vPos = Vector<double>.Build.DenseOfArray(initPos);
            Vector<double> vTarget = Vector<double>.Build.DenseOfArray(initTarget);
            Vector<double> vUp = Vector<double>.Build.DenseOfArray(initUp);

            Vector<double> vDiff = vPos - vTarget;
            Vector<double> vZ = vDiff.Divide(vDiff.L2Norm());

            Vector<double> vUZ = CrossProduct(vUp, vZ);
            Vector<double> vX = vUZ.Divide(vUZ.L2Norm());

            Vector<double> vZX = CrossProduct(vZ, vX);
            Vector<double> vY = vZX.Divide(vZX.L2Norm());

            double[,] initMatrix =
            {
                { vX[0], vX[1], vX[2], vX.DotProduct(vPos) },
                { vY[0], vY[1], vY[2], vY.DotProduct(vPos) },
                { vZ[0], vZ[1], vZ[2], vZ.DotProduct(vPos) },
                { 0, 0, 0, 1 }
            };

            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(initMatrix);
            return matrix;
        }

        public Matrix<double> GetProjectionMatrix()
        {
            double[,] initial =
            {
                { -(Variables.sx / 2) * (1 / Math.Tan(Variables.angle / 2)), 0, Variables.sx / 2, 0 },
                { 0, (Variables.sx / 2) * (1 / Math.Tan(Variables.angle / 2)), Variables.sy / 2, 0 },
                { 0, 0, 0, 1 },
                { 0, 0, 1, 0 }
            };

            Matrix<double> matrix = Matrix<double>.Build.DenseOfArray(initial);
            return matrix;
        }
    }
}
