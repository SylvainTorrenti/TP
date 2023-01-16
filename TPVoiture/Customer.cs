using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    internal class Customer : Person
    {
        #region Attribute
        private List<Car> _Cars = new List<Car>();
        #endregion
        #region Get & Set List<Car>
        internal List<Car> Cars { get => _Cars; set => _Cars = value; }
        #endregion
        #region Constructor
        public Customer(string name, string firstName, int age) : base(name, firstName, age)
        {
        }
        #endregion
        #region Method
        public void AddCar(Car Car)
        {
            Cars.Add(Car);
        }
        public void WithdrawCar(Garage garage, Car car)
        {
            garage.Cars.Remove(car);
        }
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
        #endregion
    }
}
