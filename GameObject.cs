using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using utils;

namespace WindowsFormsRayTracing
{
    class GameObject
    {
        public vec3 position;
        public Color color;
        public string name;
        virtual public float Interspect(vec3 ro, vec3 rd) { return 0; }
        virtual public vec3 getNormal(vec3 dot) { return new vec3(); }
        virtual public void getInfo(ref GroupBox parent) { }
        virtual public void setInfo(ref GroupBox parent, ref List<NumericUpDown> pos, ref List<NumericUpDown> col) { }
    }
}
