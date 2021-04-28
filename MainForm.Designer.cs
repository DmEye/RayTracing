
namespace WindowsFormsRayTracing
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sceneBoxPool = new System.Windows.Forms.ListBox();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.bChange = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.blueNumeric = new System.Windows.Forms.NumericUpDown();
            this.greenNumeric = new System.Windows.Forms.NumericUpDown();
            this.redNumeric = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.posZNumeric = new System.Windows.Forms.NumericUpDown();
            this.posYNumeric = new System.Windows.Forms.NumericUpDown();
            this.posXNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.rb_field = new System.Windows.Forms.RadioButton();
            this.rb_sphere = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lzNumeric = new System.Windows.Forms.NumericUpDown();
            this.lyNumeric = new System.Windows.Forms.NumericUpDown();
            this.lxNumeric = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.renderGroup = new System.Windows.Forms.GroupBox();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pauseB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxParams.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posZNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posYNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNumeric)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lzNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxNumeric)).BeginInit();
            this.renderGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBox.Location = new System.Drawing.Point(12, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(200, 200);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(607, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Объекты на сцене:";
            // 
            // sceneBoxPool
            // 
            this.sceneBoxPool.FormattingEnabled = true;
            this.sceneBoxPool.Location = new System.Drawing.Point(605, 102);
            this.sceneBoxPool.Name = "sceneBoxPool";
            this.sceneBoxPool.Size = new System.Drawing.Size(175, 134);
            this.sceneBoxPool.TabIndex = 10;
            this.sceneBoxPool.TabStop = false;
            this.sceneBoxPool.SelectedIndexChanged += new System.EventHandler(this.sceneBoxPool_SelectedIndexChanged);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.BackColor = System.Drawing.SystemColors.Info;
            this.groupBoxParams.Controls.Add(this.bChange);
            this.groupBoxParams.Controls.Add(this.groupBox1);
            this.groupBoxParams.Controls.Add(this.groupBox3);
            this.groupBoxParams.Controls.Add(this.groupBox2);
            this.groupBoxParams.Location = new System.Drawing.Point(605, 242);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(175, 262);
            this.groupBoxParams.TabIndex = 11;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры:";
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(7, 232);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(146, 23);
            this.bChange.TabIndex = 3;
            this.bChange.TabStop = false;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Объект не выбран:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.blueNumeric);
            this.groupBox3.Controls.Add(this.greenNumeric);
            this.groupBox3.Controls.Add(this.redNumeric);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(98, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(69, 81);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвет:";
            // 
            // blueNumeric
            // 
            this.blueNumeric.Location = new System.Drawing.Point(18, 55);
            this.blueNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.blueNumeric.Name = "blueNumeric";
            this.blueNumeric.Size = new System.Drawing.Size(43, 20);
            this.blueNumeric.TabIndex = 23;
            this.blueNumeric.TabStop = false;
            // 
            // greenNumeric
            // 
            this.greenNumeric.Location = new System.Drawing.Point(18, 35);
            this.greenNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.greenNumeric.Name = "greenNumeric";
            this.greenNumeric.Size = new System.Drawing.Size(43, 20);
            this.greenNumeric.TabIndex = 22;
            this.greenNumeric.TabStop = false;
            // 
            // redNumeric
            // 
            this.redNumeric.Location = new System.Drawing.Point(18, 15);
            this.redNumeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.redNumeric.Name = "redNumeric";
            this.redNumeric.Size = new System.Drawing.Size(43, 20);
            this.redNumeric.TabIndex = 21;
            this.redNumeric.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "B:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "G:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "R:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.posZNumeric);
            this.groupBox2.Controls.Add(this.posYNumeric);
            this.groupBox2.Controls.Add(this.posXNumeric);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(79, 81);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Позиция:";
            // 
            // posZNumeric
            // 
            this.posZNumeric.Location = new System.Drawing.Point(30, 52);
            this.posZNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.posZNumeric.Name = "posZNumeric";
            this.posZNumeric.Size = new System.Drawing.Size(43, 20);
            this.posZNumeric.TabIndex = 26;
            this.posZNumeric.TabStop = false;
            // 
            // posYNumeric
            // 
            this.posYNumeric.Location = new System.Drawing.Point(30, 32);
            this.posYNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.posYNumeric.Name = "posYNumeric";
            this.posYNumeric.Size = new System.Drawing.Size(43, 20);
            this.posYNumeric.TabIndex = 25;
            this.posYNumeric.TabStop = false;
            // 
            // posXNumeric
            // 
            this.posXNumeric.Location = new System.Drawing.Point(30, 12);
            this.posXNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.posXNumeric.Name = "posXNumeric";
            this.posXNumeric.Size = new System.Drawing.Size(43, 20);
            this.posXNumeric.TabIndex = 24;
            this.posXNumeric.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Z:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "X:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Controls.Add(this.bAdd);
            this.groupBox4.Controls.Add(this.rb_field);
            this.groupBox4.Controls.Add(this.rb_sphere);
            this.groupBox4.Location = new System.Drawing.Point(605, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 68);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Добавление объектов:";
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.SystemColors.Control;
            this.bAdd.Location = new System.Drawing.Point(86, 36);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(67, 23);
            this.bAdd.TabIndex = 15;
            this.bAdd.TabStop = false;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // rb_field
            // 
            this.rb_field.AutoSize = true;
            this.rb_field.BackColor = System.Drawing.SystemColors.Control;
            this.rb_field.Location = new System.Drawing.Point(6, 42);
            this.rb_field.Name = "rb_field";
            this.rb_field.Size = new System.Drawing.Size(80, 17);
            this.rb_field.TabIndex = 14;
            this.rb_field.Text = "Плоскость";
            this.rb_field.UseVisualStyleBackColor = false;
            // 
            // rb_sphere
            // 
            this.rb_sphere.AutoSize = true;
            this.rb_sphere.BackColor = System.Drawing.SystemColors.Control;
            this.rb_sphere.Location = new System.Drawing.Point(6, 19);
            this.rb_sphere.Name = "rb_sphere";
            this.rb_sphere.Size = new System.Drawing.Size(58, 17);
            this.rb_sphere.TabIndex = 13;
            this.rb_sphere.Text = "Сфера";
            this.rb_sphere.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox5.Controls.Add(this.lzNumeric);
            this.groupBox5.Controls.Add(this.lyNumeric);
            this.groupBox5.Controls.Add(this.lxNumeric);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Location = new System.Drawing.Point(495, 507);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 42);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Направление света:";
            // 
            // lzNumeric
            // 
            this.lzNumeric.DecimalPlaces = 2;
            this.lzNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lzNumeric.Location = new System.Drawing.Point(204, 18);
            this.lzNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lzNumeric.Name = "lzNumeric";
            this.lzNumeric.Size = new System.Drawing.Size(75, 20);
            this.lzNumeric.TabIndex = 10;
            this.lzNumeric.TabStop = false;
            // 
            // lyNumeric
            // 
            this.lyNumeric.DecimalPlaces = 2;
            this.lyNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lyNumeric.Location = new System.Drawing.Point(108, 18);
            this.lyNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lyNumeric.Name = "lyNumeric";
            this.lyNumeric.Size = new System.Drawing.Size(75, 20);
            this.lyNumeric.TabIndex = 9;
            this.lyNumeric.TabStop = false;
            // 
            // lxNumeric
            // 
            this.lxNumeric.DecimalPlaces = 2;
            this.lxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.lxNumeric.Location = new System.Drawing.Point(15, 18);
            this.lxNumeric.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lxNumeric.Name = "lxNumeric";
            this.lxNumeric.Size = new System.Drawing.Size(75, 20);
            this.lxNumeric.TabIndex = 8;
            this.lxNumeric.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 42);
            this.button1.TabIndex = 14;
            this.button1.TabStop = false;
            this.button1.Text = "Рендер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // renderGroup
            // 
            this.renderGroup.BackColor = System.Drawing.SystemColors.Info;
            this.renderGroup.Controls.Add(this.heightBox);
            this.renderGroup.Controls.Add(this.widthBox);
            this.renderGroup.Controls.Add(this.label12);
            this.renderGroup.Controls.Add(this.label1);
            this.renderGroup.Location = new System.Drawing.Point(249, 507);
            this.renderGroup.Name = "renderGroup";
            this.renderGroup.Size = new System.Drawing.Size(240, 42);
            this.renderGroup.TabIndex = 15;
            this.renderGroup.TabStop = false;
            this.renderGroup.Text = "Окно рендеринга:";
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(178, 18);
            this.heightBox.Maximum = new decimal(new int[] {
            490,
            0,
            0,
            0});
            this.heightBox.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(56, 20);
            this.heightBox.TabIndex = 3;
            this.heightBox.TabStop = false;
            this.heightBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(62, 18);
            this.widthBox.Maximum = new decimal(new int[] {
            575,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(56, 20);
            this.widthBox.TabIndex = 2;
            this.widthBox.TabStop = false;
            this.widthBox.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(124, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Высота:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина:";
            // 
            // pauseB
            // 
            this.pauseB.Location = new System.Drawing.Point(98, 507);
            this.pauseB.Name = "pauseB";
            this.pauseB.Size = new System.Drawing.Size(80, 42);
            this.pauseB.TabIndex = 16;
            this.pauseB.TabStop = false;
            this.pauseB.Text = "Пауза";
            this.pauseB.UseVisualStyleBackColor = true;
            this.pauseB.Click += new System.EventHandler(this.pauseB_Click);
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(184, 507);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(59, 42);
            this.closeB.TabIndex = 17;
            this.closeB.TabStop = false;
            this.closeB.Text = "Закрыть";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.pauseB);
            this.Controls.Add(this.renderGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.sceneBoxPool);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ray Tracing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxParams.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blueNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redNumeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.posZNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posYNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posXNumeric)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lzNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lxNumeric)).EndInit();
            this.renderGroup.ResumeLayout(false);
            this.renderGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox sceneBoxPool;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.RadioButton rb_field;
        private System.Windows.Forms.RadioButton rb_sphere;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown blueNumeric;
        private System.Windows.Forms.NumericUpDown greenNumeric;
        private System.Windows.Forms.NumericUpDown redNumeric;
        private System.Windows.Forms.NumericUpDown lzNumeric;
        private System.Windows.Forms.NumericUpDown lyNumeric;
        private System.Windows.Forms.NumericUpDown lxNumeric;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox renderGroup;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown posZNumeric;
        private System.Windows.Forms.NumericUpDown posYNumeric;
        private System.Windows.Forms.NumericUpDown posXNumeric;
        private System.Windows.Forms.Button pauseB;
        private System.Windows.Forms.Button closeB;
    }
}

