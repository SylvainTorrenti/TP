﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    internal class Garage : Company
    {
        #region Attribute
        private List<Car> _Cars = new List<Car>();
        private List<Mechanic> _Mechanics = new List<Mechanic>();
        #endregion
        #region Get & Set List<Car>
        public List<Car> Cars { get => _Cars; set => _Cars = value; }
        #endregion
        #region Get & Set List<Mechanic>
        internal List<Mechanic> Mechanics { get => _Mechanics; set => _Mechanics = value; } 
        #endregion
        #region Constructor
        public Garage(int sIRET, string name) : base(sIRET, name)
        {
        }
        #endregion
        #region Method
        public void AddCar(Car Car)
        {
            Cars.Add(Car);
        }
        public void RemoveCar(Car Car)
        {
            Cars.Remove(Car);
        }
        public void AddMechanic(Mechanic mechanic)
        {
            Mechanics.Add(mechanic);
        }
        public void RemoveMechanic(Mechanic mechanic)
        {
            Mechanics.Remove(mechanic);
        }
        public void AssignMechanic(Mechanic mechanic, Car car)
        {
            mechanic.AddCarMec(car);
        }
        public void Print()
        {
            Console.WriteLine($"Le numero de SIRET est : {SIRET}");
            Console.WriteLine($"Le nom de l'entreprise est : {Name}");
            Console.WriteLine("Liste des Voitures:");
            Console.WriteLine("");
            if (Cars.Count <= 0)
            {
                Console.WriteLine("Ce garage ne posséde pas de voiture.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Liste des Voitures:");
                Console.WriteLine("");
                for (int i = 0; i < Cars.Count; i++)
                {
                    Cars.ElementAt(i).PrintWithoutOwner();
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
            }
        }
        public void WithdrawCar(Garage garage, Car car, Customer customer,Mechanic mechanic)
        {
            if (customer.Cars.Contains(car))
            {
                garage.Cars.Remove(car);
                mechanic.RemoveCarMec(car);
            }
            else
            {
                Console.WriteLine("La voiture n'appartient pas au client");
            }
            
        }
        #endregion
    }
}