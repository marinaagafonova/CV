namespace CG_Task6_Fractals
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SwitchFractalGB = new System.Windows.Forms.GroupBox();
            this.ColouredMFracRB = new System.Windows.Forms.RadioButton();
            this.SimpleMFracRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.YMaxTB = new System.Windows.Forms.TextBox();
            this.YminTB = new System.Windows.Forms.TextBox();
            this.XMaxTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JuliaTools = new System.Windows.Forms.GroupBox();
            this.JqTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.JpTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SierpinskiToolsGB = new System.Windows.Forms.GroupBox();
            this.LevelNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SierpinskiRB = new System.Windows.Forms.RadioButton();
            this.MandelbrotRB = new System.Windows.Forms.RadioButton();
            this.JuliaRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SwitchFractalGB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.JuliaTools.SuspendLayout();
            this.SierpinskiToolsGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SwitchFractalGB);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.JuliaTools);
            this.groupBox1.Controls.Add(this.SierpinskiToolsGB);
            this.groupBox1.Controls.Add(this.SierpinskiRB);
            this.groupBox1.Controls.Add(this.MandelbrotRB);
            this.groupBox1.Controls.Add(this.JuliaRB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch Fractal";
            // 
            // SwitchFractalGB
            // 
            this.SwitchFractalGB.Controls.Add(this.ColouredMFracRB);
            this.SwitchFractalGB.Controls.Add(this.SimpleMFracRB);
            this.SwitchFractalGB.Location = new System.Drawing.Point(13, 169);
            this.SwitchFractalGB.Name = "SwitchFractalGB";
            this.SwitchFractalGB.Size = new System.Drawing.Size(160, 67);
            this.SwitchFractalGB.TabIndex = 7;
            this.SwitchFractalGB.TabStop = false;
            this.SwitchFractalGB.Text = "Switch fractal";
            // 
            // ColouredMFracRB
            // 
            this.ColouredMFracRB.AutoSize = true;
            this.ColouredMFracRB.Checked = true;
            this.ColouredMFracRB.Location = new System.Drawing.Point(20, 42);
            this.ColouredMFracRB.Name = "ColouredMFracRB";
            this.ColouredMFracRB.Size = new System.Drawing.Size(67, 17);
            this.ColouredMFracRB.TabIndex = 1;
            this.ColouredMFracRB.TabStop = true;
            this.ColouredMFracRB.Text = "Coloured";
            this.ColouredMFracRB.UseVisualStyleBackColor = true;
            // 
            // SimpleMFracRB
            // 
            this.SimpleMFracRB.AutoSize = true;
            this.SimpleMFracRB.Location = new System.Drawing.Point(20, 19);
            this.SimpleMFracRB.Name = "SimpleMFracRB";
            this.SimpleMFracRB.Size = new System.Drawing.Size(56, 17);
            this.SimpleMFracRB.TabIndex = 0;
            this.SimpleMFracRB.Text = "Simple";
            this.SimpleMFracRB.UseVisualStyleBackColor = true;
            this.SimpleMFracRB.CheckedChanged += new System.EventHandler(this.SimpleMFracRB_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.YMaxTB);
            this.groupBox2.Controls.Add(this.YminTB);
            this.groupBox2.Controls.Add(this.XMaxTB);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 81);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools for Julia and M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "to";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "to";
            // 
            // YMaxTB
            // 
            this.YMaxTB.Location = new System.Drawing.Point(120, 46);
            this.YMaxTB.Name = "YMaxTB";
            this.YMaxTB.Size = new System.Drawing.Size(49, 20);
            this.YMaxTB.TabIndex = 5;
            this.YMaxTB.Text = "2,0";
            this.YMaxTB.Enter += new System.EventHandler(this.YMaxTB_Enter);
            // 
            // YminTB
            // 
            this.YminTB.Location = new System.Drawing.Point(35, 46);
            this.YminTB.Name = "YminTB";
            this.YminTB.Size = new System.Drawing.Size(49, 20);
            this.YminTB.TabIndex = 4;
            this.YminTB.Text = "-2,0";
            this.YminTB.Enter += new System.EventHandler(this.YminTB_Enter);
            // 
            // XMaxTB
            // 
            this.XMaxTB.Location = new System.Drawing.Point(120, 22);
            this.XMaxTB.Name = "XMaxTB";
            this.XMaxTB.Size = new System.Drawing.Size(49, 20);
            this.XMaxTB.TabIndex = 3;
            this.XMaxTB.Text = "2,0";
            this.XMaxTB.Enter += new System.EventHandler(this.XMaxTB_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "-2,0";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Y: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "X: ";
            // 
            // JuliaTools
            // 
            this.JuliaTools.Controls.Add(this.JqTB);
            this.JuliaTools.Controls.Add(this.label6);
            this.JuliaTools.Controls.Add(this.JpTB);
            this.JuliaTools.Controls.Add(this.label5);
            this.JuliaTools.Controls.Add(this.label4);
            this.JuliaTools.Location = new System.Drawing.Point(8, 44);
            this.JuliaTools.Name = "JuliaTools";
            this.JuliaTools.Size = new System.Drawing.Size(193, 87);
            this.JuliaTools.TabIndex = 5;
            this.JuliaTools.TabStop = false;
            this.JuliaTools.Text = "JuliaTools";
            // 
            // JqTB
            // 
            this.JqTB.Location = new System.Drawing.Point(43, 60);
            this.JqTB.Name = "JqTB";
            this.JqTB.Size = new System.Drawing.Size(100, 20);
            this.JqTB.TabIndex = 4;
            this.JqTB.Text = "0,12";
            this.JqTB.Enter += new System.EventHandler(this.JqTB_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "q = ";
            // 
            // JpTB
            // 
            this.JpTB.Location = new System.Drawing.Point(43, 34);
            this.JpTB.Name = "JpTB";
            this.JpTB.Size = new System.Drawing.Size(100, 20);
            this.JpTB.TabIndex = 2;
            this.JpTB.Text = "-0,9";
            this.JpTB.Enter += new System.EventHandler(this.JpTB_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "p = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Set C";
            // 
            // SierpinskiToolsGB
            // 
            this.SierpinskiToolsGB.Controls.Add(this.LevelNUD);
            this.SierpinskiToolsGB.Controls.Add(this.label1);
            this.SierpinskiToolsGB.Location = new System.Drawing.Point(5, 265);
            this.SierpinskiToolsGB.Name = "SierpinskiToolsGB";
            this.SierpinskiToolsGB.Size = new System.Drawing.Size(115, 48);
            this.SierpinskiToolsGB.TabIndex = 3;
            this.SierpinskiToolsGB.TabStop = false;
            this.SierpinskiToolsGB.Text = "SierpinskiTools";
            // 
            // LevelNUD
            // 
            this.LevelNUD.Location = new System.Drawing.Point(46, 18);
            this.LevelNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.LevelNUD.Name = "LevelNUD";
            this.LevelNUD.Size = new System.Drawing.Size(63, 20);
            this.LevelNUD.TabIndex = 1;
            this.LevelNUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.LevelNUD.ValueChanged += new System.EventHandler(this.LevelNUD_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Level";
            // 
            // SierpinskiRB
            // 
            this.SierpinskiRB.AutoSize = true;
            this.SierpinskiRB.Location = new System.Drawing.Point(5, 242);
            this.SierpinskiRB.Name = "SierpinskiRB";
            this.SierpinskiRB.Size = new System.Drawing.Size(70, 17);
            this.SierpinskiRB.TabIndex = 2;
            this.SierpinskiRB.Text = "Sierpinski";
            this.SierpinskiRB.UseVisualStyleBackColor = true;
            this.SierpinskiRB.CheckedChanged += new System.EventHandler(this.SierpinskiRB_CheckedChanged);
            // 
            // MandelbrotRB
            // 
            this.MandelbrotRB.AutoSize = true;
            this.MandelbrotRB.Checked = true;
            this.MandelbrotRB.Location = new System.Drawing.Point(5, 139);
            this.MandelbrotRB.Name = "MandelbrotRB";
            this.MandelbrotRB.Size = new System.Drawing.Size(78, 17);
            this.MandelbrotRB.TabIndex = 1;
            this.MandelbrotRB.TabStop = true;
            this.MandelbrotRB.Text = "Mandelbrot";
            this.MandelbrotRB.UseVisualStyleBackColor = true;
            this.MandelbrotRB.CheckedChanged += new System.EventHandler(this.MandelbrotRB_CheckedChanged);
            // 
            // JuliaRB
            // 
            this.JuliaRB.AutoSize = true;
            this.JuliaRB.Location = new System.Drawing.Point(6, 19);
            this.JuliaRB.Name = "JuliaRB";
            this.JuliaRB.Size = new System.Drawing.Size(46, 17);
            this.JuliaRB.TabIndex = 0;
            this.JuliaRB.Text = "Julia";
            this.JuliaRB.UseVisualStyleBackColor = true;
            this.JuliaRB.CheckedChanged += new System.EventHandler(this.JuliaRB_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 1011);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractals";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Fractals_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MainForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SwitchFractalGB.ResumeLayout(false);
            this.SwitchFractalGB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.JuliaTools.ResumeLayout(false);
            this.JuliaTools.PerformLayout();
            this.SierpinskiToolsGB.ResumeLayout(false);
            this.SierpinskiToolsGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LevelNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SierpinskiRB;
        private System.Windows.Forms.RadioButton MandelbrotRB;
        private System.Windows.Forms.RadioButton JuliaRB;
        private System.Windows.Forms.GroupBox SierpinskiToolsGB;
        private System.Windows.Forms.NumericUpDown LevelNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox JuliaTools;
        private System.Windows.Forms.TextBox JqTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox JpTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox YMaxTB;
        private System.Windows.Forms.TextBox YminTB;
        private System.Windows.Forms.TextBox XMaxTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SwitchFractalGB;
        private System.Windows.Forms.RadioButton ColouredMFracRB;
        private System.Windows.Forms.RadioButton SimpleMFracRB;
    }
}

