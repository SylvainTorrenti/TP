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
        private static int _cptInstance = 0;
        private static List<int> _Ages = new List<int>();
        private string _name;
        private string _firstName;
        private int _age;
        private List<Car> _Cars = new List<Car>();
        #endregion
        #region Constructor
        public Person(string name, string firstName, int age)
        {
            CptInstance++;
            _name = name;
            _firstName = firstName;
            _age = age;
            _Ages.Add(age);
        }
        #endregion
        #region Get & Set Name
        /// <summary>
        /// Name of Person
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        #endregion
        #region Get & Set FirstName
        /// <summary>
        /// FirstName of Person
        /// </summary>
        public string FirstName { get => _firstName; set => _firstName = value; }
        #endregion
        #region Get & Set Age
        /// <summary>
        /// Age of Person
        /// </summary>
        public int Age { get => _age; set => _age = value; }
        #endregion
        #region Get & Set List<Car>
        /// <summary>
        /// List<Car> of Person
        /// </summary>
        internal List<Car> Cars { get => _Cars; set => _Cars = value; }
        #endregion
        #region Get & Set CptInstance
        public static int CptInstance { get => _cptInstance; private set => _cptInstance = value; }
        #endregion
        #region Get & Set List<int> Ages
        private static List<int> Ages { get => _Ages; set => _Ages = value; } 
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
            if (Cars.Count <= 0)
            {
                Console.WriteLine("Cette personne ne posséde pas de voiture.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Liste des Voitures:");
                Console.WriteLine("");
                for (int i = 0; i < this.Cars.Count; i++)
                {
                    Cars.ElementAt(i).PrintWithoutOwner();
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
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
        /// <summary>
        /// Calculate average age
        /// </summary>
        /// <returns></returns>
        public static double AverageAges()
        {
            return (Ages.Count > 0) ? Ages.Average() : 0.0d;
        }
        /// <summary>
        /// Get the number of instance
        /// </summary>
        /// <returns></returns>
        public static int GetInstance()
        {
            return CptInstance;
        }
        #endregion
    }
}