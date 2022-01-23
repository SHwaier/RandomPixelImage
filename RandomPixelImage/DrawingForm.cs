using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPixelImage
{
    public partial class DrawingForm : Form
    {
        public DrawingForm()
        {
            InitializeComponent();
        }

        private void DrawingForm_Load(object sender, EventArgs e)
        {
        }

        private void DrawingForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

            // Create points that define curve.
            Point point1 = new Point(0, 0);
            Point point2 = new Point(1200, 500);
            Point point3 = new Point(200, 5);
            Point point4 = new Point(250, 50);
            Point point5 = new Point(300, 100);
            Point point6 = new Point(350, 200);
            Point point7 = new Point(250, 250);
            Point[] curvePoints = { point3, point1, point2 };

            // Draw lines between original points to screen.
            //e.Graphics.DrawLines(p, curvePoints);

            // Draw curve to screen.
            e.Graphics.DrawCurve(p, curvePoints);

        }
    }
}
