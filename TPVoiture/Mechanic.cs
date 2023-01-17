using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    internal class Mechanic : Person
    {
        #region Constructor
        public Mechanic(string name, string firstName, int age) : base(name, firstName, age)
        {
        }
        #endregion
        #region Method
        public void AddCarMec(Car Car)
        {
            Cars.Add(Car);
        }
        public void RemoveCarMec(Car Car)
        {
            Cars.Remove(Car);
        }
        public void Print()
        {
            Console.WriteLine($"Nom : {Name}");
            Console.WriteLine($"Prenom : {FirstName}");
            Console.WriteLine($"Age : {Age}");
            Console.WriteLine("Liste des Voitures en réparation:");
            Console.WriteLine("");
            if (Cars.Count <= 0)
            {
                Console.WriteLine("Cet garagiste ne répare pas de voiture.");
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < this.Cars.Count; i++)
                {
                    Cars.ElementAt(i).PrintWithoutOwner();
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }
    }
    #endregion
}

