using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_FastReport
{
    public class Triangle : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            x1 = Convert.ToInt32(click.X + (radius * (-(Math.Sqrt(3) / 2.0))));
            y1 = Convert.ToInt32(click.Y - (radius * (-(1.0 / 2))));
            x2 = Convert.ToInt32(click.X + (radius * (Math.Sqrt(3) / 2.0)));
            y2 = Convert.ToInt32(click.Y - (radius * (-(1.0 / 2))));
            Point[] trianglePoints = new Point[] { new Point(click.X + (radius * 0), click.Y - (radius * 1)), new Point(x1, y1), new Point(x2, y2) };
            g.FillPolygon(colorBrush, trianglePoints);
            g.DrawPolygon(colorPen, trianglePoints);
            triangleArray[tr, 0] = click.X;
            triangleArray[tr, 1] = click.Y;
            triangleArray[tr, 2] = radius;
            tr += 1;
        }

        public override void CheckPoint(Point click)
        {
            while (i < tr)
            {
                x = click.X;
                y = click.Y;
                x1 = triangleArray[i, 0] + (triangleArray[i, 2] * 0);
                y1 = triangleArray[i, 1] - (triangleArray[i, 2] * 1);
                x2 = Convert.ToInt32(triangleArray[i, 0] + (triangleArray[i, 2] * (-(Math.Sqrt(3) / 2.0))));
                y2 = Convert.ToInt32(triangleArray[i, 1] - (triangleArray[i, 2] * (-(1.0 / 2))));
                x3 = Convert.ToInt32(triangleArray[i, 0] + (triangleArray[i, 2] * (Math.Sqrt(3) / 2.0)));
                y3 = Convert.ToInt32(triangleArray[i, 1] - (triangleArray[i, 2] * (-(1.0 / 2))));
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
                x1 = triangleArray[i, 0] + (triangleArray[i, 2] * 0);
                y1 = triangleArray[i, 1] - (triangleArray[i, 2] * 1);
                x2 = Convert.ToInt32(triangleArray[i, 0] + (triangleArray[i, 2] * (-(Math.Sqrt(3) / 2.0))));
                y2 = Convert.ToInt32(triangleArray[i, 1] - (triangleArray[i, 2] * (-(1.0 / 2))));
                x3 = Convert.ToInt32(triangleArray[i, 0] + (triangleArray[i, 2] * (Math.Sqrt(3) / 2.0)));
                y3 = Convert.ToInt32(triangleArray[i, 1] - (triangleArray[i, 2] * (-(1.0 / 2))));
                S = (1.0 / 2) * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
                S1 = (1.0 / 2) * Math.Abs(x * (y2 - y3) + x2 * (y3 - y) + x3 * (y - y2));
                S2 = (1.0 / 2) * Math.Abs(x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y));
                S3 = (1.0 / 2) * Math.Abs(x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2));
                if ((S1 + S2 + S3) == S)
                {
                    option = 4;
                    j = i;
                    break;
                }
                i += 1;
            }
            i = 0;
        }

        public override void Move(Graphics g, Point click)
        {
            if (option == 4)
            {
                triangleArray[j, 0] = click.X;
                triangleArray[j, 1] = click.Y;
                j = 0;
            }
            NewCreateFigure(g, click);

            option = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < tr)
            {
                x1 = Convert.ToInt32(triangleArray[i, 0] + (triangleArray[i, 2] * (-(Math.Sqrt(3) / 2.0))));
                y1 = Convert.ToInt32(triangleArray[i, 1] - (triangleArray[i, 2] * (-(1.0 / 2))));
                x2 = Convert.ToInt32(triangleArray[i, 0] + (triangleArray[i, 2] * (Math.Sqrt(3) / 2.0)));
                y2 = Convert.ToInt32(triangleArray[i, 1] - (triangleArray[i, 2] * (-(1.0 / 2))));
                Point[] trianglePoints = new Point[] { new Point(triangleArray[i, 0] + (triangleArray[i, 2] * 0), triangleArray[i, 1] - (triangleArray[i, 2] * 1)), new Point(x1, y1), new Point(x2, y2) };
                g.FillPolygon(colorBrush, trianglePoints);
                g.DrawPolygon(colorPen, trianglePoints);
                i += 1;
            }
            i = 0;
        }
        public override void Size(Graphics g, Point click)
        {
            if (triangleArray[j, 1] > click.Y)
            {
                triangleArray[j, 2] += (triangleArray[j, 1] - triangleArray[j, 2]) - click.Y;
            }
            else if (triangleArray[j, 1] < click.Y)
            {
                triangleArray[j, 2] += click.Y - (triangleArray[j, 1] + triangleArray[j, 2]);
            }
            NewCreateFigure(g, click);
            option = 1;
        }
    }
}
