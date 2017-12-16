using System;
using System.Text;

namespace CourseWork
{
    /// <summary>
    /// The modified Saastamoinen model. Estimates the path delay 
    /// imposed to electro-magnetic signals by the troposphere.
    /// In the consructor is crreated a new instance with
    /// altitude of receiver position (date of Minsk).
    /// </summary>
    public class NeilModel
    {
        public double Altitude { get; private set; }

        public NeilModel()
        {
            Altitude = 281;
        }

        /// <summary>
        /// Method calculate hidrostatic delay with parameters of atmosphere and reseiver position.
        /// </summary>
        /// <returns>Returns hidrostatic delay value</returns>
        public double CalculateHidrostaticDelay()
        {
            return  Math.Pow(1.013, 2.27) * Math.Pow(Math.E, -0.116 * 0.001 * Altitude);
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
            StringBuilder sb = new StringBuilder();
            sb.Append("NeilModel: ").Append(" " + CalculateHidrostaticDelay()).Append(" " + CalculateWetDelay()).Append(" " + CalculateTroposphericDelay());
            return sb.ToString();
        }
    }
}
