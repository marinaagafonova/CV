﻿namespace CG_Lab5_Animation_Solar_System
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
            this.components = new System.ComponentModel.Container();
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.modelTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpdateBttn = new System.Windows.Forms.Button();
            this.MassOfTheSun = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReduceSpeedBttn = new System.Windows.Forms.Button();
            this.IncreaseBttn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawTimer
            // 
            this.drawTimer.Enabled = true;
            this.drawTimer.Interval = 50;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // modelTimer
            // 
            this.modelTimer.Tick += new System.EventHandler(this.modelTimer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.IncreaseBttn);
            this.groupBox1.Controls.Add(this.ReduceSpeedBttn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.UpdateBttn);
            this.groupBox1.Controls.Add(this.MassOfTheSun);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // UpdateBttn
            // 
            this.UpdateBttn.Location = new System.Drawing.Point(13, 71);
            this.UpdateBttn.Name = "UpdateBttn";
            this.UpdateBttn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBttn.TabIndex = 2;
            this.UpdateBttn.Text = "Update";
            this.UpdateBttn.UseVisualStyleBackColor = true;
            this.UpdateBttn.Click += new System.EventHandler(this.UpdateBttn_Click);
            // 
            // MassOfTheSun
            // 
            this.MassOfTheSun.Location = new System.Drawing.Point(28, 45);
            this.MassOfTheSun.Name = "MassOfTheSun";
            this.MassOfTheSun.Size = new System.Drawing.Size(36, 20);
            this.MassOfTheSun.TabIndex = 1;
            this.MassOfTheSun.Text = "1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MassOfSun";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Changing of speed";
            // 
            // ReduceSpeedBttn
            // 
            this.ReduceSpeedBttn.Location = new System.Drawing.Point(17, 117);
            this.ReduceSpeedBttn.Name = "ReduceSpeedBttn";
            this.ReduceSpeedBttn.Size = new System.Drawing.Size(28, 23);
            this.ReduceSpeedBttn.TabIndex = 4;
            this.ReduceSpeedBttn.Text = "-";
            this.ReduceSpeedBttn.UseVisualStyleBackColor = true;
            this.ReduceSpeedBttn.Click += new System.EventHandler(this.ReduceSpeedBttn_Click);
            // 
            // IncreaseBttn
            // 
            this.IncreaseBttn.Location = new System.Drawing.Point(53, 117);
            this.IncreaseBttn.Name = "IncreaseBttn";
            this.IncreaseBttn.Size = new System.Drawing.Size(28, 23);
            this.IncreaseBttn.TabIndex = 5;
            this.IncreaseBttn.Text = "+";
            this.IncreaseBttn.UseVisualStyleBackColor = true;
            this.IncreaseBttn.Click += new System.EventHandler(this.IncreaseBttn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 961);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SolarSystem";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Timer modelTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MassOfTheSun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateBttn;
        private System.Windows.Forms.Button IncreaseBttn;
        private System.Windows.Forms.Button ReduceSpeedBttn;
        private System.Windows.Forms.Label label2;
    }
}

