using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Test_FastReport
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Figure
    {

        static Color penColor = Color.Black;
        static Color brushColor = Color.Red;
        protected Pen colorPen = new Pen(penColor);
        protected Brush colorBrush = new SolidBrush(brushColor);
        public static int width = 100, height = 50, radius = 50, move = 1;
        protected const int corner = 60;
        protected Point[] trianglePoints;
        protected int[,] rect = new int[100, 4];
        protected int[,] circ = new int[100, 3];
        protected int[,] trig = new int[100, 3];
        protected int re = 0, ci = 0, tr = 0, i = 0, x, x1, x2, x3, y, y1, y2, y3, j;
        protected double S, S1, S2, S3;
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

    }

    public class Circle : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            g.FillEllipse(colorBrush, click.X - radius, click.Y - radius, radius * 2, radius * 2);
            g.DrawEllipse(colorPen, click.X - radius, click.Y - radius, radius * 2, radius * 2);
            circ[ci, 0] = click.X;
            circ[ci, 1] = click.Y;
            circ[ci, 2] = radius;
            ci += 1;
        }

        public override void CheckPoint(Point click)
        {
            while (i < ci)
            {
                if ((Math.Pow((click.X - circ[i, 0]), 2) + Math.Pow((click.Y - circ[i, 1]), 2)) <= Math.Pow(circ[i, 2], 2))
                {
                    MessageBox.Show("Данная точка внутри примитива круга");
                }
                i += 1;
            }
            i = 0;
        }

        public override void Check(Point click)
        {
            while (i < ci)
            {
                if ((Math.Pow((click.X - circ[i, 0]), 2) + Math.Pow((click.Y - circ[i, 1]), 2)) <= Math.Pow(circ[i, 2], 2))
                {
                    move = 2;
                    j = i;
                    break;
                }
                i += 1;
            }
            i = 0;
        }

        public override void Move(Graphics g, Point click)
        {
            if (move == 2)
            {
                circ[j, 0] = click.X;
                circ[j, 1] = click.Y;
                j = 0;
            }
            NewCreateFigure(g, click);
            move = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < ci)
            {
                g.FillEllipse(colorBrush, circ[i, 0] - circ[i, 2], circ[i, 1] - circ[i, 2], circ[i, 2] * 2, circ[i, 2] * 2);
                g.DrawEllipse(colorPen, circ[i, 0] - circ[i, 2], circ[i, 1] - circ[i, 2], circ[i, 2] * 2, circ[i, 2] * 2);
                i += 1;
            }
            i = 0;
        }

    }

    public class Rectangle : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            g.FillRectangle(colorBrush, click.X - (width / 2), click.Y - (height / 2), width, height);
            g.DrawRectangle(colorPen, click.X - (width / 2), click.Y - (height / 2), width, height);
            rect[re, 0] = click.X;
            rect[re, 1] = click.Y;
            rect[re, 2] = width;
            rect[re, 3] = height;
            re += 1;

        }

        public override void CheckPoint(Point click)
        {
            while (i < re)
            {
                if ((rect[i, 0] + (rect[i, 2] / 2)) > click.X && (rect[i, 0] - (rect[i, 2] / 2)) < click.X && (rect[i, 1] + (rect[i, 3] / 2)) > click.Y && (rect[i, 1] - (rect[i, 3] / 2)) < click.Y)
                {
                    MessageBox.Show("Данная точка внутри примитива прямоугольника");
                }
                i += 1;
            }
            i = 0;
        }

        public override void Check(Point click)
        {
            while (i < re)
            {
                if ((rect[i, 0] + (rect[i, 2] / 2)) > click.X && (rect[i, 0] - (rect[i, 2] / 2)) < click.X && (rect[i, 1] + (rect[i, 3] / 2)) > click.Y && (rect[i, 1] - (rect[i, 3] / 2)) < click.Y)
                {
                    move = 3;
                    j = i;
                    break;
                }
                i += 1;
            }
            i = 0;
        }

        public override void Move(Graphics g, Point click)
        {
            if (move == 3)
            {
                rect[j, 0] = click.X;
                rect[j, 1] = click.Y;
                j = 0;
            }
            NewCreateFigure(g, click);
            
            move = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < re)
            {
                g.FillRectangle(colorBrush, rect[i, 0] - (rect[i, 2] / 2), rect[i, 1] - (rect[i, 3] / 2), rect[i, 2], rect[i, 3]);
                g.DrawRectangle(colorPen, rect[i, 0] - (rect[i, 2] / 2), rect[i, 1] - (rect[i, 3] / 2), rect[i, 2], rect[i, 3]);
                i += 1;
            }
            i = 0;
        }
    }

    public class Triangle : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            x1 = Convert.ToInt32(click.X + (radius * (-(Math.Sqrt(3) / 2.0))));
            y1 = Convert.ToInt32(click.Y - (radius * (-(1.0 / 2))));
            x2 = Convert.ToInt32(click.X + (radius * (Math.Sqrt(3) / 2.0)));
            y2 = Convert.ToInt32(click.Y - (radius * (-(1.0 / 2))));
            Point[] trianglePoints = new Point[] {new Point(click.X + (radius * 0), click.Y - (radius * 1)), new Point (x1, y1), new Point(x2, y2) };
            g.FillPolygon(colorBrush, trianglePoints);
            g.DrawPolygon(colorPen, trianglePoints);
            trig[tr, 0] = click.X;
            trig[tr, 1] = click.Y;
            trig[tr, 2] = radius;
            tr += 1;
        }

        public override void CheckPoint(Point click)
        {
            while (i < tr)
            {
                x = click.X;
                y = click.Y;
                x1 = trig[i, 0] + (trig[i, 2] * 0);
                y1 = trig[i, 1] - (trig[i, 2] * 1);
                x2 = Convert.ToInt32(trig[i, 0] + (trig[i, 2] * (-(Math.Sqrt(3) / 2.0))));
                y2 = Convert.ToInt32(trig[i, 1] - (trig[i, 2] * (-(1.0 / 2))));
                x3 = Convert.ToInt32(trig[i, 0] + (trig[i, 2] * (Math.Sqrt(3) / 2.0)));
                y3 = Convert.ToInt32(trig[i, 1] - (trig[i, 2] * (-(1.0 / 2))));
                S = (1.0 / 2) * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
                S1 = (1.0 / 2) * Math.Abs(x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2));
                S2 = (1.0 / 2) * Math.Abs(x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y));
                S3 = (1.0 / 2) * Math.Abs(x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2));
                if ((S1 + S2 + S3) == S)
                {
                    MessageBox.Show("Данная точка внутри примитива треугольника");
                }
                i += 1;
            }
            i = 0;
        }

        public override void Check(Point click)
        {
            while (i < tr)
            {
                x = click.X;
                y = click.Y;
                x1 = trig[i, 0] + (trig[i, 2] * 0);
                y1 = trig[i, 1] - (trig[i, 2] * 1);
                x2 = Convert.ToInt32(trig[i, 0] + (trig[i, 2] * (-(Math.Sqrt(3) / 2.0))));
                y2 = Convert.ToInt32(trig[i, 1] - (trig[i, 2] * (-(1.0 / 2))));
                x3 = Convert.ToInt32(trig[i, 0] + (trig[i, 2] * (Math.Sqrt(3) / 2.0)));
                y3 = Convert.ToInt32(trig[i, 1] - (trig[i, 2] * (-(1.0 / 2))));
                S = (1.0 / 2) * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
                S1 = (1.0 / 2) * Math.Abs(x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2));
                S2 = (1.0 / 2) * Math.Abs(x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y));
                S3 = (1.0 / 2) * Math.Abs(x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2));
                if ((S1 + S2 + S3) == S)
                {
                    move = 4;
                    j = i;
                    break;
                }
                i += 1;
            }
            i = 0;
        }

        public override void Move(Graphics g, Point click)
        {
            if (move == 4)
            {
                trig[j, 0] = click.X;
                trig[j, 1] = click.Y;
                j = 0;
            }
            NewCreateFigure(g, click);
            
            move = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < tr)
            {
                x1 = Convert.ToInt32(trig[i, 0] + (trig[i, 2] * (-(Math.Sqrt(3) / 2.0))));
                y1 = Convert.ToInt32(trig[i, 1] - (trig[i, 2] * (-(1.0 / 2))));
                x2 = Convert.ToInt32(trig[i, 0] + (trig[i, 2] * (Math.Sqrt(3) / 2.0)));
                y2 = Convert.ToInt32(trig[i, 1] - (trig[i, 2] * (-(1.0 / 2))));
                Point[] trianglePoints = new Point[] { new Point(trig[i, 0] + (trig[i, 2] * 0), trig[i, 1] - (trig[i, 2] * 1)), new Point(x1, y1), new Point(x2, y2) };
                g.FillPolygon(colorBrush, trianglePoints);
                g.DrawPolygon(colorPen, trianglePoints);
                i += 1;
            }
            i = 0;
        }
    }

}
