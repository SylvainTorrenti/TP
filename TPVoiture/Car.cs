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
    /// Représente une voiture
    /// </summary>
    internal class Car : Vehicle, IDisposable
    {

        //public bool SearchRegistrationWithChar(string registration, char c)
        //{
        //    bool trouve = false;
        //    for(int i = 0; i < Registration.Length; i++)
        //    {
        //        trouve = Registration[i] == c;
        //        if(trouve ==true )  {
        //            break;
        //        }
        //    }
        //    return trouve;
        //}

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

        /// <summary>
        /// Construsteur complet de la voiture 
        /// </summary>
        /// <param name="registration">Immatriculation</param>
        /// <param name="model">Modèle</param>
        /// <param name="brand">Marque</param>
        /// <param name="kLM">Compteur kilométrique actuel de la voiture</param>
        /// <param name="originalInServiceDate">Date de mise en service de la voiture</param>
        /// <param name="power">Puissance de la voiture</param>
        /// <param name="owner">Propriétaire de la voiture</param>
        public Car(string registration, string model, string brand, int kLM, DateTime originalInServiceDate, int power, Person owner, bool aReparer, int damage) : base(originalInServiceDate, owner, aReparer, registration, damage)
        {
            Model = model;
            Brand = brand;
            KLM = kLM;
            Power = power;

        }

        /// <summary>
        /// Récupére les informations de la voiture sous forme de chaîne de caractères
        /// </summary>
        /// <returns>Les informations de la voiture</returns>
        public string Print()
        {
            if (Owner is not null)
            {
                return
                    $"{Registration} ({Model} - {Brand}) :  {KLM} - {OriginalInServiceDate} - {Owner.Print()}";
            }
            else
            {
                return
                     $"{Registration} ({Model} - {Brand}) :  {KLM} - {OriginalInServiceDate} - Pas de propriétaire";
            }
        }


        /// <summary>
        /// Permet de changer le propriétaire de la voiture
        /// </summary>
        /// <param name="person">Nouveau propriétaire</param>
        public void ChangementDeProprietaire(Person person)
        {
            if (Owner is not null)
            {
                Person oldOwner = Owner;
                person.AcquisitionDunVehicule(this);
                oldOwner.VenteDunVehicule(this);
            }
        }

        /// <summary>
        /// Calcul du temps de reparation de la voiture
        /// </summary>
        /// <param name="garagiste"></param>
        public override void ReparationTime(Garagiste garagiste)
        {
            double Time;
            Time = 1.5 * 2 - (garagiste.Skill / 100);
            Console.WriteLine($"Il faut {Time} heure à {garagiste.FirstName} {garagiste.Name} pour réparer la {Brand}{Model}");
        }


    }
}