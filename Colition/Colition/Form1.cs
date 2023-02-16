using System;
using System.Drawing;
using System.Windows.Forms;

namespace Colition
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        private Graphics g;
        private Circle circle1, circle2, circle3, circle4, circle5;
        private Timer timer;

        public Form1()
        {

            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);

            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, e.ClipRectangle);

            if (circle1 != null && circle2 != null && circle3 != null && circle4 != null && circle5 != null)
            {
                circle1.Draw(g);
                circle2.Draw(g);
                circle3.Draw(g);
                circle4.Draw(g);
                circle5.Draw(g);
            }


            e.Graphics.DrawImage(bmp, Point.Empty);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

 
            if (circle1 == null)
            {
                Random rand = new Random();
                int radius = rand.Next(20, 50);
                Color randomColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                Brush fillColor = new SolidBrush(randomColor);

                int x = 132;
                int y = 100;
                int vx = rand.Next(-10, 10);
                int vy = rand.Next(-10, 10);
                circle1 = new Circle(x, y, radius, fillColor, vx, vy);
            }

            if (circle2 == null)
            {
                Random rand2 = new Random();
                int randomValue = rand2.Next();
                int randomValuePlus50 = randomValue + 50;
                int radius = rand2.Next(20, 50);
                Color randomColor = Color.FromArgb(rand2.Next(256), rand2.Next(256), rand2.Next(256));
                Brush fillColor = new SolidBrush(randomColor);

                int x = 265;
                int y = 200;
                int vx = rand2.Next(-10, 10);
                int vy = rand2.Next(-10, 10);
                circle2 = new Circle(x, y, radius, fillColor, vx, vy);
            }

            if (circle3 == null)
            {
                Random rand3 = new Random();
                int randomValue = rand3.Next();
                int randomValuePlus50 = randomValue - 50;
                int radius = rand3.Next(20, 50);
                Color randomColor = Color.FromArgb(rand3.Next(256), rand3.Next(256), rand3.Next(256));
                Brush fillColor = new SolidBrush(randomColor);

                int x = 397;
                int y = 300;
                int vx = rand3.Next(-10, 10);
                int vy = rand3.Next(-10, 10);
                circle3 = new Circle(x, y, radius, fillColor, vx, vy);
            }

            if (circle4 == null)
            {
                Random rand4 = new Random();
                int radius = rand4.Next(20, 50);
                Color randomColor = Color.FromArgb(rand4.Next(256), rand4.Next(256), rand4.Next(256));
                Brush fillColor = new SolidBrush(randomColor);

                int x = 530;
                int y = 400;
                int vx = rand4.Next(-10, 10);
                int vy = rand4.Next(-10, 10);
                circle4 = new Circle(x, y, radius, fillColor, vx, vy);
            }
            if (circle5 == null)
            {
                Random rand5 = new Random();
                int radius = rand5.Next(20, 50);
                Color randomColor = Color.FromArgb(rand5.Next(256), rand5.Next(256), rand5.Next(256));
                Brush fillColor = new SolidBrush(randomColor);

                int x = 300;
                int y = 400;
                int vx = rand5.Next(-10, 10);
                int vy = rand5.Next(-10, 10);
                circle5 = new Circle(x, y, radius, fillColor, vx, vy);
            }


            circle1.Update(pictureBox1.Width, pictureBox1.Height);
            circle2.Update(pictureBox1.Width, pictureBox1.Height);
            circle3.Update(pictureBox1.Width, pictureBox1.Height);
            circle4.Update(pictureBox1.Width, pictureBox1.Height);
            circle5.Update(pictureBox1.Width, pictureBox1.Height);

            // Check for collision 1 and 2
            double distance = Math.Sqrt((circle1.X - circle2.X) * (circle1.X - circle2.X) + (circle1.Y - circle2.Y) * (circle1.Y - circle2.Y));

            if (distance <= circle1.Radius + circle2.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle1.VelocityX;
                int tempVy = circle1.VelocityY;
                circle1.VelocityX = circle2.VelocityX;
                circle1.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }

            //chechh circle 1 and 3
            double distance1 = Math.Sqrt((circle3.X - circle1.X) * (circle3.X - circle1.X) + (circle3.Y - circle1.Y) * (circle3.Y - circle1.Y));
            if (distance1 <= circle3.Radius + circle1.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle3.VelocityX;
                int tempVy = circle3.VelocityY;
                circle3.VelocityX = circle1.VelocityX;
                circle3.VelocityY = circle1.VelocityY;
                circle1.VelocityX = tempVx;
                circle1.VelocityY = tempVy;
            }

            // Check for collision between 3 and 2
            double distance2 = Math.Sqrt((circle3.X - circle2.X) * (circle3.X - circle2.X) + (circle3.Y - circle2.Y) * (circle3.Y - circle2.Y));
            if (distance2 <= circle3.Radius + circle2.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle3.VelocityX;
                int tempVy = circle3.VelocityY;
                circle3.VelocityX = circle2.VelocityX;
                circle3.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }

            //chechh circle 4 and 1
            double distance3 = Math.Sqrt((circle4.X - circle1.X) * (circle4.X - circle1.X) + (circle4.Y - circle1.Y) * (circle4.Y - circle1.Y));
            if (distance3 <= circle4.Radius + circle1.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle4.VelocityX;
                int tempVy = circle4.VelocityY;
                circle4.VelocityX = circle1.VelocityX;
                circle4.VelocityY = circle1.VelocityY;
                circle1.VelocityX = tempVx;
                circle1.VelocityY = tempVy;
            }

            // Check for 4 and 2
            double distance4 = Math.Sqrt((circle4.X - circle2.X) * (circle4.X - circle2.X) + (circle4.Y - circle2.Y) * (circle4.Y - circle2.Y));
            if (distance4 <= circle4.Radius + circle2.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle4.VelocityX;
                int tempVy = circle4.VelocityY;
                circle4.VelocityX = circle2.VelocityX;
                circle4.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }
            // Check for 4 and 3
            double distance5 = Math.Sqrt((circle4.X - circle3.X) * (circle4.X - circle3.X) + (circle4.Y - circle3.Y) * (circle4.Y - circle3.Y));
            if (distance5 <= circle4.Radius + circle3.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle4.VelocityX;
                int tempVy = circle4.VelocityY;
                circle4.VelocityX = circle3.VelocityX;
                circle4.VelocityY = circle3.VelocityY;
                circle3.VelocityX = tempVx;
                circle3.VelocityY = tempVy;
            }

            //chechh 5 and 1
            double distance6 = Math.Sqrt((circle5.X - circle1.X) * (circle5.X - circle1.X) + (circle5.Y - circle1.Y) * (circle5.Y - circle1.Y));
            if (distance6 <= circle5.Radius + circle1.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle1.VelocityX;
                circle5.VelocityY = circle1.VelocityY;
                circle1.VelocityX = tempVx;
                circle1.VelocityY = tempVy;
            }

            // Check for 5 and 2
            double distance7 = Math.Sqrt((circle5.X - circle2.X) * (circle5.X - circle2.X) + (circle5.Y - circle2.Y) * (circle5.Y - circle2.Y));
            if (distance7 <= circle5.Radius + circle2.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle2.VelocityX;
                circle5.VelocityY = circle2.VelocityY;
                circle2.VelocityX = tempVx;
                circle2.VelocityY = tempVy;
            }
            // Check 5 and 3
            double distance8 = Math.Sqrt((circle5.X - circle3.X) * (circle5.X - circle3.X) + (circle5.Y - circle3.Y) * (circle5.Y - circle3.Y));
            if (distance8 <= circle5.Radius + circle3.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle3.VelocityX;
                circle5.VelocityY = circle3.VelocityY;
                circle3.VelocityX = tempVx;
                circle3.VelocityY = tempVy;
            }

            // Check for 5 and 4
            double distance9 = Math.Sqrt((circle5.X - circle4.X) * (circle5.X - circle4.X) + (circle5.Y - circle4.Y) * (circle5.Y - circle4.Y));
            if (distance9 <= circle5.Radius + circle4.Radius)
            {
                // Swap velocities to simulate a bounce
                int tempVx = circle5.VelocityX;
                int tempVy = circle5.VelocityY;
                circle5.VelocityX = circle4.VelocityX;
                circle5.VelocityY = circle4.VelocityY;
                circle4.VelocityX = tempVx;
                circle4.VelocityY = tempVy;
            }



            // Draw the background color to erase the previous circles
            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillRectangle(brush, pictureBox1.ClientRectangle);
            }

            // Draw the current circles
            circle1.Draw(g);
            circle2.Draw(g);
            circle3.Draw(g);
            circle4.Draw(g);
            circle5.Draw(g);

            // Update the picture box with the new image
            pictureBox1.Image = bmp;
        }
    }

   
}
