using System;
using System.Collections.Generic;
using System.Text;

namespace Bla.Logic
{
    public class MedicationStorage
    {
        public String Name { get; set; }
        public int Amount { get; set; }
        public int Dose { get; set; }
        public List<String> Chargen { get; set; }
        /// <summary>
        /// Usage of medication reduces amount stored by 1
        /// </summary>
        public void Use()
        {
            this.Amount -= 1;
        }
        /// <summary>
        /// Adds batchnumbers to list and increases amount stored respectively
        /// </summary>
        /// <param name="chargennummern">List of Batchnumber strings</param>
        public void AddMedizine(List<String> chargennummern)
        {
            this.Amount += chargennummern.Count;
            this.Chargen.AddRange(chargennummern);
        }
    }
}
