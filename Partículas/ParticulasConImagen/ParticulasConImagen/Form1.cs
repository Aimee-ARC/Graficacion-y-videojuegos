using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParticulasConImagen
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        Emisor emisor;
        
        Bitmap fondo = Resource1.fondo;
        

        public Form1()
        {

            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            emisor = new Emisor(pictureBox1.Width, pictureBox1.Height, 50, 400); //aqui cambiamos la posicion del emisor 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.DrawImage(fondo, 0, 0, pictureBox1.Width, pictureBox1.Height); //aqui ponemos el fondo 
            emisor.Actualizar();
            emisor.Dibujar(g);
            
            pictureBox1.Image = bitmap;
        }
    } 

}
