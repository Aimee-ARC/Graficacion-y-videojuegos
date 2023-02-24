using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticulasConImagen
{
    public class Emisor
    {
        private List<Particula> particulas;
        private Random random;
        private int ancho, alto;
        private float emisorX, emisorY;

        // Cargar la imagen desde el archivo png
        Bitmap nayan = Resource1.Nyan_Cat_PNG_Transparent;



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
            for (int i = 0; i < 2; i++) //el numero agrega particulas por actualizacion
            {
                float vx = (float)random.NextDouble() * (60) - 1; // Velocidades aleatorias entre -1 y 1
                float vy = (float)random.NextDouble() * (-8) - 1;
                float tamaño = (float)random.NextDouble() * 150 + 5; // Tamaños aleatorios entre 5 y 15
                Color color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)); // Colores aleatorios
                particulas.Add(new Particula(emisorX, emisorY, vx, vy, tamaño, color));
            }

            // Eliminar las partículas que salen de la pantalla
            particulas.RemoveAll(p => p.x < 0 || p.x > ancho || p.y < 0 || p.y > alto);
        }

        public void Dibujar(Graphics g)
        {
            // Dibujar cada partícula como una imagen
            foreach (Particula p in particulas)
            {
                g.DrawImage(nayan, p.x - p.tamaño / 2, p.y - p.tamaño / 2, p.tamaño, p.tamaño);
            }

        }
    }
}
