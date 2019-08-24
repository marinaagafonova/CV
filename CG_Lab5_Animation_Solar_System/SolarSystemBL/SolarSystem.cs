using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SolarSystemBL
{
    //задавать радиусы планет, скорость вращения, радиусы, текстуры планет, вращение планеты

    
    public class SolarSystem
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Planet Sun { get; set; }
        public List<Planet> Planets { get; set; }
        double G = 6.67408 * Math.Pow(10, -11);
        double deltaT = 86.4;
        bool paused = false;
        const int CalculationsPerFrame = 1000;
        int numberCalculationsPerFrame;
        double MassOfSun = 1.98855 * Math.Pow(10, 30);
        double middleX;
        double middleY;
        public SolarSystem(float w, float h)
        {
            Width = w;
            Height = h;
            middleX = Math.Floor(Width / 2);
            middleY = Math.Floor(Height / 2);
            numberCalculationsPerFrame = CalculationsPerFrame;
        }
        
        public void ChangeSpeed(bool increase)
        {
            if (increase)
                numberCalculationsPerFrame *= 2;
            else
                numberCalculationsPerFrame /= 2;
        }
        public double  ComputeDictanceAcceleration(State state)
        {
            return state.distance.value * Math.Pow(state.angle.speed, 2) - (G * Sun.M) / Math.Pow(state.distance.value, 2);
        }
        public double ComputeAngleAcceleration(State state)
        {
            if (state.distance.value == 0) return 0;
            return -2.0 * state.distance.speed * state.angle.speed / state.distance.value;
        }
        public double NewValue(double currentValue, double derivative)
        {
            return currentValue + deltaT * derivative;
        }
        public void UpdatePosition(Planet planet)
        {
            if (paused) return;
            for (int i = 0; i < numberCalculationsPerFrame; i++)
                CalculateNewPosition(planet);
        }
        public void CalculateNewPosition(Planet planet)
        {
            double distanceAccelaration = ComputeDictanceAcceleration(planet.state);
            planet.state.distance.speed = NewValue(planet.state.distance.speed, distanceAccelaration);
            planet.state.distance.value = NewValue(planet.state.distance.value, planet.state.distance.speed);

            double angleAccelaration = ComputeAngleAcceleration(planet.state);
            planet.state.angle.speed = NewValue(planet.state.angle.speed, angleAccelaration);
            planet.state.angle.value = NewValue(planet.state.angle.value, planet.state.angle.speed);
            if (planet.state.angle.value > 2 * Math.PI)
                planet.state.angle.value = planet.state.angle.value % (2 * Math.PI);
        }
        public void UpdateFromUserInput(double solarMassMultiplier)
        {
            Sun.M = MassOfSun * solarMassMultiplier;
        }
       
        private Vector calculatePlanetPosition(double distance, double angle)
        {
           
            double centerX = Math.Cos(angle) * distance + middleX;
            double centerY = Math.Sin(-angle) * distance + middleY;
            return new Vector(centerX, centerY);
        }
        public void DrawOrbitalLine(Vector newEarthPosition, Planet planet, Graphics g)
        {
            if (planet.PreviousPosition == null)
            {
                planet.PreviousPosition = newEarthPosition;
                return;
            }
            if (!planet.PointIsInTheList(planet.Center))
            {
                planet.CollectOrbitPoints(planet.Center);
               
            }
               if(planet.Orbit.Count > 1)
                g.DrawCurve(Pens.White, planet.ConvertOrbitToPointF()); 
            planet.PreviousPosition = newEarthPosition;
        }
        public bool IsPlanetCollidedWithTheSun(Planet planet)
        {
            if (planet.Center == null)
                return false;
            int correctedSunsSize = /*SunSize*/(int)Sun.Radius - 20;
            double sunHalf = correctedSunsSize / 2;
            double sunLeft = middleX - sunHalf;
            double sunRight = middleX + sunHalf;
            double sunTop = middleY - sunHalf;
            double sunBottom = middleY + sunHalf;
            return (planet.Center.X >= sunLeft && planet.Center.X <= sunRight && planet.Center.Y >= sunTop && planet.Center.Y <= sunBottom);
        }
        
        public void DrawScene(double distance, double angle, Graphics g, Planet planet)
        {
            planet.Center = calculatePlanetPosition(distance, angle);
            //DrawEarth
            DrawOrbitalLine(planet.Center, planet, g);

            if (planet.Center != null)
            g.FillEllipse(planet.Br, (int)(planet.Center.X - planet.Radius), (int)(planet.Center.Y - planet.Radius), (float)(2 * planet.Radius), (float)(2 * planet.Radius));

            if (IsPlanetCollidedWithTheSun(planet))
            {
                paused = true;
            }
        }
        public void Animate(Planet planet, Graphics g)
        {
            UpdatePosition(planet);
            DrawScene(planet.ScaledDistance(), planet.state.angle.value, g, planet);
        }
        public void ResetState()
        {
            for (int i = 0; i < Planets.Count; i++)
            {
                Planets[i].ResetStateToInitialConditions();
            }
        }
        public void Start(Graphics g)
        {
            //g.Clear(Color.Black);
            g.FillEllipse(Sun.Br, (int)(Sun.Center.X - Sun.Radius), (int)(Sun.Center.Y - Sun.Radius), (float)(2 * Sun.Radius), (float)(2 * Sun.Radius));
            for (int i = 0; i < Planets.Count; i++)
            {
                Animate(Planets[i], g);
            }
        }




    }
}
