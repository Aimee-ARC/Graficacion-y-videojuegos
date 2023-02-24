using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _50Colision
{
    public partial class Form1 : Form
    {
        List<Pelota> pelotas = new List<Pelota>();
        Random rnd = new Random();
        private int pelotasAgregadas = 0;
        Bitmap bitmap;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AgregarPelota();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pelotasAgregadas < 50)
            {
                AgregarPelota();
                pelotasAgregadas++;
            }
            ActualizarPelotas();
        }



        private void AgregarPelota()
        {
            // Crear nueva pelota con valores aleatorios
            Pelota pelota = new Pelota();
            pelota.X = rnd.Next(pictureBox1.Width);
            pelota.Y = rnd.Next(pictureBox1.Height);
            pelota.VelocidadX = rnd.Next(30) - 5;
            pelota.VelocidadY = rnd.Next(30) - 5;
            pelota.Radio = rnd.Next(15, 25);

            // Agregar pelota a la lista
            pelotas.Add(pelota);
        }

        private void ActualizarPelotas()
        {
            // Limpiar dibujo anterior
            g.Clear(Color.Black);

            // Actualizar y dibujar cada pelota
            foreach (Pelota pelota in pelotas)
            {
                pelota.Actualizar(pictureBox1.ClientRectangle, pelotas);

                Brush brush = new SolidBrush(Color.FromArgb(226, 95, 190));
                g.FillEllipse(brush, pelota.X - pelota.Radio, pelota.Y - pelota.Radio, pelota.Radio * 2, pelota.Radio * 2);
            }

            // Actualizar imagen del PictureBox
            pictureBox1.Image = bitmap;
        }

        private void btnAgregarPelotas_Click(object sender, EventArgs e)
        {
            //esto era para agregar pelotas con un click
        }
    }

   
}
