using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroposphericDelayApplication.Models
{
    public class Atmosphere
    {
        /// Default correction factor value. 
        public const double CORRECTION_FACTOR = 1.0;

        /// atmospheric pressure for Saemundsson formula (Pa). 
        public const double PRESSURE = 101000.0;

        ///Default temperature for Saemundsson formula  (K). 
        public const double TEMPERATURE = 283.0;

        ///ISA pressure (mBar).
        public const double STANDARD_PRESSURE = 1013.250;

        ///ISA partial pressure of water vapour (mBar).
        public const double STANDARD_PARTIAL_PRESSURE = 8.528;

        ///ISA temperature (K).
        public const double STANDARD_TEMPERATURE = 288.15;

        ///ISA humidity.
        public const double STANDARD_HUMIDITY = 0.5;

        /// Elevation min value to compute refraction (under the horizon).
        private const double MIN_ELEVATION = 0.0;

        ///Elevation max value to compute refraction (zenithal).
        private const double MAX_ELEVATION = 90;

        public double CoefficientRefraction { get; private set; }
        public double Temperature { get; private set; }
        public double Pressure { get; private set; }
        public double Humidity { get; private set; }
        public double PartialPressure { get; private set; }
        /// <summary>
        /// Create new standart instance of atmosphere.
        /// </summary>
        public Atmosphere()
        {
            Temperature = STANDARD_TEMPERATURE;
            Pressure = STANDARD_PRESSURE;
            Humidity = STANDARD_HUMIDITY;
            CoefficientRefraction = CORRECTION_FACTOR;
            PartialPressure = STANDARD_PARTIAL_PRESSURE;
        }

        /// <summary>
        /// Create instance with parameters of atmosphere.
        /// </summary>
        /// <param name="pressure">Pressure of atmosphere</param>
        /// <param name="temperature">Temperature of atmosphere</param>
        public Atmosphere(double pressure, double temperature, double humidity)
        {
            Pressure = pressure;
            Temperature = temperature;
            CoefficientRefraction = (pressure / PRESSURE) * (TEMPERATURE / temperature);
            Humidity = humidity;
            PartialPressure = STANDARD_PARTIAL_PRESSURE;
        }

        /// <summary>
        /// Compute the refraction angle from the (geometrical) elevation by the Saemundssen formula
        /// and correction of atmospheric parameters.
        /// </summary>
        /// <param name="elevation">Altitude</param>
        /// <returns>Returns refraction angle</returns>
        public double getRefraction(double elevation)
        {
            double refraction = 0.0;
            double degrees = ToDegrees(elevation);
            if (degrees > MIN_ELEVATION && degrees < MAX_ELEVATION)
            {
                double tmp = degrees + 10.3 / (degrees + 5.11);
                double preRef = 1.02 / Math.Tan(ToRadians(tmp));
                refraction = ToRadians(CoefficientRefraction * preRef);
            }
            return refraction;
        }

        /// <summary>
        /// Method convert to degrees.
        /// </summary>
        /// <param name="value">Value for convertation</param>
        /// <returns>Returns value in degrees</returns>
        public double ToDegrees(double value)
        {
            double degrees = (value * 180) / Math.PI;
            return degrees;
        }

        /// <summary>
        /// Method convert to radians.
        /// </summary>
        /// <param name="value">Value for convertation</param>
        /// <returns>Returns value in radians</returns>
        public double ToRadians(double value)
        {
            double radians = (value * Math.PI) / 180;
            return radians;
        }
    }
}
