using System;
using System.Drawing;
using System.Windows.Forms;

namespace IntentoDeMotor
{
    public partial class Form1 : Form
    {
        public Pen pen = new Pen(Color.Red);
        public Timer _timer = new Timer() { Interval = 40 };
        public Vertex[] _vertices;
        public int[,] _faces;
        public int _angle;
        public Scene _scene;

        public Form1()
        {
            InitializeComponent();

            _timer.Tick += timer1_Tick;
            _timer.Start();

            InitCube();
            _scene = new Scene(new Figure(_vertices, _faces));

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            _scene.Draw(g, ClientSize.Width, ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();

            _angle++;


        }
        private void WireframeCubeForm_Load(object sender, EventArgs e)
        {
            InitCube();

            _timer.Start();
        }

        private void InitCube()
        {
            _vertices = new Vertex[]
            {
                new Vertex(-1, 1, -1),
                new Vertex(1, 1, -1),
                new Vertex(1, -1, -1),
                new Vertex(-1, -1, -1),
                new Vertex(-1, 1, 1),
                new Vertex(1, 1, 1),
                new Vertex(1, -1, 1),
                new Vertex(-1, -1, 1)
            };

            // Create an array representing the 6 faces of a cube.Each face is composed by indices to the vertex array

            _faces = new int[,]
            {
                {
                    0, 1, 2, 3
                },
                {
                    1, 5, 6, 2
                },
                {
                    5, 4, 7, 6
                },
                {
                    4, 0, 3, 7
                },
                {
                    0, 4, 5, 1
                },
                {
                    3, 2, 6, 7
                }
            };
        }

        
    }
    

   
   

    

    

}

