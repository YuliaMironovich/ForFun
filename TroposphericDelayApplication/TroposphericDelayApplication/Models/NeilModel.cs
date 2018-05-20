using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroposphericDelayApplication.Models
{
    public class NeilModel
    {
        public double Altitude { get; private set; }

        public NeilModel()
        {
            Altitude = 281;
        }

        public NeilModel(double altitude)
        {
            Altitude = altitude;
        }

        /// <summary>
        /// Method calculate hidrostatic delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateHidrostaticDelay()
        {
            return Math.Pow(1.013, 2.27) * Math.Pow(Math.E, -0.116 * 0.001 * Altitude);
        }

        /// <summary>
        /// Method calculate wet delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateWetDelay()
        {
            return 0.1;
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
