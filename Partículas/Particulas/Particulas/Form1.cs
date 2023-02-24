using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particulas
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics g;
        Emisor emisor;
        

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bitmap);
            emisor = new Emisor(pictureBox1.Width, pictureBox1.Height, 20, 20); //aqui cambiamos la posicion del emisor 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.Black); // Limpiar el PictureBox para dibujar las nuevas partículas
            emisor.Actualizar();
            emisor.Dibujar(g);
            pictureBox1.Image = bitmap;
        }
    }
    
}
