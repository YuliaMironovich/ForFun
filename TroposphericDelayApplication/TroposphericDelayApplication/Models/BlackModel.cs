using System;
using System.Text;

namespace TroposphericDelayApplication.Models
{
    public class BlackModel
    {
        public Atmosphere atmosphere;
        public double Altitude { get; private set; }

        public BlackModel()
        {
            atmosphere = new Atmosphere();
            Altitude = 281;
        }

        public BlackModel(double altitude, Atmosphere atmosphere)
        {
            this.atmosphere = atmosphere;
            Altitude = altitude;
        }

        /// <summary>
        /// Method calculate hidrostatic delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateHidrostaticDelay()
        {
            return 2.43 * (atmosphere.Pressure / 1013.25) * (atmosphere.Temperature - 3.96) / atmosphere.Temperature;
        }

        /// <summary>
        /// Method calculate wet delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateWetDelay()
        {
            return 8.952 / (atmosphere.Temperature * atmosphere.Temperature) * Altitude * Math.Pow(Math.E, -37.2465 + 0.256908 * 0.001 * atmosphere.Temperature * atmosphere.Temperature);
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
