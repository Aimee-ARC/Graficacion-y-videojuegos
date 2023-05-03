using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animacion_3D
{
    public class Transform
    {
        public Matrix Mtx;
        public int time;
        public Transform(Matrix mtx, int time)
        {
            this.Mtx = mtx;
            this.time = time;
        }
    }
}
