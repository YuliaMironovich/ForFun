using System;
using System.Text;

namespace CourseWork
{
    /// <summary>
    /// The modified Saastamoinen model. Estimates the path delay 
    /// imposed to electro-magnetic signals by the troposphere.
    /// In the consructor is crreated a new instance with parameters of standart atmosphere,
    /// altitude of receiver position (date of Minsk).
    /// </summary>
    public class BlackModel
    {
        public StandartAtmosphere atmosphere;
        public double Altitude { get; private set; }

        public BlackModel()
        {
            atmosphere = new StandartAtmosphere();
            Altitude = 281;
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
            return 8.952 / ( atmosphere.Temperature * atmosphere.Temperature) * Altitude * Math.Pow(Math.E, -37.2465 + 0.256908 * 0.001 * atmosphere.Temperature * atmosphere.Temperature);
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
            StringBuilder sb = new StringBuilder();
            sb.Append("BlackModel: ").Append(" " + CalculateHidrostaticDelay()).Append(" " + CalculateWetDelay()).Append(" " + CalculateTroposphericDelay());
            return sb.ToString();
        }
    }
}
