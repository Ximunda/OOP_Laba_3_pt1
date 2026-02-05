using System;
using System.Collections.Generic;
using System.Drawing;
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
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool ctrl = (ModifierKeys & Keys.Control) == Keys.Control;
            if (e.Button == MouseButtons.Right)
            {
                CCircle circle = new CCircle(e.X, e.Y);
                container.Add(circle);
            }
            else if (e.Button == MouseButtons.Left)
            {
                container.OnMouseClick(e.X, e.Y, ctrl);
            }
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

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            keys_label.Text = "Key pressed: " + e.KeyCode.ToString();
            if (e.KeyCode == Keys.Delete)
            {
                container.RemoveSelected();
                Invalidate();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            lbXcord.Text = e.X.ToString();
            lbYcord.Text = e.Y.ToString();
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
            Radius = 30;
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
            else
            {
                Circle_color = Color.Black;
            }
            using (Pen pen = new Pen(Circle_color, 2))
            {
                g.DrawEllipse(pen, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            }
        }
        public void SetSelected(bool value)
        {
            Selected = value;
        }
        public bool IsSelected()
        {
            return Selected;
        }
        public bool IsClicked(int mx, int my)
        {
            int dx = mx - X;
            int dy = my - Y;
            bool result = ((dx * dx) + (dy * dy)) <= (Radius * Radius);
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
        public void ClearSelection()
        {
            foreach (CCircle c in Circles)
            {
                c.SetSelected(false);
            }
        }
        public void OnMouseClick(int x, int y, bool ctrlPressed)
        {
            bool ALOS_flag = false; // (At Least One Selected - flag)
            if (!ctrlPressed)
            {
                ClearSelection();
            }
            foreach (CCircle c in Circles)
            {
                if (c.IsClicked(x, y))
                {
                    ALOS_flag = true;
                    c.SetSelected(true);
                    break; // break значит что выделятся на пересечении будет только один более старший объект
                }
            }

            if (!ALOS_flag && !ctrlPressed)
            {
                ClearSelection();
            }
        }
        public void RemoveSelected()
        {
            Circles.RemoveAll(c => c.IsSelected());
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
