using System;
using System.Text;

namespace TroposphericDelayApplication.Models
{
    public class SaastamoinenModel
    {
        public StandartAtmosphere atmosphere;
        public double Latitude { get; private set; }
        public double Altitude { get; private set; }

        public SaastamoinenModel()
        {
            atmosphere = new StandartAtmosphere();
            Latitude = 53.90;
            Altitude = 0.281;
        }

        public SaastamoinenModel(double latitude, double altitude)
        {
            atmosphere = new StandartAtmosphere();
            Latitude = latitude;
            Altitude = altitude;
        }

        /// <summary>
        /// Method calculate hidrostatic delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateHidrostaticDelay()
        {
            return 0.002277 * (1 + 0.0026 * Math.Cos(2 * atmosphere.ToRadians(Latitude)) +
                                      0.00028 * Altitude) * atmosphere.Pressure;
        }

        /// <summary>
        /// Method calculate wet delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateWetDelay()
        {
            return 0.002277 * (1255 / atmosphere.Temperature + 0.05) * atmosphere.PartialPressure;
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
            return $"Saastamoinen model: {CalculateTroposphericDelay().ToString()}";
        }
    }
}
