using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    /// <summary>
    /// class used to create person
    /// </summary>
    internal class Person
    {
        #region Attribute
        /// <summary>
        /// Name of the person
        /// </summary>
        public string Name;
        /// <summary>
        /// First name of the person
        /// </summary>
        public string FirstName;
        /// <summary>
        /// Age of the person
        /// </summary>
        public int Age;
        /// <summary>
        /// person’s car list
        /// </summary>
        public List<Car> Cars = new List<Car>();
        #endregion
        #region Methode
        /// <summary>
        /// method for displaying Person information
        /// </summary>

        public void Print()
        {
            Console.WriteLine($"Nom : {Name}");
            Console.WriteLine($"Prenom : {FirstName}");
            Console.WriteLine($"Age : {Age}");
        } 
        #endregion
    }
}
