using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_FastReport
{
    public class Rectangle : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            g.FillRectangle(colorBrush, click.X - (width / 2), click.Y - (height / 2), width, height);
            g.DrawRectangle(colorPen, click.X - (width / 2), click.Y - (height / 2), width, height);
            rectangleArray[re, 0] = click.X;
            rectangleArray[re, 1] = click.Y;
            rectangleArray[re, 2] = width;
            rectangleArray[re, 3] = height;
            re += 1;

        }

        public override void CheckPoint(Point click)
        {
            while (i < re)
            {
                if ((rectangleArray[i, 0] + (rectangleArray[i, 2] / 2)) > click.X && (rectangleArray[i, 0] - (rectangleArray[i, 2] / 2)) < click.X && (rectangleArray[i, 1] + (rectangleArray[i, 3] / 2)) > click.Y && (rectangleArray[i, 1] - (rectangleArray[i, 3] / 2)) < click.Y)
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
                if ((rectangleArray[i, 0] + (rectangleArray[i, 2] / 2)) > click.X && (rectangleArray[i, 0] - (rectangleArray[i, 2] / 2)) < click.X && (rectangleArray[i, 1] + (rectangleArray[i, 3] / 2)) > click.Y && (rectangleArray[i, 1] - (rectangleArray[i, 3] / 2)) < click.Y)
                {
                    option = 3;
                    j = i;
                    break;
                }
                i += 1;
            }
            i = 0;
        }

        public override void Move(Graphics g, Point click)
        {
            if (option == 3)
            {
                rectangleArray[j, 0] = click.X;
                rectangleArray[j, 1] = click.Y;
                j = 0;
            }
            NewCreateFigure(g, click);

            option = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < re)
            {
                g.FillRectangle(colorBrush, rectangleArray[i, 0] - (rectangleArray[i, 2] / 2), rectangleArray[i, 1] - (rectangleArray[i, 3] / 2), rectangleArray[i, 2], rectangleArray[i, 3]);
                g.DrawRectangle(colorPen, rectangleArray[i, 0] - (rectangleArray[i, 2] / 2), rectangleArray[i, 1] - (rectangleArray[i, 3] / 2), rectangleArray[i, 2], rectangleArray[i, 3]);
                i += 1;
            }
            i = 0;
        }
        public override void Size(Graphics g, Point click)
        {
            if (rectangleArray[j, 1] > click.Y)
            {
                rectangleArray[j, 3] += rectangleArray[j, 1] - click.Y;
                rectangleArray[j, 2] += rectangleArray[j, 1] - click.Y;
            }
            else if (rectangleArray[j, 1] < click.Y)
            {
                rectangleArray[j, 3] -= click.Y - rectangleArray[j, 1];
                rectangleArray[j, 2] -= click.Y - rectangleArray[j, 1];
            }
            NewCreateFigure(g, click);
            option = 1;
        }
    }
}
