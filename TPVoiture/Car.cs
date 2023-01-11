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
        /// <summary>
        /// Registartion of the car
        /// </summary>
        private string Registration;
        /// <summary>
        /// Model of the car
        /// </summary>
        private string Model;
        /// <summary>
        /// Brand of the car
        /// </summary>
        private string Brand;
        /// <summary>
        /// How many klm the car has made
        /// </summary>
        private int KLM;
        /// <summary>
        /// First date when the car has been release
        /// </summary>
        private DateOnly OriginalInServiceDate;
        /// <summary>
        /// Power of the car in horsepower
        /// </summary>
        private int Power;
        /// <summary>
        /// Personal owner of the car
        /// </summary>
        private Person? Owner; // "?" signifie que cet attribut peut être null
        #endregion
        #region Get & Set Registration
        /// <summary>
        /// Get Registration
        /// </summary>
        /// <returns>Registration</returns>
        public string GetRegistration()
        {
            return Registration;
        }
        /// <summary>
        /// Set registration
        /// </summary>
        /// <param name="Registration">Registration</param>
        public void SetRegistration(string Registration)
        {
            this.Registration = Registration;
        }
        #endregion
        #region Get & Set Model
        /// <summary>
        /// Get Model
        /// </summary>
        /// <returns>Model</returns>
        public string GetModel()
        {
            return Model;
        }
        /// <summary>
        /// Set Model
        /// </summary>
        /// <param name="Model">Model</param>
        public void SetModel(string Model)
        {
            this.Model = Model;
        }
        #endregion
        #region Get & Set Brand
        /// <summary>
        /// Get Brand
        /// </summary>
        /// <returns>Brand</returns>
        public string GetBrand()
        {
            return Brand;
        }
        /// <summary>
        /// Set Brand
        /// </summary>
        /// <param name="Brand">Brand</param>
        public void SetBrand(string Brand)
        {
            this.Brand = Brand;
        }
        #endregion
        #region Get & Set KLM
        /// <summary>
        /// Get KLM
        /// </summary>
        /// <returns>KLM</returns>
        public int GetKLM()
        {
            return KLM;
        }
        /// <summary>
        /// Set KLM
        /// </summary>
        /// <param name="KLM">KLM</param>
        public void SetKLM(int KLM)
        {
            this.KLM = KLM;
        }
        #endregion
        #region Get & Set OriginalInServiceDate
        /// <summary>
        /// Get OriginalInServiceDate
        /// </summary>
        /// <returns>OriginalInServiceDate</returns>
        public DateOnly GetOriginalInServiceDate()
        {
            return OriginalInServiceDate;
        }
        /// <summary>
        /// Set OriginalInServiceDate
        /// </summary>
        /// <param name="OriginalInServiceDate">OriginalInServiceDate</param>
        public void SetOriginalInServiceDate(DateOnly OriginalInServiceDate)
        {
            this.OriginalInServiceDate = OriginalInServiceDate;
        }
        #endregion
        #region Get & Set Power
        /// <summary>
        /// Get Power
        /// </summary>
        /// <returns>Power</returns>
        public int GetPower()
        {
            return Power;
        }
        /// <summary>
        /// Set Power
        /// </summary>
        /// <param name="Power">Power</param>
        public void SetPower(int Power)
        {
            this.Power = Power;
        }
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
