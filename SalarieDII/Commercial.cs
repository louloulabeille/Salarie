using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace SalarieDII
{
    /// <summary>
    /// implémentation de la classe commercial
    /// </summary>
    [Serializable()]
    public class Commercial : Salarie
    {
        private decimal _chiffreAffaire;
        private decimal _commission;

        #region Contructeur
        public Commercial()
        //: base()
        {

        }
        
        public Commercial(Commercial comm)
            : base(comm)
        {
            this.ChiffreAffaire = comm.ChiffreAffaire;
            this.Commission = comm.Commission;
        }

        public Commercial(Salarie sal)
            : base(sal)
        {

        }
        public Commercial(string nom, string prenom, string matricule)
            : base(nom, prenom, matricule)
        {

        }
        #endregion

        #region Set et Get
        public decimal ChiffreAffaire
        {
            get => _chiffreAffaire;
            set
            {
                this._chiffreAffaire = IsVerifChiffreAffaire(value) ? value : throw new Exception(string.Format("La saisie du chiffre d'affaire est invalide."));
            }
        }
        public decimal Commission
        {
            get => _commission;
            set
            {
                this._commission = Salarie.IsVerifTaux(value) ? value : throw new Exception(string.Format("La saisie du taux de commission est erronée."));
            }
        }

        public decimal SalaireSansCommission
        {
            get { return base.SalaireNet; }
        }
        
        public override decimal SalaireNet
        {      // calcul du salaire Net du commercial
            get
            {
                return CalculSalaireNet();
            }
        }

        private decimal CalculSalaireNet()
        {
            return base.SalaireNet + (this._chiffreAffaire - this._chiffreAffaire * (1 - this._commission));
        }
        #endregion

        #region methode de vérification
        public static bool IsVerifChiffreAffaire(decimal chAff)
        {
            return chAff >= 0.0m;
        }
        #endregion


        public override string ToString()
        {
            return base.ToString() + string.Format($";Chiffre d'affaire {this.ChiffreAffaire};Commission {this.Commission}");
        }
    }
}
