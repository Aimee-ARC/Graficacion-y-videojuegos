using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using LYB;

namespace VideojuegosPNo2
{
    public class VPoint
    {
        bool isPinned = false;
        bool fromBody = false;       
        Vec2 pos, old, vel, gravity;
        int id;
        public float Mass;
        float radius, bounce, diameter, m, frict = 0.99f;
        float groundFriction = 0.9f;
        Color c;
        SolidBrush brush;
        Bitmap ball, fire;
        int count = 1;


        public bool FromBody
        {
            get { return fromBody; }
            set { fromBody = value; }
        }
        public float Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public bool IsPinned
        {
            get { return isPinned; }
            set { isPinned = value; }
        }
        public float X
        {
            get { return pos.X; }
            set { pos.X = value; }
        }
        public float Y
        {
            get { return pos.Y; }
            set { pos.Y = value; }
        }
        public Vec2 Pos
        {
            get { return pos; }
            set { pos = value; }
        }
        public Vec2 Old
        {
            get { return old; }
            set { old = value; }
        }
        public float Radius
        {
            get { return radius; }
            set { radius = value; diameter = radius + radius; }
        }

        public VPoint(int x, int y)
        {
            this.id = -1;
            Init(x, y, 0, 0);
        }
        public VPoint(int x, int y, int id, bool Pinned)
        {
            this.id = id;
            isPinned = Pinned;
            Init(x, y, 0, 0);

        }
        public VPoint(int x, int y, int id)
        {
            this.id = id;
            Init(x, y, 0, 0);
        }
        public VPoint(int x, int y, int id, bool Pinned, int redio)
        {
            this.id = id;
            isPinned = Pinned;
            Init(x, y, 0, 0, redio);
            
        }

       
        public VPoint(int x, int y, float vx, float vy, int id,bool Pinned)
        {
            this.id = id;
            
            Init(x, y, vx, vy);           
        }

        public VPoint(int x, int y, int id, bool Pinned, int redio, Vec2 gravedad)
        {
            this.id = id;
            isPinned = Pinned;
            Init(x, y, 0, 0, redio, gravedad);

        }

        public VPoint(int x, int y, float vx, float vy,int id)
        {
            this.id = id;
            Init(x, y, vx, vy);
        }

        private void Init(int x, int y, float vx, float vy)
        {
            pos         = new Vec2(x, y);
            old         = new Vec2(x , y );
            gravity     = new Vec2(0, 2);//
            vel         = new Vec2(vx, vy);
            radius      = 25;
            diameter    = radius + radius;
            Mass        = 0.5f;
            bounce      = 0.001f;
            c = Color.OrangeRed;
            brush = new SolidBrush(c);
            if (IsPinned)
            {
                Pin();
            }
        }
        public static float Distance1(VPoint a, VPoint b)
        {
            return (float)Math.Sqrt(Math.Pow(b.pos.X - a.pos.X, 2) + Math.Pow(b.pos.Y - a.pos.Y, 2));
        }

        private void Init(int x, int y, float vx, float vy, int radio)
        {
            pos = new Vec2(x, y);
            old = new Vec2(x, y);
            gravity = new Vec2(0, 2);//
            vel = new Vec2(vx, vy);
            radius = radio;
            diameter = radius + radius;
            Mass = 0.5f;
            bounce = 0.001f;
            c = Color.OrangeRed;
            brush = new SolidBrush(c);
            if (IsPinned)
            {
                Pin();
            }
        }

        private void Init(int x, int y, float vx, float vy, int radio, Vec2 grav)
        {
            pos = new Vec2(x, y);
            old = new Vec2(x, y);
            gravity = grav;
            vel = new Vec2(vx, vy);
            radius = radio;
            diameter = radius + radius;
            Mass = 0.5f;
            bounce = 0.001f;
            c = Color.OrangeRed;
            brush = new SolidBrush(c);
            if (IsPinned)
            {
                Pin();
            }
        }



        public void Pin()
        {
            brush = new SolidBrush(Color.Gray);
            radius = 10;
            diameter = radius + radius;
            isPinned = true;
        }

        public void Update(int width, int height)
        {
            
            if (isPinned)
                return;//*/

            vel = ((pos - old) *  frict)/1.1f;
            /*
            if (pos.Y >= height - radius && vel.MagSqr() > 0.000001)//en el piso
            {
                m   = vel.Length();
                vel /= m;
                vel *= (m * groundFriction);
            }//*/
            
            old = pos;
            pos += vel + gravity;
        }

        public void Constraints(int width, int height)
        {
            if (pos.X > width - radius)     { pos.X = width - radius;   old.X = (pos.X + vel.X); }
            if (pos.X < radius)             { pos.X = radius;           old.X = (pos.X + vel.X) ; }
            if (pos.Y > height - radius)    { pos.Y = height - radius;  old.Y = (pos.Y + vel.Y) ; }
            if (pos.Y < radius)             { pos.Y = radius;           old.Y = (pos.Y + vel.Y) ; }
        }

        public void Render(Graphics g, int width, int height)
        {
            if (fromBody)
                return;

            Update(width, height);
            Constraints(width, height);
            count += count;
            if (id == 37612)
            {

            }
            else if (id == 37613)
            {
                if(count == 2)
                {
                    ball = new Bitmap(Resource1.ball);
                }
                g.DrawImage(ball, pos.X - radius, pos.Y - radius, diameter, diameter);

            }
       
            else
            {
                if (count == 2)
                {
                    fire = new Bitmap(Resource1.fire);
                }
                g.DrawImage(fire, pos.X - radius, pos.Y - radius, diameter, diameter);

            }
        }


        public override string ToString()
        {
            return "ID: "+id+" : "+pos.ToString();
        }

    }
}
