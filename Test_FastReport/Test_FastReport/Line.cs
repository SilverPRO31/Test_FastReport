using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_FastReport
{
    public class Line : Figure
    {
        public override void CreateFigure(Graphics g, Point click)
        {
            j = lineArray[ln, 0, 1];
            if (lineArray[ln, 0, 0] == 2)
            {
                linePointArray[0] = new Point(circleArray[j,0], circleArray[j, 1]);
            }
            else if (lineArray[ln, 0, 0] == 3)
            {
                linePointArray[0] = new Point(rectangleArray[j, 0], rectangleArray[j, 1]);
            }
            else if (lineArray[ln, 0, 0] == 4)
            {
                linePointArray[0] = new Point(triangleArray[j, 0], triangleArray[j, 1]);
            }
            j = lineArray[ln, 1, 1];
            if (lineArray[ln, 1, 0] == 2)
            {
                linePointArray[1] = new Point(circleArray[j, 0], circleArray[j, 1]);
            }
            else if (lineArray[ln, 1, 0] == 3)
            {
                linePointArray[1] = new Point(rectangleArray[j, 0], rectangleArray[j, 1]);
            }
            else if (lineArray[ln, 1, 0] == 4)
            {
                linePointArray[1] = new Point(triangleArray[j, 0], triangleArray[j, 1]);
            }
            j = 0;
            g.DrawLine(colorPen, linePointArray[0], linePointArray[1]);
            ln += 1;
        }
        public void SevePointOne(Graphics g, Point click)
        {
            if (option == 2)
            {
                lineArray[ln, 0, 0] = 2;
                lineArray[ln, 0, 1] = j;
            }
            else if (option == 3)
            {
                lineArray[ln, 0, 0] = 3;
                lineArray[ln, 0, 1] = j;
            }
            else if (option == 4)
            {
                lineArray[ln, 0, 0] = 4;
                lineArray[ln, 0, 1] = j;
            }

        }
        public void SevePointTwo(Graphics g, Point click)
        {
            if (option == 2)
            {
                lineArray[ln, 1, 0] = 2;
                lineArray[ln, 1, 1] = j;
            }
            else if (option == 3)
            {
                lineArray[ln, 1, 0] = 3;
                lineArray[ln, 1, 1] = j;
            }
            else if (option == 4)
            {
                lineArray[ln, 1, 0] = 4;
                lineArray[ln, 1, 1] = j;
            }
            CreateFigure(g, click);
            option = 1;
        }
        public override void NewCreateFigure(Graphics g, Point click)
        {
            while (i < ln)
            {
                j = lineArray[i, 0, 1];
                if (lineArray[i, 0, 0] == 2)
                {
                    linePointArray[0] = new Point(circleArray[j, 0], circleArray[j, 1]);
                }
                else if (lineArray[i, 0, 0] == 3)
                {
                    linePointArray[0] = new Point(rectangleArray[j, 0], rectangleArray[j, 1]);
                }
                else if (lineArray[i, 0, 0] == 4)
                {
                    linePointArray[0] = new Point(triangleArray[j, 0], triangleArray[j, 1]);
                }
                j = lineArray[i, 1, 1];
                if (lineArray[i, 1, 0] == 2)
                {
                    linePointArray[1] = new Point(circleArray[j, 0], circleArray[j, 1]);
                }
                else if (lineArray[i, 1, 0] == 3)
                {
                    linePointArray[1] = new Point(rectangleArray[j, 0], rectangleArray[j, 1]);
                }
                else if (lineArray[i, 1, 0] == 4)
                {
                    linePointArray[1] = new Point(triangleArray[j, 0], triangleArray[j, 1]);
                }
                j = 0;
                g.DrawLine(colorPen, linePointArray[0], linePointArray[1]);
                i += 1;
            }
            i = 0;
        }
    }
}
