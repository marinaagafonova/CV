using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolarSystemBL;
namespace CG_Lab5_Animation_Solar_System
{
    public partial class MainForm : Form
    {
        private SolarSystem sl;
        DateTime lasttime = DateTime.Now;
        SolarSystem1 sl1;
        public MainForm()
        {
            InitializeComponent();
            sl = new SolarSystem(Width, Height);
            sl.Sun = new Planet(new Vector(Width / 2, Height / 2), 1.98855 * Math.Pow(10, 30), 35, Brushes.Yellow, 0, 0, 0);
            sl.Planets = new List<Planet>
            {
                new Planet(new Vector(Width / 2, 330), 3.285*Math.Pow(10, 23), 10, Brushes.Red, 0.57910*Math.Pow(10, 11), 7.990986 *  Math.Pow(10, -7), 60), // Mercury
                new Planet(new Vector(Width / 2, 250), 5.972*Math.Pow(10, 24), 20, Brushes.Blue, 1.496*Math.Pow(10, 11), 1.990986 *  Math.Pow(10, -7), 150) //Earth
            };
            sl.ResetState();


            sl1 = new SolarSystem1();
            sl1.Planets.Add(new Planet1(540, 269, Height / 2 - 269, 6.84));
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            float dt = 0.001f * (currentTime - lasttime).Milliseconds;
            //sl.Update(dt);
            lasttime = currentTime;
            Invalidate();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.background, 0, 0);
            sl.Start(e.Graphics);

        }

        private void modelTimer_Tick(object sender, EventArgs e)
        {
           
        }

        private void MassOfTheSun_TextChanged(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(MassOfTheSun.Text);
            sl.UpdateFromUserInput(input);
        }

        private void UpdateBttn_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(MassOfTheSun.Text);
            sl.UpdateFromUserInput(input);
        }

        private void IncreaseBttn_Click(object sender, EventArgs e)
        {
            sl.ChangeSpeed(true);
        }

        private void ReduceSpeedBttn_Click(object sender, EventArgs e)
        {
            sl.ChangeSpeed(false);
        }
    }
}
