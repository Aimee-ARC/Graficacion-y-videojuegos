using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50Colision
{
    public class Pelota
    {
        public int X { get; set; } // posición horizontal
        public int Y { get; set; } // posición vertical
        public int VelocidadX { get; set; } // velocidad horizontal
        public int VelocidadY { get; set; } // velocidad vertical
        public int Radio { get; set; } // tamaño de la pelota



        public void Actualizar(RectangleF limites, List<Pelota> pelotas)
        {
            // Actualizar posición
            X += VelocidadX;
            Y += VelocidadY;

            // Comprobar colisiones con el borde de la ventana
            if (X < limites.Left + Radio || X > limites.Right - Radio)
            {
                VelocidadX = -VelocidadX;
            }
            if (Y < limites.Top + Radio || Y > limites.Bottom - Radio)
            {
                VelocidadY = -VelocidadY;
            }

            // Comprobar colisiones con otras pelotas
            foreach (Pelota otra in pelotas)
            {
                if (otra == this) continue;

                int dx = otra.X - X;
                int dy = otra.Y - Y;
                int distancia = (int)Math.Sqrt(dx * dx + dy * dy);

                if (distancia < Radio + otra.Radio)
                {
                    // Calcular nueva velocidad para ambas pelotas
                    int nuevaVelocidadX = (VelocidadX * (Radio - otra.Radio) + (2 * otra.Radio * otra.VelocidadX)) / (Radio + otra.Radio);
                    int nuevaVelocidadY = (VelocidadY * (Radio - otra.Radio) + (2 * otra.Radio * otra.VelocidadY)) / (Radio + otra.Radio);
                    int otraNuevaVelocidadX = (otra.VelocidadX * (otra.Radio - Radio) + (2 * Radio * VelocidadX)) / (Radio + otra.Radio);
                    int otraNuevaVelocidadY = (otra.VelocidadY * (otra.Radio - Radio) + (2 * Radio * VelocidadY)) / (Radio + otra.Radio);

                    VelocidadX = nuevaVelocidadX;
                    VelocidadY = nuevaVelocidadY;
                    otra.VelocidadX = otraNuevaVelocidadX;
                    otra.VelocidadY = otraNuevaVelocidadY;

                    // Mover pelotas para que no se superpongan
                    int distanciaMovimiento = Radio + otra.Radio - distancia;
                    int movX = distanciaMovimiento * dx / distancia;
                    int movY = distanciaMovimiento * dy / distancia;

                    X -= movX;
                    Y -= movY;
                    otra.X += movX;
                    otra.Y += movY;
                }
            }
        }
    }
}
