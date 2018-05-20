using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroposphericDelayApplication.Models
{
    public class HopfieldModel
    {
        public Atmosphere atmosphere;
        public double Altitude { get; private set; }
        public double Hd { get; private set; }

        public HopfieldModel()
        {
            atmosphere = new Atmosphere();
            Altitude = 281;
            Hd = 148.98 * (atmosphere.Temperature - 4.12) + Altitude;
        }

        public HopfieldModel(double altitude, Atmosphere atmosphere)
        {
            this.atmosphere = atmosphere;
            Altitude = altitude;
            Hd = 148.98 * (atmosphere.Temperature - 4.12) + Altitude;
        }

        /// <summary>
        /// Method calculate hidrostatic delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateHidrostaticDelay()
        {
            return Math.Pow(10, -6) * atmosphere.Pressure / atmosphere.Temperature * (Hd - Altitude) / 5 * 80;
        }


        /// <summary>
        /// Method calculate wet delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateWetDelay()
        {
            return Math.Pow(10, -6) * atmosphere.PartialPressure / atmosphere.Temperature * (Hd - Altitude) / 5 * atmosphere.Temperature * 0.4;
        }

        /// <summary>
        /// Method calculate tropospheric delay.
        /// </summary>
        /// <returns>Returns tropospheric delay value</returns>
        public double CalculateTroposphericDelay()
        {
            return CalculateHidrostaticDelay() + CalculateWetDelay();
        }

        public override string ToString()
        {
            return CalculateTroposphericDelay().ToString();
        }
    }
}
