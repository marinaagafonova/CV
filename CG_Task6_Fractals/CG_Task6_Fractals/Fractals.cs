using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FractalsLibrary;
using FractalsLibrary.NewM;

namespace CG_Task6_Fractals
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            if(!SierpinskiRB.Checked)
                SierpinskiToolsGB.Hide();
            if (!JuliaRB.Checked)
                JuliaTools.Hide();
            if (!MandelbrotRB.Checked)
                SwitchFractalGB.Hide();
            levelOfTriangle = Convert.ToInt32(LevelNUD.Value);
            Jp = Convert.ToDouble(JpTB.Text);
            Jq = Convert.ToDouble(JqTB.Text);
            Domain = new ParamForJandM(-2.0, 2.0, -2.0, 2.0);
            nwM = new NewMandelbrot(Width, Height, Domain);
            nwM.Start();
        }


        Bitmap img;
        int levelOfTriangle;
        double Jp, Jq;
        ParamForJandM Domain;
        NewMandelbrot nwM;


        private void DrawJulia()
        {
            Julia fr = new Julia(Domain);
            fr.Draw(img, Jp, Jq);
        }
        private void CreateNewDomain(TextBox xmin, TextBox xmax, TextBox ymin, TextBox ymax)
        {
            Domain = new ParamForJandM(Convert.ToDouble(xmin.Text), Convert.ToDouble(xmax), Convert.ToDouble(ymin.Text), Convert.ToDouble(ymax.Text));
        }
        private void DrawTriangle(Graphics g, int Width, int Height)
        {
            const float margin = 10;
            PointF topPoint = new PointF(Width / 2f, margin);
            PointF leftPoint = new PointF(margin, Height - margin);
            PointF rightPoint = new PointF(Width - margin, Height - margin);
            Sierpinski srFract = new Sierpinski();
            srFract.DrawTriangle(g, levelOfTriangle, topPoint, leftPoint, rightPoint);
        }
        
        private void DrawMandelbrot(Graphics g)
        {
            Mandelbrot mFrac = new Mandelbrot(Domain);
            if (SimpleMFracRB.Checked)
                mFrac.Draw(img);
            else
            {
                nwM.Update(g);
            }
        }
        private void Fractals_Paint(object sender, PaintEventArgs e)
        {
            if(JuliaRB.Checked)
            {
                img = new Bitmap(Width, Height);
                DrawJulia();
                e.Graphics.DrawImage(img, 220, 0);

            }
            if(MandelbrotRB.Checked)
            {
                img = new Bitmap(Width, Height);
                DrawMandelbrot(e.Graphics);
                if(SimpleMFracRB.Checked)
                e.Graphics.DrawImage(img, 220, 0);
               
            }
            if (SierpinskiRB.Checked)
            {
                DrawTriangle(e.Graphics, Width, Height);
            }
        }

        private void SierpinskiRB_CheckedChanged(object sender, EventArgs e)
        {
            if (SierpinskiRB.Checked)
            {
                SierpinskiToolsGB.Show();
                Cursor = Cursors.Default;
            }
            else
                SierpinskiToolsGB.Hide();
            Invalidate();
        }

        private void LevelNUD_ValueChanged(object sender, EventArgs e)
        {
            levelOfTriangle = Convert.ToInt32(LevelNUD.Value);
            Invalidate();
        }

        private void JuliaRB_CheckedChanged(object sender, EventArgs e)
        {
            if (JuliaRB.Checked)
            {
                JuliaTools.Show();
                Cursor = Cursors.Default;
            }
            else
                JuliaTools.Hide();
            Invalidate();
        }

        private void MandelbrotRB_CheckedChanged(object sender, EventArgs e)
        {
            if (MandelbrotRB.Checked)
                SwitchFractalGB.Show();
            else
                SwitchFractalGB.Hide();
            if(SimpleMFracRB.Checked)
                Cursor = Cursors.Default;
            Invalidate();
        }

        private void JpTB_Enter(object sender, EventArgs e)
        {
            try
            {
                Jp = Convert.ToDouble(JpTB.Text);
                Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SimpleMFracRB_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Domain.Xmin = Convert.ToDouble(textBox1.Text);
            Invalidate();
        }

       

        private void YminTB_Enter(object sender, EventArgs e)
        {
            Domain.Ymin = Convert.ToDouble(YminTB.Text);
            Invalidate();

        }

        private void XMaxTB_Enter(object sender, EventArgs e)
        {
            Domain.Xmax = Convert.ToDouble(XMaxTB.Text);
            Invalidate();

        }

        private void YMaxTB_Enter(object sender, EventArgs e)
        {
            Domain.Ymax = Convert.ToDouble(YMaxTB.Text);
            Invalidate();

        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (nwM.action && e.Button == MouseButtons.Left) 
            {
                nwM.xe = e.X; 
                nwM.ye = e.Y;
                nwM.rectangle = true; 
                Invalidate();  
            }
        }

        private void MainForm_MouseEnter(object sender, EventArgs e)
        {
            if(ColouredMFracRB.Checked)
            Cursor = Cursors.Cross;
        }

        private void MainForm_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;

        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            int z, w;

            if (nwM.action)
            {
                nwM.xe = e.X;
                nwM.ye = e.Y;
                if (nwM.xs > nwM.xe)
                {
                    z = nwM.xs;
                    nwM.xs = nwM.xe;
                    nwM.xe = z;
                }
                if (nwM.ys > nwM.ye)
                {
                    z = nwM.ys;
                    nwM.ys = nwM.ye;
                    nwM.ye = z;
                }
                w = (nwM.xe - nwM.xs);
                z = (nwM.ye - nwM.ys);
                if ((w < 2) && (z < 2))
                    nwM.InitValues();
                else
                {
                    if (((float)w > (float)z * nwM.xy)) nwM.ye = (int)((float)nwM.ys + (float)w / nwM.xy);
                    else nwM.xe = (int)((float)nwM.xs + (float)z * nwM.xy);
                    nwM.xende = nwM.xstart + nwM.xzoom * (double)nwM.xe;
                    nwM.yende = nwM.ystart + nwM.yzoom * (double)nwM.ye;
                    nwM.xstart += nwM.xzoom * (double)nwM.xs;
                    nwM.ystart += nwM.yzoom * (double)nwM.ys;
                }
                nwM.xzoom = (nwM.xende - nwM.xstart) / (double)nwM.x1;
                nwM.yzoom = (nwM.yende - nwM.ystart) / (double)nwM.y1;
                nwM.Mandelbrot();
                nwM.rectangle = false;
                Invalidate();  
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (nwM.action && e.Button == MouseButtons.Left)
            {
                nwM.xs = e.X; 
                nwM.ys = e.Y; 
            }
        }

        private void JqTB_Enter(object sender, EventArgs e)
        {
            try
            {
                Jq = Convert.ToDouble(JqTB.Text);
                Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
