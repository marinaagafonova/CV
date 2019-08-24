using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3DFunctionBL;

namespace CG_Lab4_3DFunction_Graphs
{
    public partial class MainForm : Form
    {
        
        private Scene scene;
        Function function;
        int k;
        //private Scene corsystem;
        private Camera camera;
        //IFunction f;
        int split;
        Point last = new Point();
        public MainForm()
        {
            InitializeComponent();
            scene = new Scene(1);
            //corsystem = new Scene(Color.Black, 3);
            FunctionType.Items.AddRange(new List<IFunction>()
            {
                new Fm1(),
                new F0(),
                new F1(),
                new F2(),
                new F3(),
                new F4(),
                new F5(),
                new F6(),
                new F7(),
                new F8()

            }.ToArray());
            k = 1;
            split = 1;
            //f.Split = new int[] { xmin, xmax, ymin, ymax };
            //xmin = Convert.ToInt32(XminNUD.Value);
            //xmax = Convert.ToInt32(XmaxNUD.Value);
            //ymin = Convert.ToInt32(YminNUD.Value);
            //ymax = Convert.ToInt32(YmaxNUD.Value);

            //scene.Models.Add(new Function(f, new int[] { xmin, xmax, ymin, ymax }, Color.Blue));
            function = new Function(null, new int[] { -5 * split, 5 * split, -5 * split, 5 * split }, Color.LightBlue);
            FunctionType.SelectedIndex = 0;
            IFunction f = (IFunction)FunctionType.SelectedItem;
            
            function.Split = 1;
            scene.Models.Add(function);
            scene.Models[0].ColorL = function.ColorL;
            camera = new Camera();
            scene.Models.Add(new Line3D(new Vector(0, 0, 0), new Vector(1 * split, 0, 0), Color.Black));
            scene.Models.Add(new Line3D(new Vector(0, 0, 0), new Vector(0, 1 * split, 0), Color.Black));
            scene.Models.Add(new Line3D(new Vector(0, 0, 0), new Vector(0, 0, 1 * split), Color.Black));
        }
       

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
           
          
            _3DFunctionBL.Screen scr = new _3DFunctionBL.Screen(Size,
                new Rectangle(-2*k, -2*k, 5*k, 5*k));
            Bitmap bmp = new Bitmap(scr.Size.Width, scr.Size.Height);
            scene.DrawAll(bmp, camera,
                scr);
            //corsystem.DrawAll(bmp, camera,
            //    scr);
            e.Graphics.DrawImage(bmp, 0, 0);
            bmp.Dispose();
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = new Point();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left))
                last = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button.HasFlag(MouseButtons.Left) && !last.IsEmpty)
            {
                float dx = e.Location.X - last.X;
                float dy = e.Location.Y - last.Y;
                camera.View =
                    Matrix.Rotate(1, dx * (float)Math.PI / 180) *
                    Matrix.Rotate(0, dy * (float)Math.PI / 180) *
                    camera.View;
                Invalidate();
                last = e.Location;
            }
            last = e.Location;
        }

        private void FunctionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            IFunction f = (IFunction)FunctionType.SelectedItem;
            //scene.Models.Remove(function);
            if (function != null)
            {
                function.F = f;
            }
            /*else
                function = new Function(f);
            if(scene.Models.Count > 0)
                scene.Models[0] = function;*/
            //if (scene.Models.Count > )
            //    scene.Models[0].ColorL = function.ColorL;
            //else
            //    scene.Models[3].ColorL = function.ColorL;
            Invalidate();
        }

        private void XminNUD_ValueChanged(object sender, EventArgs e)
        {
            function.Domain[0] = Convert.ToInt32(XminNUD.Value)*split;
            scene.Models[0] = function;
            //scene.Models[3] = Convert.ToInt32(XminNUD.Value);
            //xmin = Convert.ToInt32(XminNUD.Value);
            Invalidate();
        }

        private void XmaxNUD_ValueChanged(object sender, EventArgs e)
        {
            function.Domain[1] = Convert.ToInt32(XmaxNUD.Value)*split;
            scene.Models[0] = function;

            //xmax = Convert.ToInt32(XmaxNUD.Value);
            Invalidate();
        }

        private void YminNUD_ValueChanged(object sender, EventArgs e)
        {
            function.Domain[2] = Convert.ToInt32(YminNUD.Value)*split;
            scene.Models[0] = function;

            //ymin = Convert.ToInt32(YminNUD.Value);
            Invalidate();
        }

        private void YmaxNUD_ValueChanged(object sender, EventArgs e)
        {
            function.Domain[3] = Convert.ToInt32(YmaxNUD.Value)*split;
            scene.Models[0] = function;

            //ymax = Convert.ToInt32(YmaxNUD.Value);
            Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value != 0)
                    k = trackBar1.Value;
            else
                k = 1;
            Invalidate();
        }

        private void SplitNUD_ValueChanged(object sender, EventArgs e)
        {
            function.Split = 1.0/Convert.ToDouble(SplitNUD.Value);
            scene.Models[0] = function;
            Invalidate();
        }
    }
}
