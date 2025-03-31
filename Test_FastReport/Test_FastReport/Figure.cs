using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FastReport
{
    public class Figure
    {

        static Color penColor = Color.Black;
        static Color brushColor = Color.Red;
        protected Pen colorPen = new Pen(penColor);
        protected Brush colorBrush = new SolidBrush(brushColor);
        public static int width = 100, height = 50, radius = 50, option = 1;
        protected const int angle = 60;
        protected static Point[] trianglePoints;
        protected static int[,] rectangleArray = new int[100, 4];
        protected static int[,] circleArray = new int[100, 3];
        protected static int[,] triangleArray = new int[100, 3];
        protected static int[,,] lineArray = new int[100, 2, 2];
        protected static Point[] linePointArray = new Point[2];
        protected static int re = 0, ci = 0, tr = 0, ln = 0, i = 0, x, x1, x2, x3, y, y1, y2, y3, j;
        protected static double S, S1, S2, S3;
        public virtual void CreateFigure(Graphics g, Point click)
        {

        }
        public virtual void CheckPoint(Point click)
        {

        }

        public virtual void Check(Point click)
        {

        }
        public virtual void Move(Graphics g, Point click)
        {

        }
        public virtual void NewCreateFigure(Graphics g, Point click)
        {

        }
        public virtual void Size(Graphics g, Point click)
        {

        }

    }
}
