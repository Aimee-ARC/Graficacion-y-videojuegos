
using System.Drawing;

namespace IntentoDeMotor
{
    public class Scene
    {
        private Figure _figure;
        public Pen _pen = new Pen(Color.Black,2);
        public int _angle;

        public Scene(Figure figure)
        {
            _figure = figure;
        }

        public void Draw(Graphics graphics, int viewWidth, int viewHeight)
        {

            graphics.Clear(Color.FromArgb(200, 200, 200));
            // Draw x-axis
            graphics.DrawLine(new Pen(Color.Red), 0, viewHeight / 2, viewWidth, viewHeight / 2);

            // Draw y-axis
            graphics.DrawLine(new Pen(Color.Blue), viewWidth / 2, 0, viewWidth / 2, viewHeight);


            var projected = new Vertex[_figure.Vertices.Length];
            for (var i = 0; i < _figure.Vertices.Length; i++)
            {
                var vertex = _figure.Vertices[i];

                var transformed = vertex.RotateZ(_angle); //.RotateY(_angle).RotateZ(_angle)
                projected[i] = transformed.Project(viewWidth, viewHeight, 4000, 100);
            }

            for (var j = 0; j < 6; j++)
            {
                graphics.DrawLine(_pen,
                    (int)projected[_figure.Faces[j, 0]].X,
                    (int)projected[_figure.Faces[j, 0]].Y,
                    (int)projected[_figure.Faces[j, 1]].X,
                    (int)projected[_figure.Faces[j, 1]].Y);

                graphics.DrawLine(_pen,
                    (int)projected[_figure.Faces[j, 1]].X,
                    (int)projected[_figure.Faces[j, 1]].Y,
                    (int)projected[_figure.Faces[j, 2]].X,
                    (int)projected[_figure.Faces[j, 2]].Y);

                graphics.DrawLine(_pen,
                    (int)projected[_figure.Faces[j, 2]].X,
                    (int)projected[_figure.Faces[j, 2]].Y,
                    (int)projected[_figure.Faces[j, 3]].X,
                    (int)projected[_figure.Faces[j, 3]].Y);

                graphics.DrawLine(_pen,
                    (int)projected[_figure.Faces[j, 3]].X,
                    (int)projected[_figure.Faces[j, 3]].Y,
                    (int)projected[_figure.Faces[j, 0]].X,
                    (int)projected[_figure.Faces[j, 0]].Y);
            }

            _angle++;
        }
    }

}
