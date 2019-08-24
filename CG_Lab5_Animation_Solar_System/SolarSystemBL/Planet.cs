using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystemBL
{
    //public struct InitialConditions //to properties
    //{
    //    public Distance distance;
    //    public Angle angle;
    //}
    public struct Distance
    {
        public double value;
        public double speed;
    }
    public struct Angle
    {
        public double value;
        public double speed;
    }
    public struct State //to properties
    {
        public Distance distance;
        public Angle angle;
    }
    struct Constants
    {
        public double DistanceFromSun;
        public double AngularVelocityMeterPerSecond;
    }
   
    public class Planet
    {
        public Vector Center { get; set; }
        public Vector PreviousPosition { get; set; }
        public double M { get; set; }
        public double Radius { get; set; }
        public Brush Br { get; set; }
        //from evgenii
        public State state;
        public State initialConditions; // операция внутри класса
        public int DistancePixel { get; set; }
        private Constants consts;
        public double ScaleFactor { get; set; }
        //end from evgenii
        public List<Vector> Orbit { get; set; }
        public Planet(Vector c, double m, float r, Brush br, double dFromSunM, double angularVelocity, int dPixel)
        {
            M = m;
            Radius = r;
            Center = c;
            Br = br;
            consts.DistanceFromSun = dFromSunM;
            //consts.AngularVelocityMeterPerSecond = angularVelocity;
            //angularVelocity = angularVelocity / rReal;
            DistancePixel = dPixel; //or = dPixel
            ScaleFactor = dFromSunM / DistancePixel;
            initialConditions.distance.value = dFromSunM;
            initialConditions.distance.speed = 0;
            initialConditions.angle.value = Math.PI / 6;
            initialConditions.angle.speed = angularVelocity;
            Orbit = new List<Vector>();
        }

        public bool PointIsInTheList(Vector point)
        {
            if (point == null)
                return true;
            return Orbit.Contains(point);
        }
        public void CollectOrbitPoints(Vector newp)
        {
            Orbit.Add(newp);
        }
        public void ResetStateToInitialConditions()
        {
            state = initialConditions;
        }
        public double ScaledDistance()
        {
            if (ScaleFactor == 0)
                return 0;
            return state.distance.value / ScaleFactor;
        }
        public PointF[] ConvertOrbitToPointF()
        {
            PointF[] output = new PointF[Orbit.Count];
            for(int i = 0; i < Orbit.Count; i++)
            {
                output[i] = new PointF((float)Orbit[i].X, (float)Orbit[i].Y); 
            }
            return output;
        }
    }
}
