using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using utils;

namespace WindowsFormsRayTracing
{
    class Sphere : GameObject
    {
        public float r;
        public static int count = 0;
        public Sphere(vec3 pos, float rad)
        {
            count++;
            name = "Sphere_" + count;
            position = pos;
            r = rad;
            color = Color.White;
        }
        public override float Interspect(vec3 ro, vec3 rd)
        {
            vec3 oc = Utils.sub(ro, position);
            float b = Utils.dot(oc, rd);
            float c = Utils.dot(oc, oc) - r * r;
            float h = b * b - c;
            if (h < 0) return -1;
            h = (float)Math.Sqrt(h);
            return Math.Min(-b + h, -b - h);
        }
        public override vec3 getNormal(vec3 dot)
        {
            return utils.Utils.normilize(utils.Utils.sub(dot, position));
        }
        public override void getInfo(ref GroupBox parent)
        {
            parent.Controls.Clear();
            parent.Location = new Point(7, 108);
            parent.Size = new Size(146, 121);
            parent.Text = name;
            Label l = new Label();
            l.Text = "Радиус: ";
            parent.Controls.Add(l);
            l.Location = new Point(6, 16);
            TextBox t = new TextBox();
            parent.Controls.Add(t);
            t.Location = new Point(9, 40);
            t.Size = new Size(53, 20);
            t.Text = r.ToString();
        }
        public override void setInfo(ref GroupBox parent, ref List<NumericUpDown> pos, ref List<NumericUpDown> col)
        {
            r = float.Parse(parent.Controls[1].Text);
            position = new vec3((float)pos[0].Value, (float)pos[1].Value, (float)pos[2].Value);
            color = Color.FromArgb((int)col[0].Value, (int)col[1].Value, (int)col[2].Value);
        }
    }
}
