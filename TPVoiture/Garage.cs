﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVoiture;

namespace TPObjet
{
    /// <summary>
    /// Représente un Garage
    /// </summary>
    internal class Garage : Entreprise
    {
        /// <summary>
        /// Représente la liste des véhicules dans le garage
        /// </summary>
        private List<Vehicle> _vehicles = new List<Vehicle>();

        /// <summary>
        /// Représente la liste des véhicules à réparer
        /// </summary>
        private List<Vehicle> _vehicleAReparer = new List<Vehicle>();

        /// <summary>
        /// Représente les garagistes du garage
        /// </summary>
        private List<Garagiste> _garagistes = new List<Garagiste>();

        /// <summary>
        /// Constructeur d'un Garage
        /// </summary>
        /// <param name="siretDuGarage">Numéro Siret du garage</param>
        public Garage(string siretDuGarage) : base(siretDuGarage)
        {

        }

        /// <summary>
        /// Permet au garage de prendre en charge une voiture
        /// </summary>
        /// <param name="car">La voiture à réparer</param>
        public void RecupererUnVehiculeAReparer(Vehicle vehicle)
        {
            if (vehicle.AReparer)
            {
                _vehicles.Add(vehicle);
            }
            else
            {
                Console.WriteLine("Le vehicule n'est pas à réparer.");
            }
        }

        /// <summary>
        /// Permet la récuparation de la voiture par un client
        /// </summary>
        /// <param name="car">Voiture à récupérer</param>
        /// <param name="client">Le client qui veut récupérer la voiture</param>
        public void RecuperationDuVehiculeParLeClient(Vehicle vehicule, Client client)
        {
            //Le client est-il le propriétaire du véhicule ?
            if (vehicule.Owner != client)
            {
                Console.WriteLine("Vous n'êtes pasle propriétaire de la voiture.");
                return; // break la fonction
            }

            // La voiture est finie ?
            if (vehicule.AReparer)
            {
                Console.WriteLine("La voiture n'est pas prête.");
                return; // break la fonction
            }

            Console.WriteLine($"Le client {client.Name} {client.FirstName} à récupéré le vehicule {vehicule.Registration}.");
            _vehicles.Remove(vehicule);
        }

        /// <summary>
        /// Permet d'engager un garagiste
        /// </summary>
        /// <param name="garagiste">Garagiste à engager</param>
        public void EngagerUnGaragiste(Garagiste garagiste)
        {
            if (_garagistes.Contains(garagiste))
            {
                Console.WriteLine("Ce garagiste est déjà un salarié du garage !");
            }
            else
            {
                _garagistes.Add(garagiste);
                Console.WriteLine($"Le garagiste {garagiste.Name} {garagiste.FirstName} " +
                    $"est maintenant disponible dans votre garage.");
            }
        }

        /// <summary>
        /// Permet de licencier un garagiste
        /// </summary>
        /// <param name="garagiste">Garagiste à licencier</param>
        public void LicencierUnGaragiste(Garagiste garagiste)
        {
            if (_garagistes.Remove(garagiste))
            {
                Console.WriteLine($"Le garagiste {garagiste.Name} {garagiste.FirstName} " +
                    $"n'est désormais plus disponible dans votre garage !");
            }
            else
            {
                Console.WriteLine($"Le garagiste {garagiste.Name} {garagiste.FirstName} " +
                    $"n'est pas salarié de ce garage !");
            }
        }

        /// <summary>
        /// Permet d'assigner à un garagiste une voiture à réparer
        /// </summary>
        /// <param name="car">Voiture à réparer</param>
        /// <param name="garagiste">Garagiste en charge de la voiture</param>
        public void AssignerUnVehiculeUnGaragiste(Vehicle vehicle, Garagiste garagiste)
        {
            garagiste.AjouterUnVehiculeAReparer(vehicle);
            vehicle.AjouterUnGaragiste(garagiste);
        }
    }
}