using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Particulas
{
    public class Emisor
    {
        private List<Particula> particulas;
        private Random random;
        private int ancho, alto;
        private float emisorX, emisorY;

        public Emisor(int ancho, int alto, float emisorX, float emisorY)
        {
            particulas = new List<Particula>();
            random = new Random();
            this.ancho = ancho;
            this.alto = alto;
            this.emisorX = emisorX;
            this.emisorY = emisorY;
        }

        public void Actualizar()
        {
            // Actualizar la posición de cada partícula
            foreach (Particula p in particulas)
            {
                p.Actualizar();
            }

            // Agregar nuevas partículas al azar
            for (int i = 0; i < 5; i++) //el numero agrega particulas por actualizacion
            {
                float vx = (float)random.NextDouble() * 10 - 1; // Velocidades 
                float vy = (float)random.NextDouble() * (10) - 1;
                float tamaño = (float)random.NextDouble() * 10 + 5; // Tamaños aleatorios entre 5 y 15
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Colores aleatorios
                particulas.Add(new Particula(emisorX, emisorY, vx, vy, tamaño, color));
            }

            // Eliminar las partículas que salen de la pantalla
            particulas.RemoveAll(p => p.x < 0 || p.x > ancho || p.y < 0 || p.y > alto);
        }

        public void Dibujar(Graphics g)
        {
            // Dibujar cada partícula como un círculo
            foreach (Particula p in particulas)
            {
                Brush brush = new SolidBrush(p.color);
                g.FillEllipse(brush, p.x - p.tamaño / 2, p.y - p.tamaño / 2, p.tamaño, p.tamaño);
            }
        }
    }
}
