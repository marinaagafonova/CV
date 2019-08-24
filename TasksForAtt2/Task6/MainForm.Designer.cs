namespace Task6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.NewObjectBttn = new System.Windows.Forms.Button();
            this.MethodsCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConstructorsCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.InterfacesCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.PropertiesCB = new System.Windows.Forms.ComboBox();
            this.ClassesCB = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(286, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openDLLToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // openDLLToolStripMenuItem
            // 
            this.openDLLToolStripMenuItem.Name = "openDLLToolStripMenuItem";
            this.openDLLToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openDLLToolStripMenuItem.Text = "Open DLL";
            this.openDLLToolStripMenuItem.Click += new System.EventHandler(this.openDLLToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Methods Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewObjectBttn
            // 
            this.NewObjectBttn.Location = new System.Drawing.Point(77, 432);
            this.NewObjectBttn.Name = "NewObjectBttn";
            this.NewObjectBttn.Size = new System.Drawing.Size(135, 23);
            this.NewObjectBttn.TabIndex = 25;
            this.NewObjectBttn.Text = "Create New Object";
            this.NewObjectBttn.UseVisualStyleBackColor = true;
            this.NewObjectBttn.Click += new System.EventHandler(this.NewObjectBttn_Click);
            // 
            // MethodsCB
            // 
            this.MethodsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MethodsCB.FormattingEnabled = true;
            this.MethodsCB.Location = new System.Drawing.Point(77, 363);
            this.MethodsCB.Name = "MethodsCB";
            this.MethodsCB.Size = new System.Drawing.Size(121, 21);
            this.MethodsCB.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Methods";
            // 
            // ConstructorsCB
            // 
            this.ConstructorsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConstructorsCB.FormattingEnabled = true;
            this.ConstructorsCB.Location = new System.Drawing.Point(77, 296);
            this.ConstructorsCB.Name = "ConstructorsCB";
            this.ConstructorsCB.Size = new System.Drawing.Size(121, 21);
            this.ConstructorsCB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Constructors";
            // 
            // InterfacesCB
            // 
            this.InterfacesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InterfacesCB.FormattingEnabled = true;
            this.InterfacesCB.Location = new System.Drawing.Point(77, 221);
            this.InterfacesCB.Name = "InterfacesCB";
            this.InterfacesCB.Size = new System.Drawing.Size(121, 21);
            this.InterfacesCB.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Interfaces";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Properties";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(115, 54);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 17;
            this.ClassLabel.Text = "Class";
            // 
            // PropertiesCB
            // 
            this.PropertiesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropertiesCB.FormattingEnabled = true;
            this.PropertiesCB.Location = new System.Drawing.Point(77, 147);
            this.PropertiesCB.Name = "PropertiesCB";
            this.PropertiesCB.Size = new System.Drawing.Size(121, 21);
            this.PropertiesCB.TabIndex = 16;
            // 
            // ClassesCB
            // 
            this.ClassesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassesCB.FormattingEnabled = true;
            this.ClassesCB.Location = new System.Drawing.Point(77, 70);
            this.ClassesCB.Name = "ClassesCB";
            this.ClassesCB.Size = new System.Drawing.Size(121, 21);
            this.ClassesCB.TabIndex = 15;
            this.ClassesCB.SelectedIndexChanged += new System.EventHandler(this.ClassesCB_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(286, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NewObjectBttn);
            this.Controls.Add(this.MethodsCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConstructorsCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InterfacesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.PropertiesCB);
            this.Controls.Add(this.ClassesCB);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "BookShop";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDLLToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button NewObjectBttn;
        private System.Windows.Forms.ComboBox MethodsCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ConstructorsCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox InterfacesCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.ComboBox PropertiesCB;
        private System.Windows.Forms.ComboBox ClassesCB;
    }
}

