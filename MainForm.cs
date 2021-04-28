using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using utils;

namespace WindowsFormsRayTracing
{
    public partial class MainForm : Form
    {
        private Thread drawThread;
        private Thread addObject;

        private List<GameObject> scene;
        private Bitmap bitmap;
        private int W = 300;
        private int H = 300;
        private List<NumericUpDown> pos;
        private List<NumericUpDown> col;

        private float t = 0;

        public static vec3 light;
        public static vec3 RayOrigin;
        public static vec3 RayDirection;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pos = new List<NumericUpDown>();
            col = new List<NumericUpDown>();
            pos.Add(posXNumeric); pos.Add(posYNumeric); pos.Add(posZNumeric);
            col.Add(redNumeric); col.Add(greenNumeric); col.Add(blueNumeric);

            light = Utils.normilize(new vec3(0, 0, -1));
            RayOrigin = new vec3(-5f, 0, 0);
            lxNumeric.Value = (decimal)light.x;
            lyNumeric.Value = (decimal)light.y;
            lzNumeric.Value = (decimal)light.z;

            pictureBox.Location = new Point(0, 0);
            pictureBox.Size = new Size(W, H);
            bitmap = new Bitmap(W, H);

            scene = new List<GameObject>();
            addObjectToScene(new Sphere(new vec3(0, 0, 0), 1)); scene[0].color = Color.Chocolate;
            //addObjectToScene(new Sphere(new vec3(-1, -1.05f, 0), 1)); scene[1].color = Color.Red;
            //addObjectToScene(new Sphere(new vec3(0, 1.05f, 0), 0.5f)); scene[2].color = Color.Blue;
            addObjectToScene(new Field(new vec3(0, 0, -1), 1)); scene[1].color = Color.Yellow;

            setInfo();
        }
        public void render()
        {
            while (true)
            {
                for (int i = 0; i < W; i++)
                {
                    for (int j = 0; j < H; j++)
                    {
                        float x = (float)i / (float)W * 2 - 1;
                        float y = (float)j / (float)H * 2 - 1;
                        x = x * W / H;

                        RayDirection = Utils.normilize(new vec3(1, x, y));
                        Ray ray = new Ray(RayDirection, RayOrigin);
                        Color c = ray.Trace(ref scene, light);
                        bitmap.SetPixel(i, j, c);
                    }
                }
                pictureBox.Image = bitmap;
                moveObjects();
                Thread.Sleep(17);
            }
        }
        private void addObjectToScene(object gameObject)
        {
            scene.Add((GameObject)gameObject);
            sceneBoxPool.Items.Add(((GameObject)gameObject).name);
            Thread.Sleep(10);
        }
        private void sceneBoxPool_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawThread?.Abort();
            var indObj = searchObjectScene(ref scene, sceneBoxPool.SelectedItem.ToString());
            scene[indObj].getInfo(ref groupBox1);
            posXNumeric.Value = (decimal)scene[indObj].position.x;
            posYNumeric.Value = (decimal)scene[indObj].position.y;
            posZNumeric.Value = (decimal)scene[indObj].position.z;
            redNumeric.Value = scene[indObj].color.R;
            greenNumeric.Value = scene[indObj].color.G;
            blueNumeric.Value = scene[indObj].color.B;

        }

        private void bChange_Click(object sender, EventArgs e)
        {
            setInfo();
        }

        private int searchObjectScene(ref List<GameObject> scene, string name)
        {
            foreach (var gameObject in scene)
            {
                if (gameObject.name == name) return scene.IndexOf(gameObject);
            }
            return -1;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            drawThread?.Abort();
            addObject?.Abort();
            addObject = new Thread(addObjectToScene);
            addObject.IsBackground = true;
            addObject.Priority = ThreadPriority.Highest;
            if (rb_sphere.Checked)
            {
                addObject.Start(new Sphere(new vec3(0, 0, 0), 1));
            }
            if (rb_field.Checked)
            {
                addObject.Start(new Field(new vec3(0, 0, -1), -1));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            drawThread?.Abort();
            addObject?.Abort();
        }

        private void setInfo()
        {
            float xl = (float)lxNumeric.Value;
            float yl = (float)lyNumeric.Value;
            float zl = (float)lzNumeric.Value;
            light = Utils.normilize(new vec3(xl, yl, zl));

            // Изменения параметров выбранного объекта
            var indObj = searchObjectScene(ref scene, groupBox1.Text);
            if (indObj != -1)
            {
                scene[indObj].setInfo(ref groupBox1, ref pos, ref col);
            }
        }

        private void moveObjects()
        {
            if (scene.Count > 0)
            {
                scene[0].position.y = (float)Math.Sin(t);
                scene[0].position.x = (float)Math.Cos(t);
            }
            t = (t % 6.28f) + 0.1f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawThread?.Abort();

            groupBox4.Enabled = false; // Добавление объектов
            sceneBoxPool.Enabled = false;
            groupBoxParams.Enabled = false;
            groupBox5.Enabled = false;

            drawThread = new Thread(new ThreadStart(render));
            drawThread.IsBackground = true;
            drawThread.Priority = ThreadPriority.AboveNormal;
            W = (int)widthBox.Value;
            H = (int)heightBox.Value;
            pictureBox.Size = new Size(W, H);
            bitmap = new Bitmap(W, H);
            drawThread.Start();
        }

        private void pauseB_Click(object sender, EventArgs e)
        {
            drawThread?.Abort();
            groupBox4.Enabled = true; // Добавление объектов
            sceneBoxPool.Enabled = true;
            groupBoxParams.Enabled = true;
            groupBox5.Enabled = true; // Направление света
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            drawThread?.Abort();
            addObject?.Abort();
            Close();
        }
    }
}
