using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TPObjet;

namespace TPVoiture
{
    internal class Vehicle
    {
        public DateTime OriginalInServiceDate { get; private set; }

        public Person Owner { get; private set; }

        public bool AReparer { get; private set; }

        public int Damage { get; set; }
        /// <summary>
        /// Liste de toutes les plaques d'immatriculations
        /// </summary>
        private static List<string> Registrations { get; set; } = new List<string>();

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
        private string _registration;

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




        private List<Garagiste> _garagistAssigne = new List<Garagiste>();
        public Vehicle(DateTime originalInServiceDate, Person owner, bool aReparer, string registration, int damage)
        {
            OriginalInServiceDate = originalInServiceDate;
            Owner = owner;
            AReparer = aReparer;
            Registration = registration;
            Damage = damage;
        }



        public void AjouterUnGaragiste(Garagiste garagiste)
        {
            _garagistAssigne.Add(garagiste);
        }
        public void AfficherLaPersonneEnCharge()
        {
            for (int i = 0; i < _garagistAssigne.Count; i++)
            {
                Console.WriteLine($"Le Garagiste en charge est : {_garagistAssigne.ElementAt(i).Name} {_garagistAssigne.ElementAt(i).FirstName}");
            }
        }
        public void Reparer()
        {
            AReparer = false;
        }
        public void Dispose()
        {
            Registrations.Remove(Registration);
        }
        public virtual void ReparationTime(Garagiste garagiste)
        {
            double Time;
            for (int i = 0; i < Damage; i++)
            {
                Time = 1.5 * (2 - garagiste.Skill / 100);
                Console.WriteLine(Time);
            }
            
        }



    }
}
