using System;
using System.Collections.Generic;
using System.Text;

namespace SalarieDII
{
    // classe EventArgs qui sert à échanger des données dans évènements
    public class EventSalaryEventArgs : EventArgs
    {
        private decimal _ancienSalaire;
        private decimal _tauxChangement;

        #region constructeur
        /// <summary>
        /// constructeur de la classe EventArgs
        /// </summary>
        /// <param name="salaire">montant de l'ancien salaire en décimal</param>
        /// <param name="taux">taux d'augementation en décimal</param>
        public EventSalaryEventArgs( decimal salaire, decimal taux )
        {
            this.AncienSalaire = salaire;
            this.TauxChangement = taux;
        }
        #endregion

        #region encapsulation Get et Set
        public decimal AncienSalaire { get => _ancienSalaire; set => _ancienSalaire = value; }
        public decimal TauxChangement { get => _tauxChangement; set => _tauxChangement = value; }
        #endregion

    }
}
