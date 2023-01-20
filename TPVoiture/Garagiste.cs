using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPObjet;
using TPVoiture;

namespace TPObjet
{
    /// <summary>
    /// Représente un mécanicien dans le garage
    /// </summary>
    internal class Garagiste : Person
    {
        /// <summary>
        /// Liste des voiture à réparer par le garagiste
        /// </summary>
        private List<Vehicle> _vehicleAReparer = new List<Vehicle>();

        public int Skill { get; set; }

        /// <summary>
        /// Constructeur de Garagiste
        /// </summary>
        /// <param name="name"> Nom du Garagiste</param>
        /// <param name="firstName">Prénom du Garagiste</param>
        /// <param name="age">Age du Garagiste</param>
        public Garagiste(string name, string firstName, int age, int skill)
        : base(name, firstName, age)
        {           
            Skill = skill;
        }

        /// <summary>
        /// Permet d'ajouter une tache au garagiste
        /// </summary>
        /// <param name="car">La voiture à réparer</param>
        public void AjouterUnVehiculeAReparer(Vehicle vehicle)
        {
            _vehicleAReparer.Add(vehicle);
        }

        /// <summary>
        /// Permert de valider les réparations d'une voiture
        /// </summary>
        /// <param name="car">Voiture réparer</param>
        public void ReparationsFinis(Vehicle vehicle)
        {
            vehicle.Reparer();
            _vehicleAReparer.Remove(vehicle);
        }
    }
}

