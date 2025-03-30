using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Test_FastReport
{
    
    public partial class Form1 : Form
    {
        Rectangle r = new Rectangle();
        Triangle t = new Triangle();
        Circle c = new Circle();
        Graphics g;
        Point click;
        string action;
        //int[,] rect = new int[100, 2];
        //int[,] circ = new int[100, 2];
        //int[,] trig = new int[100, 2];
        //int re = 0, ci = 0, tr = 0, i = 0, x, x1, x2, x3, y, y1 ,y2 ,y3;
        //double S, S1, S2, S3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            g = CreateGraphics();
            click = e.Location;
            switch (action)
            {
                case "rectangle": 
                    r.CreateFigure(g, click);
                    //rect[re, 0] = click.X-(Figure.width / 2);
                    //rect[re, 1] = click.Y-(Figure.height / 2);
                    //re += 1;
                    break;
                case "circle":
                    c.CreateFigure(g, click);
                    //circ[ci, 0] = click.X;
                    //circ[ci, 1] = click.Y;
                    //ci += 1;
                    break;
                case "triangle":
                    t.CreateFigure(g, click);
                    //trig[tr, 0] = click.X;
                    //trig[tr, 1] = click.Y;
                    //tr += 1;
                    break;
                case "checks":
                    r.CheckPoint(click);
                    c.CheckPoint(click);
                    t.CheckPoint(click);
                    //while (i < re)
                    //{
                    //    if ((rect[i, 0]+Figure.width) > click.X && rect[i, 0] < click.X && (rect[i, 1] + Figure.height) > click.Y && rect[i, 1] < click.Y)
                    //    {
                    //        MessageBox.Show("Данная точка внутри примитива прямоугольника");
                    //    }
                    //    i += 1;
                    //}
                    //i = 0;
                    //while (i < ci)
                    //{
                    //    if ( (Math.Pow((click.X - circ[i, 0]), 2) + Math.Pow((click.Y - circ[i,1]), 2)) <= Math.Pow(Figure.radius, 2 ))
                    //    {
                    //        MessageBox.Show("Данная точка внутри примитива круга");
                    //    }
                    //    i += 1;
                    //}
                    //i = 0;
                    //while (i < tr)
                    //{
                    //    x = click.X;
                    //    y = click.Y;
                    //    x1 = trig[i, 0] + (Figure.radius * 0);
                    //    y1 = trig[i, 1] - (Figure.radius * 1);
                    //    x2 = Convert.ToInt32(trig[i, 0] + (Figure.radius * (-(Math.Sqrt(3) / 2.0))));
                    //    y2 = Convert.ToInt32(trig[i, 1] - (Figure.radius * (-(1.0 / 2))));
                    //    x3 = Convert.ToInt32(trig[i, 0] + (Figure.radius * (Math.Sqrt(3) / 2.0)));
                    //    y3 = Convert.ToInt32(trig[i, 1] - (Figure.radius * (-(1.0 / 2))));
                    //    S = (1.0 / 2) * Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
                    //    S1 = (1.0 / 2) * Math.Abs( x *(y2 - y3) +x2 * (y3 - y) + x3 * (y - y2) );
                    //    S2 = (1.0 / 2) * Math.Abs( x1 * (y - y3) + x * (y3 - y1) + x3 * (y1 - y) );
                    //    S3 = (1.0 / 2) * Math.Abs( x1 * (y2 - y) + x2 * (y - y1) + x * (y1 - y2) );
                    //    if ( (S1 + S2 + S3) == S )
                    //    {
                    //        MessageBox.Show("Данная точка внутри примитива треугольника");
                    //    }
                    //    i += 1;
                    //}
                    //i = 0;
                    break;
                case "move":
                    if (Figure.move == 1)
                    {
                        r.Check(click);
                        c.Check(click);
                        t.Check(click);
                    }
                    else if (Figure.move > 1)
                    {
                        this.Invalidate();
                        this.Update();
                        if (Figure.move == 2)
                        {
                            c.Move(g, click);
                            t.NewCreateFigure(g, click);
                            r.NewCreateFigure(g, click);
                        }
                        else if (Figure.move == 3)
                        {
                            r.Move(g, click);
                            t.NewCreateFigure(g, click);
                            c.NewCreateFigure(g, click);
                        }
                        else if (Figure.move == 4)
                        {
                            t.Move(g, click);
                            c.NewCreateFigure(g, click);
                            r.NewCreateFigure(g, click);
                        }
                    }
                    break;
                case "size":

                    break;
                default: 
                    break;
            }
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            action = "rectangle";
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            action = "circle";
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            action = "triangle";
        }

        private void check_Click(object sender, EventArgs e)
        {
            action = "checks";
        }

        private void move_Click(object sender, EventArgs e)
        {
            action = "move";
        }
        private void size_Click(object sender, EventArgs e)
        {
            action = "size";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            action = "";
        }

    }
}
