using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_3
{

    public partial class Form1 : Form
    {


        Bitmap bmp;
        Graphics g;
        

        Point a = new Point(0, 0);
        Point b = new Point(0, 100);
        Point c = new Point(100, 100);
        Point d = new Point(100, 0);

        

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            int squareSize = 70;
            float rotation = float.Parse(textBox1.Text);
            g.Clear(Color.Black);

            //drawing the axis
            g.DrawLine(Pens.Red, centerX, 0, centerX, pictureBox1.Height);
            g.DrawLine(Pens.Red, 0, centerY, pictureBox1.Width, centerY);

            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(-rotation);
            g.TranslateTransform(-centerX, -centerY);

            //drawing the square
            g.DrawRectangle(Pens.White, centerX - squareSize / 2, centerY - squareSize / 2, squareSize, squareSize);
            g.ResetTransform();
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            int squareSize = 70;
            float rotation = float.Parse(textBox1.Text);
            g.Clear(Color.Black);

            //drawing the axis
            g.DrawLine(Pens.Red, centerX, 0, centerX, pictureBox1.Height);
            g.DrawLine(Pens.Red, 0, centerY, pictureBox1.Width, centerY);

            //Translate the origin to lower left corner of the square
            g.TranslateTransform(centerX , centerY);

            //Rotate the square counter-clockwise
            g.RotateTransform(-rotation);

            //drawing the square
            g.DrawRectangle(Pens.White, 0, -squareSize, squareSize, squareSize);
            g.ResetTransform();
            pictureBox1.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int centerX = pictureBox1.Width / 2;
            int centerY = pictureBox1.Height / 2;
            int squareSize = 70;
            int ncx = centerX + (squareSize/2) ;
            int ncy =centerY - (squareSize / 2);
            
            float rotation = float.Parse(textBox1.Text);
            g.Clear(Color.Black);

            //drawing the axis
            g.DrawLine(Pens.Red, centerX, 0, centerX, pictureBox1.Height);
            g.DrawLine(Pens.Red, 0, centerY, pictureBox1.Width, centerY);

            g.TranslateTransform(ncx, ncy);
            g.RotateTransform(-rotation);
            g.TranslateTransform(-ncx, -ncy);

            //drawing the square
            g.DrawRectangle(Pens.White, ncx - squareSize / 2, ncy - squareSize / 2, squareSize, squareSize);
            g.ResetTransform();
            pictureBox1.Refresh();
        }
    }
}
