namespace CG_Lab4_3DFunction_Graphs
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
            this.FunctionType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.YmaxNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.YminNUD = new System.Windows.Forms.NumericUpDown();
            this.XmaxNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.XminNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SplitNUD = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YmaxNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YminNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmaxNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XminNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // FunctionType
            // 
            this.FunctionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FunctionType.FormattingEnabled = true;
            this.FunctionType.Location = new System.Drawing.Point(12, 12);
            this.FunctionType.Name = "FunctionType";
            this.FunctionType.Size = new System.Drawing.Size(121, 21);
            this.FunctionType.TabIndex = 0;
            this.FunctionType.SelectedIndexChanged += new System.EventHandler(this.FunctionType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SplitNUD);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.YmaxNUD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.YminNUD);
            this.groupBox1.Controls.Add(this.XmaxNUD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.XminNUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(19, 132);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // YmaxNUD
            // 
            this.YmaxNUD.Location = new System.Drawing.Point(105, 79);
            this.YmaxNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YmaxNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.YmaxNUD.Name = "YmaxNUD";
            this.YmaxNUD.Size = new System.Drawing.Size(30, 20);
            this.YmaxNUD.TabIndex = 8;
            this.YmaxNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.YmaxNUD.ValueChanged += new System.EventHandler(this.YmaxNUD_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "до";
            // 
            // YminNUD
            // 
            this.YminNUD.Location = new System.Drawing.Point(44, 79);
            this.YminNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.YminNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.YminNUD.Name = "YminNUD";
            this.YminNUD.Size = new System.Drawing.Size(30, 20);
            this.YminNUD.TabIndex = 6;
            this.YminNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.YminNUD.ValueChanged += new System.EventHandler(this.YminNUD_ValueChanged);
            // 
            // XmaxNUD
            // 
            this.XmaxNUD.Location = new System.Drawing.Point(105, 42);
            this.XmaxNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XmaxNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.XmaxNUD.Name = "XmaxNUD";
            this.XmaxNUD.Size = new System.Drawing.Size(30, 20);
            this.XmaxNUD.TabIndex = 5;
            this.XmaxNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.XmaxNUD.ValueChanged += new System.EventHandler(this.XmaxNUD_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "до";
            // 
            // XminNUD
            // 
            this.XminNUD.Location = new System.Drawing.Point(44, 42);
            this.XminNUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.XminNUD.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.XminNUD.Name = "XminNUD";
            this.XminNUD.Size = new System.Drawing.Size(30, 20);
            this.XminNUD.TabIndex = 3;
            this.XminNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.XminNUD.ValueChanged += new System.EventHandler(this.XminNUD_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y: от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "X: от ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Область определения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Уменьшить масштаб";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "Количество разбиений \r\nна единчном отрезке";
            // 
            // SplitNUD
            // 
            this.SplitNUD.Location = new System.Drawing.Point(47, 193);
            this.SplitNUD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SplitNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SplitNUD.Name = "SplitNUD";
            this.SplitNUD.Size = new System.Drawing.Size(52, 20);
            this.SplitNUD.TabIndex = 2;
            this.SplitNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SplitNUD.ValueChanged += new System.EventHandler(this.SplitNUD_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 861);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FunctionType);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3DFunction";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YmaxNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YminNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XmaxNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XminNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FunctionType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown YmaxNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown YminNUD;
        private System.Windows.Forms.NumericUpDown XmaxNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown XminNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.NumericUpDown SplitNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

