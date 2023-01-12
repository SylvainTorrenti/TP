using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    /// <summary>
    /// class used to create cars
    /// </summary>
    internal class Car
    {
        #region Attributes
        private string _Registration;
        private string _Model;
        private string _Brand;
        private int _KLM;
        private DateOnly _OriginalInServiceDate;
        private int _Power;
        private Person? _Owner; // "?" signifie que cet attribut peut être null
        #endregion
        #region Get & Set Registration
        /// <summary>
        /// Registartion of car
        /// </summary>
        public string Registration { get => _Registration; set => _Registration = value; }
        #endregion
        #region Get & Set Model
        /// <summary>
        /// Model of car
        /// </summary>
        public string Model { get => _Model; set => _Model = value; }
        #endregion
        #region Get & Set Brand
        /// <summary>
        /// Brand of car
        /// </summary>
        public string Brand { get => _Brand; set => _Brand = value; }
        #endregion
        #region Get & Set KLM
        /// <summary>
        /// KLM of car
        /// </summary>
        public int KLM { get => _KLM; set => _KLM = value; }
        #endregion
        #region Get & Set OriginalInServiceDate
        /// <summary>
        /// OriginalInServiceDate of car
        /// </summary>
        public DateOnly OriginalInServiceDate { get => _OriginalInServiceDate; set => _OriginalInServiceDate = value; }
        #endregion
        #region Get & Set Power
        /// <summary>
        /// Power of car
        /// </summary>
        public int Power { get => _Power; set => _Power = value; }
        #endregion
        #region Get & Set Owner
        /// <summary>
        /// Owner of car
        /// </summary>
        internal Person? Owner { get => _Owner; set => _Owner = value; } 
        #endregion
        #region Methode
        /// <summary>
        /// method for displaying Car information
        /// </summary>
        public void Print()
        {
            Console.WriteLine($"Marque : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Plaque d'immatricualtion : {Registration}");
            Console.WriteLine($"Date de mise en service : {OriginalInServiceDate}");
            Console.WriteLine($"Puissance : {Power}cv");
            Console.WriteLine($"Kilométrage : {KLM} Km");
            Console.Write($"Proprietaire : {Owner}");
        }
        /// <summary>
        /// method for displaying Car information without owner
        /// </summary>
        public void PrintWithoutOwner()
        {
            Console.WriteLine($"Marque : {Brand}");
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Plaque d'immatricualtion : {Registration}");
            Console.WriteLine($"Date de mise en service : {OriginalInServiceDate}");
            Console.WriteLine($"Puissance : {Power}cv");
            Console.WriteLine($"Kilométrage : {KLM} Km");
        }
        /// <summary>
        /// Method to add owner
        /// </summary>
        /// <param name="person">Person who own car</param>
        public void AddOwner(Person person)
        {
            this.Owner = person;
        }
        /// <summary>
        /// Method to remove owner
        /// </summary>
        /// <param name="person">Remove person form car ownership</param>
        public void RemoveOwner()
        {
            Owner = null;
        }       
        #endregion
    }
}
