using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_FastReport
{
    public class Circle : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            g.FillEllipse(colorBrush, click.X - radius, click.Y - radius, radius * 2, radius * 2);
            g.DrawEllipse(colorPen, click.X - radius, click.Y - radius, radius * 2, radius * 2);
            circleArray[ci, 0] = click.X;
            circleArray[ci, 1] = click.Y;
            circleArray[ci, 2] = radius;
            ci += 1;
        }

        public override void CheckPoint(Point click)
        {
            while (i < ci)
            {
                if ((Math.Pow((click.X - circleArray[i, 0]), 2) + Math.Pow((click.Y - circleArray[i, 1]), 2)) <= Math.Pow(circleArray[i, 2], 2))
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
                if ((Math.Pow((click.X - circleArray[i, 0]), 2) + Math.Pow((click.Y - circleArray[i, 1]), 2)) <= Math.Pow(circleArray[i, 2], 2))
                {
                    option = 2;
                    j = i;
                    break;
                }
                i += 1;
            }
            i = 0;
        }

        public override void Move(Graphics g, Point click)
        {
            if (option == 2)
            {
                circleArray[j, 0] = click.X;
                circleArray[j, 1] = click.Y;
                j = 0;
            }
            NewCreateFigure(g, click);
            option = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < ci)
            {
                g.FillEllipse(colorBrush, circleArray[i, 0] - circleArray[i, 2], circleArray[i, 1] - circleArray[i, 2], circleArray[i, 2] * 2, circleArray[i, 2] * 2);
                g.DrawEllipse(colorPen, circleArray[i, 0] - circleArray[i, 2], circleArray[i, 1] - circleArray[i, 2], circleArray[i, 2] * 2, circleArray[i, 2] * 2);
                i += 1;
            }
            i = 0;
        }
        public override void Size(Graphics g, Point click)
        {
            if (circleArray[j, 1] > click.Y)
            {
                circleArray[j, 2] += (circleArray[j, 1] - circleArray[j, 2]) - click.Y;
            }
            else if (circleArray[j, 1] < click.Y)
            {
                circleArray[j, 2] += click.Y - (circleArray[j, 1] + circleArray[j, 2]);
            }
            NewCreateFigure(g, click);
            option = 1;
        }

    }
}
