using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystemBL
{
    public class Planet1
    {
        protected double speed;
        protected int distanceToSun;
        protected double angle;
        protected Vector Location { get; set; }
        Vector startLocation;

        public int X { get; set; }
        public int Y { get; set; }

        public Planet1(int x, int y, int rotateRadius, double speed)
        {
            this.speed = speed;
            angle = -190;
            distanceToSun = rotateRadius;
            Location = new Vector(x, y);
            startLocation = Location;
        }
        public void Move()
        {
            angle += Math.PI / speed;
            X = 540 + (int)(distanceToSun * Math.Cos(angle));
            Y = 390 + (int)(distanceToSun * Math.Sin(angle));
            Location = new Vector(X, Y);

        }
    }
}
