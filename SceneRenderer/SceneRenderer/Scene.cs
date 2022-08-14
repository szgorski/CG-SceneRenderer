using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SceneRenderer
{
    public partial class SceneRenderer
    {
        public void DrawLines()
        {
            using (var graphics = Graphics.FromImage(pictureBox.Image))
            {
                Pen pen = new Pen(Color.Black, 1);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                foreach ((Point, Point) line in Variables.lines)
                {
                    try
                    {
                        graphics.DrawLine(pen, line.Item1.X, line.Item1.Y, line.Item2.X, line.Item2.Y);
                    }
                    catch (OverflowException e) { }
                }
            }
        }

        public void ClearScene()
        {
            if (pictureBox.Image is not null)
                pictureBox.Image.Dispose();

            Bitmap bmp = new Bitmap(900, 900, PixelFormat.Format32bppArgb);
            BitmapData bits = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadWrite, bmp.PixelFormat);
            unsafe
            {
                for (int i = 0; i < Variables.sx; i++)              // bitmap height
                {
                    int* row = (int*)((byte*)bits.Scan0 + (i * bits.Stride));

                    for (int j = 0; j < Variables.sy; j++)          // bitmap width
                    {
                        row[j] = -1;
                        Variables.bitmapArray[j, i] = 4294967295;   // white background
                    }
                }
            }
            bmp.UnlockBits(bits);

            Variables.cameraMatrix = GetCameraMatrix();
            Variables.lines = new List<(Point, Point)>();
            pictureBox.Image = bmp;
        }

        public void RenderScene(List<Figure> scene)
        {
            for (int i = 0; i < scene.Count; i++)
            {
                switch (scene[i].type)
                {
                    case FigureType.Cuboid:
                        RenderCuboid(scene[i]);
                        break;

                    case FigureType.Sphere:
                        RenderSphere(scene[i]);
                        break;

                    case FigureType.Cylinder:
                        RenderCylinder(scene[i]);
                        break;

                    case FigureType.Cone:
                        RenderCone(scene[i]);
                        break;
                }
            }
            DrawLines();
        }
    }
}
