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
        public mainForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
    public class CCircle
    {
        private int _radius;
        private int _x;
        private int _y;
        public CCircle(int radius, int x, int y)
        {
            _radius = radius;
            _x = x;
            _y = y;
        }
        public void draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color.Black))
            {
                g.FillEllipse(brush, _x - _radius, _y - _radius, _radius * 2, _radius * 2);
            }
        }
    }
}
