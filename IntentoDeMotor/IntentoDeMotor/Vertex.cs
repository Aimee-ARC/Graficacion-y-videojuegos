using System;


namespace IntentoDeMotor
{
    public class Vertex
    {
        public Vertex(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public Vertex RotateX(int angle)
        {
            var rad = angle * Math.PI / 180;
            var cosa = Math.Cos(rad);
            var sina = Math.Sin(rad);
            var yn = (Y * cosa) - (Z * sina);
            var zn = (Y * sina) + (Z * cosa);
            return new Vertex(X, yn, zn);
        }

        public Vertex RotateY(int angle)
        {
            var rad = angle * Math.PI / 180;
            var cosa = Math.Cos(rad);
            var sina = Math.Sin(rad);
            var Zn = (Z * cosa) - (X * sina);
            var Xn = (Z * sina) + (X * cosa);
            return new Vertex(Xn, Y, Zn);
        }

        public Vertex RotateZ(int angle)
        {
            var rad = angle * Math.PI / 180;
            var cosa = Math.Cos(rad);
            var sina = Math.Sin(rad);
            var Xn = (X * cosa) - (Y * sina);
            var Yn = (X * sina) + (Y * cosa);
            return new Vertex(Xn, Yn, Z);
        }

        public Vertex Project(int viewWidth, int viewHeight, int fov, int viewDistance)
        {
            var factor = fov / (viewDistance + Z);
            var Xn = X * factor + viewWidth / 2;
            var Yn = -Y * factor + viewHeight / 2;
            return new Vertex(Xn, Yn, 0);
        }
    }
}
