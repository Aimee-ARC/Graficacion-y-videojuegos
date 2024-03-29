﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animacion_3D
{
    public class Camera
    {
        public Vertex position;
        public Matrix orientation;
        public List<Plane> clipping_planes;

        public Camera(Vertex position, Matrix orientation)
        {
            this.position = position;
            this.orientation = orientation;
            this.clipping_planes = new List<Plane>();
        }

        public override string ToString()
        {
            return position.ToString();
        }
    }
}
