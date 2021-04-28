using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using utils;

namespace WindowsFormsRayTracing
{
    class Field : GameObject
    {
        public vec3 n;
        public float r;
        private static int count = 0;
        public Field(vec3 N, float R)
        {
            count++;
            name = "Field_" + count;
            n = N;
            r = R;
            color = Color.SandyBrown;
        }
        public override float Interspect(vec3 ro, vec3 rd)
        {
            float dotDN = Utils.dot(rd, n);
            if (dotDN == 0) return -1;
            return -(r - Utils.dot(ro, n)) / dotDN;
        }
        public override vec3 getNormal(vec3 dot)
        {
            return n;
        }
        public override void getInfo(ref GroupBox parent)
        {
            parent.Controls.Clear();
            parent.Location = new Point(7, 108);
            parent.Size = new Size(146, 121);
            parent.Text = name;

            Label l = new Label();
            l.Text = "Расстояние: ";
            parent.Controls.Add(l);
            l.Location = new Point(6, 16);
            TextBox t = new TextBox();
            parent.Controls.Add(t);
            t.Location = new Point(9, 40);
            t.Size = new Size(53, 20);
            t.Text = r.ToString();

            Label l2 = new Label();
            Label lX = new Label();
            Label lY = new Label();
            Label lZ = new Label();
            l2.Text = "Нормаль: ";
            parent.Controls.Add(l2);
            l2.Location = new Point(6, 63);

            TextBox tX = new TextBox();
            TextBox tY = new TextBox();
            TextBox tZ = new TextBox();
            parent.Controls.Add(lX);
            lX.Location = new Point(6, 90); lX.Text = "X:"; lX.Size = new Size(15, 13);
            parent.Controls.Add(tX);
            tX.Location = new Point(22, 87); tX.Size = new Size(25, 20);
            parent.Controls.Add(lY);
            lY.Location = new Point(53, 90); lY.Text = "Y:"; lY.Size = new Size(15, 13);
            parent.Controls.Add(tY);
            tY.Location = new Point(69, 87); tY.Size = new Size(25, 20);
            parent.Controls.Add(lZ);
            lZ.Location = new Point(100, 90); lZ.Text = "Z:"; lZ.Size = new Size(15, 13);
            parent.Controls.Add(tZ);
            tZ.Location = new Point(115, 87); tZ.Size = new Size(25, 20);

            tX.Text = n.x.ToString();
            tY.Text = n.y.ToString();
            tZ.Text = n.z.ToString();
        }
        public override void setInfo(ref GroupBox parent, ref List<NumericUpDown> pos, ref List<NumericUpDown> col)
        {
            color = Color.FromArgb((int)col[0].Value, (int)col[1].Value, (int)col[2].Value);
            r = float.Parse(parent.Controls[1].Text);
            n.x = float.Parse(parent.Controls[4].Text);
            n.y = float.Parse(parent.Controls[6].Text);
            n.z = float.Parse(parent.Controls[8].Text);
        }
    }
}
