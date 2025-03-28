using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    r.CreateFigure( sender,  e, g, click);
                    break;
                case "circle":
                    c.CreateFigure( sender,  e, g, click);
                    break;
                case "triangle":
                    t.CreateFigure( sender,  e, g, click);
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

        private void cancel_Click(object sender, EventArgs e)
        {
            action = "";
        }
    }
    public class Figure
    {   
        public virtual void CreateFigure(object sender, MouseEventArgs e, Graphics g, Point click)
        {

        }
    }

    public class Circle : Figure
    {
        public override void CreateFigure(object sender, MouseEventArgs e, Graphics g, Point click)
        {
            g.DrawEllipse(Pens.Black, click.X-25, click.Y-25, 50, 50);
        }
    }

    public class Rectangle : Figure
    {
        public override void CreateFigure(object sender, MouseEventArgs e, Graphics g, Point click)
        {
            g.DrawRectangle(Pens.Black, click.X-50, click.Y-25, 100, 50);
        }
    }

    public class Triangle : Figure
    {
        public override void CreateFigure(object sender, MouseEventArgs e, Graphics g, Point click)
        {
            g.DrawRectangle(Pens.Black, click.X, click.Y, 100, 50);
        }
    }
}
