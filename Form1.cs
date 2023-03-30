using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideojuegosPNo2
{
    public partial class Form1 : Form
    {
        Canvas canvas;
        List<VPoint> balls;
        VRope liana1;
        VRope rope;
        VRope cuerda;
        List<VBox> boxes;
        List<BadBox> obstaculos;
        VSolver solver;
        Point mouse, trigger;
        bool isMouseDown,isRightButton;
        int ballId;
        private Vec2 gravity;
        int idBall;

       
        public Form1()
        {
            InitializeComponent();
        }

        private void Init()
        {
            Random rand = new Random();
            canvas              = new Canvas(PCT_CANVAS.Size);
            PCT_CANVAS.Image    = canvas.bmp;
            balls              = new List<VPoint>();
            boxes               = new List<VBox>();
            obstaculos = new List<BadBox>();
            solver              = new VSolver(balls);
            
            //cuerdas?           
            rope = new VRope(Width/12, Height/8,37, 37, balls.Count, 0.005f);
            balls.AddRange(rope.pts);

            //pelotita magica inicial wuuu
            for (int i = 0; i < 1; i++)
                balls.Add(new VPoint(30, 200, 37613));

            //pelotita de ayuda
            balls.Add(new VPoint(Width- 100, 200, balls.Count, false, 33));
           
            //paredes stompers
            for (int b = 0; b < 50; b++)//stompers265
                balls.Add(new VPoint(100 , (Height - (b * 16)), 37612 , true));
            for (int b = 4; b < 85; b++)
                balls.Add(new VPoint(((Width + 100) - (b * 17)), Height / 23, 37612, true));

            for (int b = 4; b < 85; b++)
                balls.Add(new VPoint((Width - (b * 17)), Height/7, 37612, true));

            for (int b = 0; b < 70; b++)
                balls.Add(new VPoint((Width - (b *18)), ((Height /2) - 100), 37612, true));

            for(int b = 15; b < 70; b++)
                balls.Add(new VPoint((Width - (b * 21)),( (Height -210) - b*4), 37612, true));

            for (int b = 0; b < 70; b++)
                balls.Add(new VPoint((Width - (b * 20)), ((Height -90) - 100), 37612, true));

            for (int b = 0; b < 70; b++)
                balls.Add(new VPoint((Width - (b * 18)), ((Height / 2) - 100), 37612, true));

            for (int b = 0; b < 17; b++)
                balls.Add(new VPoint(Width -250, ((Height-200) - (b * 20)), 37612, true));

            for (int b = 8; b < 75; b++)
                balls.Add(new VPoint(((Width - 180) - (b * 17)), Height - 260, 37612, true));



            //topes
            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 200, ((Height - 540) - (b * 3)), 37612, true));
            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 400, ((Height - 540) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 600, ((Height - 540) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 800, ((Height - 540) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 1000, ((Height - 540) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 1200, ((Height - 540) - (b * 3)), 37612, true));



            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(170, ((Height - 130 ) - (b * 3)), 37612, true));
            // topes arriba

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 300, ((Height - 660) - (b * 3)), 37612, true));
            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 500, ((Height - 660) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 700, ((Height - 660) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 900, ((Height - 660) - (b * 3)), 37612, true));

            for (int b = 0; b < 15; b++)
                balls.Add(new VPoint(Width - 1100, ((Height - 660) - (b * 3)), 37612, true));

           
            // elevador 
            boxes.Add(new VBox(50, 600, 40, 40, balls.Count));
            balls.Add(boxes[boxes.Count - 1].a);
            balls.Add(boxes[boxes.Count - 1].b);
            balls.Add(boxes[boxes.Count - 1].c);
            balls.Add(boxes[boxes.Count - 1].d);

            //obstaculos
            
            obstaculos.Add(new BadBox(600, 385, 30, 90, balls.Count));
            balls.Add(obstaculos[obstaculos.Count - 1].a);
            balls.Add(obstaculos[obstaculos.Count - 1].b);
            balls.Add(obstaculos[obstaculos.Count - 1].c);
            balls.Add(obstaculos[obstaculos.Count - 1].d);

            obstaculos.Add(new BadBox(800, 405, 30, 120, balls.Count));
            balls.Add(obstaculos[obstaculos.Count - 1].a);
            balls.Add(obstaculos[obstaculos.Count - 1].b);
            balls.Add(obstaculos[obstaculos.Count - 1].c);
            balls.Add(obstaculos[obstaculos.Count - 1].d);

            obstaculos.Add(new BadBox(1000, 420, 30, 160, balls.Count));
            balls.Add(obstaculos[obstaculos.Count - 1].a);
            balls.Add(obstaculos[obstaculos.Count - 1].b);
            balls.Add(obstaculos[obstaculos.Count - 1].c);
            balls.Add(obstaculos[obstaculos.Count - 1].d);

            obstaculos.Add(new BadBox(1200, 445, 30, 200, balls.Count));
            balls.Add(obstaculos[obstaculos.Count - 1].a);
            balls.Add(obstaculos[obstaculos.Count - 1].b);
            balls.Add(obstaculos[obstaculos.Count - 1].c);
            balls.Add(obstaculos[obstaculos.Count - 1].d);
            /*
            boxes.Add(new VBox(rand.Next(0, 30), rand.Next(50, 60), rand.Next(40, 60), rand.Next(40, 60), balls.Count));
            balls.Add(boxes[boxes.Count - 1].a);
            balls.Add(boxes[boxes.Count - 1].b);
            balls.Add(boxes[boxes.Count - 1].c);
            balls.Add(boxes[boxes.Count - 1].d);//*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Init();
        }

        private void BTN_EXE_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void PCT_CANVAS_MouseClick(object sender, MouseEventArgs e)
        {
             
        }

        private void PCT_CANVAS_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;

            isRightButton = (e.Button == MouseButtons.Right);
            if (isRightButton)
                trigger = e.Location;

            mouse = e.Location;
        }

        private void PCT_CANVAS_MouseMove(object sender, MouseEventArgs e)
        {         
            if (isMouseDown && ballId != 37612 && ballId != 37613)
            {
                if (e.Button == MouseButtons.Left)//MOVE BALL TO POINTER
                {
                    
                    mouse = e.Location;
                    if (ballId > -1)
                    {
                        balls[ballId].Pos.X = e.Location.X;
                        balls[ballId].Pos.Y = e.Location.Y;

                        balls[ballId].Old = balls[ballId].Pos;
                    }
                }
                else
                    trigger = e.Location;
            }
        }

        private void PCT_CANVAS_Click(object sender, EventArgs e)
        {

        }

        private void PNL_HEADER_Paint(object sender, PaintEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            gravity = new Vec2(-1, 0);
            
            balls.Add(new VPoint(Width -300, Height - 220, balls.Count, false, 10, gravity));

        }


        private void PCT_CANVAS_MouseUp(object sender, MouseEventArgs e)
        { /*
            isMouseDown = false;
            if (e.Button == MouseButtons.Right && ballId != -1)
            {
                balls[ballId].Old.X = e.Location.X;
                balls[ballId].Old.Y = e.Location.Y;
                LBL_STATUS.Text = "FIRE !!!";               
            }

            ballId = -1;+*/
        }
        private void TIMER_Tick(object sender, EventArgs e)
        {

            canvas.LessFast();
            bool win = false;

            ballId = solver.Update(canvas.g, canvas.Width, canvas.Height, mouse, isMouseDown);
      
            if(rope!=null)
                rope.Update(canvas.g, canvas.Width, canvas.Height);


            for (int b = 0; b < boxes.Count; b++)
                boxes[b].React(canvas.g, balls, PCT_CANVAS.Width, PCT_CANVAS.Height);//*/   
            for (int b = 0; b < obstaculos.Count; b++)
                obstaculos[b].React(canvas.g, balls, PCT_CANVAS.Width, PCT_CANVAS.Height);//*/   

            /*if (isMouseDown && isRightButton && ballId != -1)
                canvas.g.DrawLine(Pens.Green, balls[ballId].X, balls[ballId].Y, trigger.X, trigger.Y);*/

          
            PCT_CANVAS.Invalidate();
        }


    }
}
