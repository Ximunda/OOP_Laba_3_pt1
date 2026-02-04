using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Laba_3
{
    public partial class mainForm : Form
    {
        public Container container = new Container();
        public mainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_MouseClick(object sender, MouseEventArgs e)
        {
            CCircle circle = new CCircle(e.X, e.Y);
            container.Add(circle);
            Invalidate();
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            container.DrawAll(e.Graphics);
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            container.Clear();
            Invalidate();
        }
    };
    public class CCircle
    {
        private int X;
        private int Y;
        private Color Circle_color;
        private int Radius;
        private bool Selected = false;
        public CCircle(int x, int y, int radius, Color color)
        {
            Radius = radius;
            X = x;
            Y = y;
            Circle_color = color;
        }
        public CCircle(int x, int y)
        {
            Radius = 20;
            X = x;
            Y = y;
            Circle_color = Color.Black;
        }
        public void Draw(Graphics g)
        {
            if (Selected)
            {
                Circle_color = Color.Red;
            }
            using (Pen pen = new Pen(Circle_color, 2))
            {
                g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
        private bool IsClicked(int mx, int my)
        {
            int dx = mx - X;
            int dy = my - Y;
            bool result = (dx * dx) + (dy * dy) <= (Radius * Radius);
            return result;
        }
    }
    public class Container
    {
        private List<CCircle> Circles = new List<CCircle>();

        public void Add(CCircle circle)
        {
            Circles.Add(circle);
        }
        public void Remove(CCircle circle)
        {
            Circles.Remove(circle);
        }
        public void Clear()
        {
            
            Circles.Clear();
           
        }
        public void DrawAll(Graphics g)
        {
            foreach (CCircle circle in Circles)
            {
                circle.Draw(g);
            }
        }
    }
}
