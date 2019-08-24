namespace Task5
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
            this.DrawTimer = new System.Windows.Forms.Timer(this.components);
            this.ChangeTimer = new System.Windows.Forms.Timer(this.components);
            this.result = new System.Windows.Forms.PictureBox();
            this.ReloadModelBttn = new System.Windows.Forms.Button();
            this.AddBusBttn = new System.Windows.Forms.Button();
            this.AddPassengerBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.result)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawTimer
            // 
            this.DrawTimer.Interval = 10;
            this.DrawTimer.Tick += new System.EventHandler(this.DrawTimer_Tick);
            // 
            // ChangeTimer
            // 
            this.ChangeTimer.Tick += new System.EventHandler(this.ChangeTimer_Tick);
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Location = new System.Drawing.Point(0, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(1884, 961);
            this.result.TabIndex = 0;
            this.result.TabStop = false;
            // 
            // ReloadModelBttn
            // 
            this.ReloadModelBttn.Location = new System.Drawing.Point(24, 18);
            this.ReloadModelBttn.Name = "ReloadModelBttn";
            this.ReloadModelBttn.Size = new System.Drawing.Size(84, 23);
            this.ReloadModelBttn.TabIndex = 1;
            this.ReloadModelBttn.Text = "ReloadModel";
            this.ReloadModelBttn.UseVisualStyleBackColor = true;
            this.ReloadModelBttn.Click += new System.EventHandler(this.ReloadModelBttn_Click);
            // 
            // AddBusBttn
            // 
            this.AddBusBttn.Location = new System.Drawing.Point(24, 56);
            this.AddBusBttn.Name = "AddBusBttn";
            this.AddBusBttn.Size = new System.Drawing.Size(75, 23);
            this.AddBusBttn.TabIndex = 2;
            this.AddBusBttn.Text = "AddBus";
            this.AddBusBttn.UseVisualStyleBackColor = true;
            this.AddBusBttn.Click += new System.EventHandler(this.AddBusBttn_Click);
            // 
            // AddPassengerBttn
            // 
            this.AddPassengerBttn.Location = new System.Drawing.Point(24, 85);
            this.AddPassengerBttn.Name = "AddPassengerBttn";
            this.AddPassengerBttn.Size = new System.Drawing.Size(84, 23);
            this.AddPassengerBttn.TabIndex = 3;
            this.AddPassengerBttn.Text = "AddPassenger";
            this.AddPassengerBttn.UseVisualStyleBackColor = true;
            this.AddPassengerBttn.Click += new System.EventHandler(this.AddPassengerBttn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.AddPassengerBttn);
            this.Controls.Add(this.AddBusBttn);
            this.Controls.Add(this.ReloadModelBttn);
            this.Controls.Add(this.result);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer DrawTimer;
        private System.Windows.Forms.Timer ChangeTimer;
        private System.Windows.Forms.PictureBox result;
        private System.Windows.Forms.Button ReloadModelBttn;
        private System.Windows.Forms.Button AddBusBttn;
        private System.Windows.Forms.Button AddPassengerBttn;
    }
}

