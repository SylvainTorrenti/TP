using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
        #region attributes
        private string _Name;
        private string _FirstName;
        private int _Age;
        private List<Car> _Cars = new List<Car>();
        #endregion
        #region Get & Set Name
        /// <summary>
        /// Name of Person
        /// </summary>
        public string Name { get => _Name; set => _Name = value; }
        #endregion
        #region Get & Set FirstName
        /// <summary>
        /// FirstName of Person
        /// </summary>
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        #endregion
        #region Get & Set Age
        /// <summary>
        /// Age of Person
        /// </summary>
        public int Age { get => _Age; set => _Age = value; }
        #endregion
        #region Get & Set List<Car>
        /// <summary>
        /// List<Car> of Person
        /// </summary>
        internal List<Car> Cars { get => _Cars; set => _Cars = value; } 
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
            Console.WriteLine("Voitures:");
            Console.WriteLine("");
            for (int i = 0; i < this.Cars.Count; i++)
            {
                this.Cars.ElementAt(i).PrintWithoutOwner();
                Console.WriteLine("");
                Console.WriteLine("");
            }
            
        }
        /// <summary>
        /// Method to add car
        /// </summary>
        /// <param name="Car">Add car to a Person</param>
        public void AddCar(Car Car)
        {
            Cars.Add(Car);
        }
        /// <summary>
        /// Method to remove car
        /// </summary>
        /// <param name="car">Remove car from a Person</param>
        public void RemoveCar(Car car)
        {
            Cars.Remove(car);
        }
        /// <summary>
        /// Surcharge methode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
        #endregion


    }
}