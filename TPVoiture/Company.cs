using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPVoiture
{
    internal class Company
    {
        #region Attribute
        private int _SIRET;
        private string _Name;
        #endregion
        #region Get & Set SIRET
        public int SIRET { get => _SIRET; set => _SIRET = value; }
        #endregion
        #region Get & Set Name
        public string Name { get => _Name; set => _Name = value; }
        #endregion
        #region Constructor
        public Company(int sIRET, string name)
        {
            SIRET = sIRET;
            Name = name;
        }
        #endregion
        #region Method
        public void PrintCompany()
        {
            Console.WriteLine($"Le numero de SIRET est : {SIRET}");
            Console.WriteLine($"Le nom de l'entreprise est : {Name}");
        } 
        #endregion
    }
}
