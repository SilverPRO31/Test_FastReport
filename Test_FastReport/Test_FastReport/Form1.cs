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
        Line l = new Line();
        Graphics g;
        Point click;
        string action;
        int linePoint = 1; 
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
                    break;
                case "circle":
                    c.CreateFigure(g, click);
                    break;
                case "triangle":
                    t.CreateFigure(g, click);
                    break;
                case "checks":
                    r.CheckPoint(click);
                    c.CheckPoint(click);
                    t.CheckPoint(click);
                    break;
                case "move":
                    if (Figure.option == 1)
                    {
                        r.Check(click);
                        c.Check(click);
                        t.Check(click);
                    }
                    else if (Figure.option > 1)
                    {
                        this.Invalidate();
                        this.Update();
                        if (Figure.option == 2)
                        {
                            c.Move(g, click);
                            t.NewCreateFigure(g, click);
                            r.NewCreateFigure(g, click);
                            l.NewCreateFigure(g, click);
                        }
                        else if (Figure.option == 3)
                        {
                            r.Move(g, click);
                            t.NewCreateFigure(g, click);
                            c.NewCreateFigure(g, click);
                            l.NewCreateFigure(g, click);
                        }
                        else if (Figure.option == 4)
                        {
                            t.Move(g, click);
                            c.NewCreateFigure(g, click);
                            r.NewCreateFigure(g, click);
                            l.NewCreateFigure(g, click);
                        }
                    }
                    break;
                case "size":
                    if (Figure.option == 1)
                    {
                        r.Check(click);
                        c.Check(click);
                        t.Check(click);
                    }
                    else if (Figure.option > 1)
                    {
                        this.Invalidate();
                        this.Update();
                        if (Figure.option == 2)
                        {
                            c.Size(g, click);
                            t.NewCreateFigure(g, click);
                            r.NewCreateFigure(g, click);
                            l.NewCreateFigure(g, click);
                        }
                        else if (Figure.option == 3)
                        {
                            r.Size(g, click);
                            t.NewCreateFigure(g, click);
                            c.NewCreateFigure(g, click);
                            l.NewCreateFigure(g, click);
                        }
                        else if (Figure.option == 4)
                        {
                            t.Size(g, click);
                            c.NewCreateFigure(g, click);
                            r.NewCreateFigure(g, click);
                            l.NewCreateFigure(g, click);
                        }
                    }
                        break;
                case "line":
                    r.Check(click);
                    c.Check(click);
                    t.Check(click);
                    if (linePoint == 1)
                    {
                        l.SevePointOne(g, click);
                        linePoint = 2;
                    }
                    else if (linePoint == 2)
                    {
                        l.SevePointTwo(g, click);
                        linePoint = 1;
                    }
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
        private void soedin_Click(object sender, EventArgs e)
        {
            action = "line";
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            action = "";
        }

        
    }
}
