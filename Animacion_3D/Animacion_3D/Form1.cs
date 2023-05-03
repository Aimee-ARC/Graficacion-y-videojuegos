using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animacion_3D
{
    public partial class Form1 : Form
    {
        Rasterization raster;
        Random random;

        int modelIndex;
        bool animate;
        int initialFrame;
        int finalFrame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            random = new Random();
            animate = false;
            initialFrame = -1;
            finalFrame = -1;
            TIME.Maximum = (10000 / timer1.Interval) + 1;
        }

        private void Archivos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            modelIndex = (int)Archivos.SelectedNode.Tag;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pct_Click(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            animate = !animate;
        }

        private void addFrame_Click(object sender, EventArgs e)
        {
            if (raster == null)
                return;
            if (initialFrame == -1)
            {
                initialFrame = TIME.Value;
                raster.SaveFrame(TIME.Value);

            }
            else if (finalFrame == -1)
            {
                finalFrame = TIME.Value;
                raster.SaveFrame(TIME.Value);
                for (int i = 0; i < raster.instances.Count; i++)
                {
                    Instance ints = raster.instances[i];
                    
                }
                raster.CalculateSteps(initialFrame, finalFrame);


            }
            else
            {
                Console.WriteLine("nope");
            }
        }


        public string GetFileName(string filePath)
        {
            int Slash = filePath.LastIndexOf('\\');
            int Backslash = filePath.LastIndexOf('/');

            int lastIndex = Math.Max(Slash, Backslash);

            if (lastIndex == -1)
            {
                return filePath;
            }
            else
            {
                return filePath.Substring(lastIndex + 1);
            }
        }


        public Color GetRandomColor()
        {
            // Crea tres números aleatorios para los componentes Rojo, Verde y Azul (RGB)
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            // Devuelve el color creado a partir de los valores RGB aleatorios
            return Color.FromArgb(red, green, blue);
        }


        private void open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                List<Vertex> vertexes = new List<Vertex>();
                List<Triangle> triangles = new List<Triangle>();
                StreamReader streamReader = new StreamReader(filePath);
                using (streamReader)
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        List<int> indexes = new List<int>();
                        if (line.StartsWith("v "))
                        {
                            string[] tokens = line.Split(' ');
                            float x = float.Parse(tokens[1]);
                            float y = float.Parse(tokens[2]);
                            float z = float.Parse(tokens[3]);
                            Vertex ver = new Vertex(x, y, z);
                            vertexes.Add(ver);

                        }
                        else if (line.StartsWith("f "))
                        {

                            string[] aux = line.Split(' ');
                            for (int i = 1; i < aux.Length; i++)
                            {
                                indexes.Add(int.Parse(aux[i].Split('/')[0]) - 1);
                            }
                            Triangle triangle = new Triangle(indexes[0], indexes[1], indexes[2], GetRandomColor());

                            triangles.Add(triangle);

                        }
                    }
                }
                if (raster == null)
                {
                    raster = new Rasterization(pct.Size, vertexes, triangles);
                    pct.Image = raster.Canvas;
                    TreeNode node = new TreeNode(GetFileName(filePath));
                    node.Tag = 0;
                    modelIndex = 0;
                    Archivos.Nodes.Add(node);
                }
                else
                {
                    TreeNode node = new TreeNode(GetFileName(filePath));
                    node.Tag = raster.AddModel(vertexes, triangles);
                    modelIndex = (int)node.Tag;
                    Archivos.Nodes.Add(node);


                }
            }
        }

        private void TB_TIME_Scroll(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (raster == null)
                return;
            if (animate)
                raster.Animate(TIME.Value, initialFrame);
            raster.Render();
            pct.Invalidate();
            if (animate)
            {
                if (TIME.Value == TIME.Maximum)
                    TIME.Value = 0;
                else
                    TIME.Value++;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }



        private void tansx_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                Vertex t = new Vertex(tansx.Value, transy.Value, transz.Value);
               
                 raster.Translate(t, modelIndex);
             
            }


        }

        private void transy_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                Vertex t = new Vertex(tansx.Value, transy.Value, transz.Value);

                raster.Translate(t, modelIndex);

            }
        }

        private void transz_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                Vertex t = new Vertex(tansx.Value, transy.Value, transz.Value);

                raster.Translate(t, modelIndex);

            }
        }

        private void rotx_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                Vertex t = new Vertex(rotx.Value, roty.Value, rotz.Value);

                raster.Rotate(t, modelIndex);

            }
        }


        private void rotz_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                Vertex t = new Vertex(rotx.Value, roty.Value, rotz.Value);

                raster.Rotate(t, modelIndex);

            }
        }

        private void roty_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                Vertex t = new Vertex(rotx.Value, roty.Value, rotz.Value);

                raster.Rotate(t, modelIndex);

            }
        }

        private void esc_Scroll(object sender, EventArgs e)
        {
            if (raster != null)
            {
                
                float value = ((float)esc.Value) / 100;
                raster.Scales(value, modelIndex);

            }
        }
        

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            label1.Text = "Tiempo : " + ConvertirMilisegundosAString(TIME.Value * timer1.Interval);

           
        }
        public static string ConvertirMilisegundosAString(long milisegundos)
        {
            int segundos = (int)(milisegundos / 1000); // Convierte a segundos

            segundos = segundos % 60; // Obtiene los segundos restantes
            int milisegRestantes = (int)(milisegundos % 1000); // Obtiene los milisegundos restantes

            string resultado = segundos.ToString() + " segundos y " + milisegRestantes.ToString() + " milisegundos";

            return resultado;
        }
    }
}
