using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MathNet.Numerics.LinearAlgebra;
using Newtonsoft.Json;

namespace SceneRenderer
{
    public partial class SceneRenderer : Form
    {
        public SceneRenderer()
        {
            InitializeComponent();
            Variables.projectionMatrix = GetProjectionMatrix();
            ClearScene();
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (((RadioButton)sender).Name)
            {
                case "radioButtonCuboid":
                    Variables.modeName = FigureType.Cuboid;
                    break;

                case "radioButtonSphere":
                    Variables.modeName = FigureType.Sphere;
                    break;

                case "radioButtonCyllinder":
                    Variables.modeName = FigureType.Cylinder;
                    break;

                case "radioButtonCone":
                    Variables.modeName = FigureType.Cone;
                    break;
            }
        }

        private void buttonApplyFigure_Click(object sender, EventArgs e)
        {
            AddFigure(Variables.modeName);
        }

        private void trackBarX_ValueChanged(object sender, EventArgs e)
        {
            Variables.xRotation = Math.PI * trackBarX.Value / 180;
            ClearScene();
            RenderScene(Variables.figures);
        }

        private void trackBarY_ValueChanged(object sender, EventArgs e)
        {
            Variables.yRotation = Math.PI * trackBarY.Value / 180;
            ClearScene();
            RenderScene(Variables.figures);
        }

        private void trackBarDistance_ValueChanged(object sender, EventArgs e)
        {
            Variables.distance = trackBarDistance.Value;
            ClearScene();
            RenderScene(Variables.figures);
        }

        private void buttonLoadSettings_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
#nullable enable
                Figure[] oldSettings = Variables.figures.ToArray();

                string JSONstring = File.ReadAllText(openFileDialog.FileName);
                List<Figure>? newFigures = JsonConvert.DeserializeObject<List<Figure>>(JSONstring);
                if (newFigures is not null)
                {
                    try
                    {
                        foreach (Figure f in newFigures)
                        {
                            f.affineMatrix = Matrix<double>.Build.DenseOfArray(f.figureMatrix);
                        }
                        ClearScene();
                        RenderScene(newFigures);
                        Variables.figures = newFigures;
                    }
                    catch
                    {
                        Variables.figures = oldSettings.ToList();
                        ClearScene();
                        RenderScene(Variables.figures);
                    }
                }
#nullable disable
            }
        }

        private void buttonSaveSettings_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string JSONstring = JsonConvert.SerializeObject(Variables.figures, Formatting.Indented);
                File.WriteAllText(saveFileDialog.FileName, JSONstring);
            }
        }

        public static class Variables
        {
            public static double xRotation = 0;
            public static double yRotation = 0;
            public static double distance = 10;

            public static int sx = 900;     // picturebox.Height
            public static int sy = 900;     // picturebox.Width
            public static double angle = Math.PI / 3;

            public static Matrix<double> projectionMatrix;
            public static Matrix<double> cameraMatrix;

            public static Bitmap bitmap;
            public static uint[,] bitmapArray = new uint[sy, sx];
            public static List<Figure> figures = new List<Figure>();
            public static FigureType modeName = FigureType.Cuboid;
            public static Pen pen = new Pen(Color.Black, 1);
            public static List<(Point, Point)> lines = new List<(Point, Point)>();
            public static Vector<double> normal = Vector<double>.Build.DenseOfArray(new double[] { 0, 0, 1, 0 });
        }
    }
}