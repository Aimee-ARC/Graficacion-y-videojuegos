using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animacion_3D
{
    public class Instance
    {
        public Model model;
        public List<Transform> transformations;
        public Vertex position;
        public Matrix orientation;
        public float scale;
        public Matrix transform;
        public float scalation;
        public Vertex translation;
        public Vertex angle;
        public Matrix initialTransform;
        //la matriz importante aqui es transform

        public Instance(Model model, Vertex position, Matrix orientation = null, float scale = 1.0f)
        {
            this.model = model;
            this.position = position;
            this.orientation = orientation ?? Matrix.Identity;
            this.scale = scale;
            this.translation = new Vertex(0, 0, 0);
            this.transform = Matrix.MakeTranslationMatrix(this.position) * this.orientation * Matrix.MakeScalingMatrix(this.scale);
            initialTransform = transform;
            this.angle = new Vertex(0, 0, 0);
            this.transformations = new List<Transform>();
            this.scalation = 1.0f;
        }
        public void SaveTransformations(int time)
        {
            transformations.Add(new Transform(transform, time));
        }
        public Transform FindTransformation(int time)
        {
            for (int i = 0; i < transformations.Count; i++)
            {
                if (transformations[i].time == time)
                    return transformations[i];
            }
            return null;
        }
        public void CalculateSteps(int initialFrame, int finalFrame)
        {
            float steps = finalFrame - initialFrame;
            Transform initialTranformation = FindTransformation(initialFrame);
            Transform finalTranformation = FindTransformation(finalFrame);
            if (steps > 0)
            {
                Matrix deltaTraslation = (finalTranformation.Mtx - initialTranformation.Mtx) / steps;

                for (int i = initialFrame; i < finalFrame; i++)
                {
                    transformations.Add(new Transform(deltaTraslation * (i - initialFrame) + initialTranformation.Mtx, i));

                }
            }
            transformations = transformations.OrderBy(x => x.time).ToList();
        }

    }
}
