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
        /// <summary>
        /// Name of the person
        /// </summary>
        private string Name;
        /// <summary>
        /// First name of the person
        /// </summary>
        private string FirstName;
        /// <summary>
        /// Age of the person
        /// </summary>
        private int Age;
        /// <summary>
        /// person’s car list
        /// </summary>
        private List<Car> Cars = new List<Car>();
        #endregion
        #region Get & Set Name
        /// <summary>
        /// Get Name
        /// </summary>
        /// <returns>Name</returns>
        public string GetName()
        {
            return Name;
        }
        /// <summary>
        /// Set Name
        /// </summary>
        /// <param name="Name">Name</param>
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        #endregion
        #region Get & Set FirstName
        /// <summary>
        /// Get FirstName
        /// </summary>
        /// <returns>FirstName</returns>
        public string GetFirstName()
        {
            return FirstName;
        }
        /// <summary>
        /// Set FirstName
        /// </summary>
        /// <param name="FirstName">FirstName</param>
        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }
        #endregion
        #region Get & Set Age
        /// <summary>
        /// Get Age
        /// </summary>
        /// <returns>Age</returns>
        public int GetAge()
        {
            return Age;
        }
        /// <summary>
        /// Set Age
        /// </summary>
        /// <param name="Age">Age</param>
        public void SetAge(int Age)
        {
            this.Age = Age;
        }
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