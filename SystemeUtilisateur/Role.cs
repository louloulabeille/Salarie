using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeUtilisateur
{
    public class Role
    {
        private string _idUtil;
        private roleInterne _roleUtilisateur;
        private DateTime _dateDebut;    // date de début du role
        private DateTime _dateFin;      // date de fin s'il existe

        #region constructeur
        public Role(string idUtil,roleInterne roleUtilisateur,DateTime dateDebut)
        {
            IdUtil = idUtil;
            RoleUtilisateur = roleUtilisateur;
            DateDebut = dateDebut;
        }
        #endregion

        #region accesseur
        public roleInterne RoleUtilisateur { get => _roleUtilisateur; set => _roleUtilisateur = value; }
        public DateTime DateDebut
        {
            get => _dateDebut;
            set
            {
                _dateDebut = (DateFin == new DateTime() | DateFin > value)?value: throw(new ApplicationException("La date de début du role doit être supérieur à la date de fin du role de l'utilisateur"));
            }
        }
        public DateTime DateFin
        {
            get => _dateFin;
            set
            {
                _dateFin = (DateFin == new DateTime() |  value > DateDebut) ? value : throw (new ApplicationException("La date de fin du rôle de l'utilisateur doit être supérieur à la date de début"));
            }
        }
        public string IdUtil { get => _idUtil; set => _idUtil = value; }
        #endregion

        #region méthode héritée
        public override bool Equals(object obj)
        {
            return obj is Role newRole && IdUtil == newRole.IdUtil &&
                RoleUtilisateur == newRole.RoleUtilisateur && DateDebut.Equals(newRole.DateDebut)
                && DateFin.Equals(newRole.DateFin);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{IdUtil};{RoleUtilisateur};{DateDebut};{DateFin}";
        }

        #endregion

    }
    #region enumerateur de role
    /// <summary>
    /// super Admin est le seul qui peut changer 
    /// le status des admin
    /// admin peut voir le role des autres admin et utilisateur mais le super admin
    /// les utilisateurs ne voit rien
    /// </summary>
    public enum roleInterne
    {
        superAdmin,
        admin,
        utilisateur,
        banni,
    }
    #endregion

}
