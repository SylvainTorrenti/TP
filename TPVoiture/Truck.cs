using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TPObjet;

namespace TPVoiture
{
    internal class Truck : Vehicle
    {
        private string _registration;
        private static List<string> Registrations { get; } = new List<string>();

        /// <summary>
        /// Récupère la liste des plaques d'immatriculations
        /// </summary>
        /// <returns>Copie de la liste des plaques d'immatriculations de toutes les instances</returns>
        public static IEnumerable<string> GetRegistrations()
        {
            return Registrations.ToArray();
        }

        /// <summary>
        /// Immatriculation de la voiture
        /// </summary>
        public string Registration
        {
            get { return _registration; }
            set
            {
                if (Registrations.Contains(value))
                {
                    _registration = "";
                    Registrations.Remove(value);
                }
                //Registrations.Exists(
                //    (valeuritem) =>  {return SearchRegistrationWithChar(valeuritem, 'A'); });
                else
                {
                    Registrations.Add(value);
                    _registration = value;
                }
            }
        }

        /// <summary>
        /// Modèle de la voiture
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// Marque de la voiture
        /// </summary>
        public string Brand { get; private set; }

        /// <summary>
        /// Compteur kilométrique de la voiture
        /// </summary>
        public int KLM { get; private set; }

        /// <summary>
        /// Puissance de la voiture
        /// </summary>
        public int Power { get; private set; }
        public Truck(string registration, string model, string brand, int kLM, DateTime originalInServiceDate, int power, Person owner, bool aReparer, int damage) : base(originalInServiceDate, owner, aReparer, registration, damage)
        {
            Registration = registration;
            Model = model;
            Brand = brand;
            KLM = kLM;
            Power = power;

        }

        /// <summary>
        /// Calcul du temps de réparation du camion
        /// </summary>
        /// <param name="garagiste"></param>
        public override void ReparationTime(Garagiste garagiste)
        {
            double Time;
            Time = 2 * 2 - (garagiste.Skill / 100);
            Console.WriteLine($"Il faut {Time} heure à {garagiste.FirstName} {garagiste.Name} pour réparer le {Brand}{Model}");
        }
    }
}
