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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private override void OnMouseDown(MouseEventArgs e)
        {

        }
        
    }
    public class CCircle
    {
        private int _x, _y, _radius;
        private bool _selected;
        public CCircle()
        {
            _x = 0;
            _y = 0;
            _radius = 0;
            _selected = false;
        }
        public CCircle(int x, int y, int radius, bool selected)
        {
            _x = x;
            _y = y;
            _radius = radius;
            _selected = selected;
        }
        public void Select(bool selected)
        {
            _selected = selected;
        }
        public void Draw(Graphics g)
        {
            Brush brush = Brushes.Red;
            g.FillEllipse(brush, _x, _y, _radius, _radius);
        }
        public class Box
        {
            List<CCircle> circles = new List<CCircle>();
            void Pushback(CCircle A)
            {
                circles.Add(A);
            }
        }
    }
}
