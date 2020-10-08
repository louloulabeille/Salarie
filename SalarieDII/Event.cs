using System;
using System.Collections.Generic;
using System.Text;

namespace SalarieDII
{
    #region Event de changement de nom
    public class EventNameNickNameEventArgs : EventArgs
    {
        private string _oldName;
        private string _oldNickName;
        private string _newName;
        private string _newNickName;

        public EventNameNickNameEventArgs(string ancienNom, string ancienPrenom, string nouveauNom, string nouveauPrenom)
        {
            _oldName = ancienNom;
            _oldNickName = ancienPrenom;
            _newName = nouveauNom;
            _newNickName = nouveauPrenom;
        }

        public string OldName { get => _oldName; set => _oldName = value; }
        public string OldNickName { get => _oldNickName; set => _oldNickName = value; }
        public string NewName { get => _newName; set => _newName = value; }
        public string NewNickName { get => _newNickName; set => _newNickName = value; }
    }

    #endregion

    #region eventArgs de l'event EventSalary
    // classe EventArgs qui sert à échanger des données dans évènements
    public class EventSalaryEventArgs : EventArgs
    {
        private string _nomPrenom;
        private decimal _ancienSalaire;
        private decimal _nouveauSalaire;
        private decimal _tauxChangement;

        /// <summary>
        /// constructeur de la classe EventArgs
        /// </summary>
        /// <param name="salaire">montant de l'ancien salaire en décimal</param>
        /// <param name="taux">taux d'augementation en décimal</param>
        public EventSalaryEventArgs(string nomPrenom, decimal oldSalary, decimal newSalary, decimal taux)
        {
            this.NomPrenom = nomPrenom;
            this.AncienSalaire = oldSalary;
            this.NouveauSalaire = newSalary;
            this.TauxChangement = taux;
        }

        public decimal AncienSalaire { get => _ancienSalaire; set => _ancienSalaire = value; }
        public decimal TauxChangement { get => _tauxChangement; set => _tauxChangement = value; }
        public decimal NouveauSalaire { get => _nouveauSalaire; set => _nouveauSalaire = value; }
        public string NomPrenom { get => _nomPrenom; set => _nomPrenom = value; }
    }
    #endregion

}
