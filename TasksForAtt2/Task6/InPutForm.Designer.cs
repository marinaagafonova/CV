namespace Task6
{
    partial class InPutForm
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
            this.BooksDGV = new System.Windows.Forms.DataGridView();
            this.DoBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BooksDGV
            // 
            this.BooksDGV.AllowUserToAddRows = false;
            this.BooksDGV.AllowUserToDeleteRows = false;
            this.BooksDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BooksDGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.BooksDGV.Location = new System.Drawing.Point(0, 0);
            this.BooksDGV.Name = "BooksDGV";
            this.BooksDGV.Size = new System.Drawing.Size(475, 421);
            this.BooksDGV.TabIndex = 0;
            // 
            // DoBttn
            // 
            this.DoBttn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DoBttn.Location = new System.Drawing.Point(0, 427);
            this.DoBttn.Name = "DoBttn";
            this.DoBttn.Size = new System.Drawing.Size(475, 23);
            this.DoBttn.TabIndex = 1;
            this.DoBttn.Text = "OK";
            this.DoBttn.UseVisualStyleBackColor = true;
            this.DoBttn.Click += new System.EventHandler(this.DoBttn_Click);
            // 
            // InPutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.DoBttn);
            this.Controls.Add(this.BooksDGV);
            this.Name = "InPutForm";
            this.Text = "InPutFrom";
            ((System.ComponentModel.ISupportInitialize)(this.BooksDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BooksDGV;
        private System.Windows.Forms.Button DoBttn;
    }
}