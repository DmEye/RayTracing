using System;

namespace utils
{
    public struct vec3
    {
        public float x;
        public float y;
        public float z;

        public vec3(float X, float Y, float Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public bool IsNan()
        {
            return float.IsNaN(x) || float.IsNaN(y) || float.IsNaN(z);
        }
    }
    class Utils
    {
        public static float length(vec3 a)
        {
            return (float)Math.Sqrt(a.x * a.x + a.y * a.y + a.z * a.z);
        }
        public static float dot(vec3 a, vec3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }
        public static vec3 normilize(vec3 a)
        {
            float l = length(a);
            return new vec3(a.x / l, a.y / l, a.z / l);
        }
        public static vec3 add(vec3 a, vec3 b)
        {
            return new vec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static vec3 sub(vec3 a, vec3 b)
        {
            return new vec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public static vec3 multS(vec3 a, float k)
        {
            return new vec3(a.x * k, a.y * k, a.z * k);
        }
    }
}
