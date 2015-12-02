using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xwingSummative
{
    public partial class Form1 : Form
    {


        Graphics g;


        public Form1()
        {
            InitializeComponent();

            g = this.CreateGraphics();


        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Xwing(0, 0, 170, 170);
        }
        private void Xwing(float x, float y, float width, float height)
        {
            float scale = width / 170;
            float scaley = height / 170;

            Pen drawPen = new Pen(Color.White, 3);
            //g.DrawRectangle(drawPen, 0, 0, 200, 50);
            g.DrawLine(drawPen, x + (5 * scale), y + (40 * scaley), x + (175 * scale), y + (40 * scaley));
            g.DrawLine(drawPen, x + (5 * scale), y + (40 * scaley), x + (20 * scale), y + (20 * scaley));
            g.DrawLine(drawPen, x + (20 * scale), y + (20 * scaley), x + (20 * scale), y + (32 * scaley));
            g.DrawLine(drawPen, x + (20 * scale), y + (32 * scaley), x + (170 * scale), y + (5 * scaley));
            g.DrawArc(drawPen, x + (155 * scale), y + (5 * scaley), 30 * scale, 35 * scaley, 270, 180);

        }
    }
}
