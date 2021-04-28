using System;
using System.Collections.Generic;
using System.Drawing;
using WindowsFormsRayTracing;

namespace utils
{
    class Ray
    {
        public vec3 direction;
        public vec3 origin;

        public Ray(vec3 rd, vec3 ro)
        {
            direction = rd;
            origin = ro;
        }

        public Color Trace(ref List<GameObject> gameObjects, vec3 light)
        {
            GameObject obj = null;
            float minDist = 100;
            float itDist;
            vec3 n = new vec3();
            foreach (var gameObject in gameObjects)
            {
                itDist = gameObject.Interspect(Utils.sub(origin, gameObject.position), direction);
                if (itDist > 0 && itDist < minDist)
                {
                    minDist = itDist;
                    vec3 dot = Utils.add(origin, Utils.multS(direction, itDist));
                    n = gameObject.getNormal(dot);
                    obj = gameObject;
                }
            }

            if (minDist >= 100 || n.IsNan() || obj == null)
            {
                vec3 lightDir2 = light;
                float diffuse2 = Math.Max(0, Utils.dot(lightDir2, direction)) * 0.2f;

                float specular2 = (float)Math.Pow(Math.Max(0, Utils.dot(direction, lightDir2)), 8);
                diffuse2 += specular2;
                diffuse2 = Math.Max(0, diffuse2);
                diffuse2 = diffuse2 > 1 ? 1 : diffuse2;
                Color c2;
                if (diffuse2 > 0.98f)
                    c2 = Color.FromArgb((int)(Color.Yellow.R * diffuse2), (int)(Color.Yellow.G * diffuse2), (int)(Color.Yellow.B * diffuse2));
                else
                    c2 = Color.LightSkyBlue;
                return c2;
            }
            /*else if (Utils.dot(direction, light) <= 0)
            {
                return obj.color;
            }*/
            vec3 lightDir = light;// Utils.normilize(new vec3(0, 0, -1));
            float diffuse = Math.Max(0, Utils.dot(lightDir, n)) * 0.5f + 0.1f;

            vec3 reflected = Utils.sub(direction, Utils.multS(n, 2 * Utils.dot(n, direction)));
            float specular = (float)Math.Pow(Math.Max(0, Utils.dot(reflected, lightDir)), 16);
            diffuse += specular;
            diffuse = Math.Max(0.1f, diffuse);
            diffuse = diffuse > 1 ? 1 : diffuse;
            Color c = Color.FromArgb((int)(obj.color.R * diffuse), (int)(obj.color.G * diffuse), (int)(obj.color.B * diffuse));
            return c;
        }
    }
}
