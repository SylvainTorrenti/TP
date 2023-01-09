using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    /// <summary>
    /// class used to create cars
    /// </summary>
    internal class Car
    {
        #region Attribute

        /// <summary>
        /// Registartion of the car
        /// </summary>
        public string Registration;
        /// <summary>
        /// Model of the car
        /// </summary>
        public string Model;
        /// <summary>
        /// Brand of the car
        /// </summary>
        public string Brand;
        /// <summary>
        /// How many klm the car has made
        /// </summary>
        public int KLM;
        /// <summary>
        /// First date when the car has been release
        /// </summary>
        public DateTime OriginalInServiceDate;
        /// <summary>
        /// Power of the car in horsepower
        /// </summary>
        public int Power;
        /// <summary>
        /// Personal owner of the car
        /// </summary>
        public Person Owner;
        #endregion
        #region Methode
        /// <summary>
        /// method for displaying Car information
        /// </summary>

        public void Print()
        {

        } 
        #endregion
    }
}
