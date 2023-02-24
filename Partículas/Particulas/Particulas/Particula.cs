using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particulas
{
    public class Particula
    {
        public float x, y;
        public float vx, vy;
        public float tamaño;
        public Color color;
        public int vida; // Nueva propiedad vida

        public Particula(float x, float y, float vx, float vy, float tamaño, Color color)
        {
            this.x = x;
            this.y = y;
            this.vx = vx;
            this.vy = vy;
            this.tamaño = tamaño;
            this.color = color;

        }

        public void Actualizar()
        {
            // Actualizar la posición de la partícula según su velocidad
            x += vx;
            y += vy;
        }
    }

}
