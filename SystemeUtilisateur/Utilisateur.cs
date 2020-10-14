using System;
using System.Text.RegularExpressions;

namespace SystemeUtilisateur
{
    /// <summary>
    /// Classe utilisateur poour la gestion du mot de passe
    /// et utilisateur
    /// </summary>
    [Serializable()]
    public class Utilisateur
    {
        private string _idUtil;
        private string _nomUtil;
        private string _courriel;
        private string _motDePasse;
        private Roles _role;

        private const string _patternMp = @"[\d+?\w]{8,}?";
        private const string _patterMail = @"/^([\w -\.] +)@((?:[\w]+\.)+)([a-zA-Z]{2,4})/i";
        private const string _patternUtil = @"^\w{8,}?";


        #region Constructeur
        public Utilisateur()
        {

        }
        public Utilisateur(string nomUtil, string motDePasse)
            :this()
        {
            NomUtil = nomUtil;
            MotDePasse = motDePasse;
        }

        public Utilisateur(string nomUtil, string motDePasse, string mail)
            : this(nomUtil,motDePasse)
        {
            Courriel = mail;
        }

        #endregion

        #region accesseur
        public string NomUtil { get => _nomUtil;
            set
            {
                _nomUtil = IsVerifNomUtil(value) ? value : throw (new ApplicationException("La saisie du nom de l'utilisateur est invalide"));
            }
        }
        public string MotDePasse { get => _motDePasse;
            set
            {
                _motDePasse = IsVerifMotDePasse(value)?value:throw(new ApplicationException("Le mot de passe doit être supérieur à 8 caractères et doit comporter des chiffres."));
            }
        }
        public string Courriel
        {
            get => _courriel;
            set
            {
                _courriel = IsVerifCourriel(value)?value:throw(new ApplicationException("Le courriel saisie n'est pas valide."));
            }
        }
        public string IdUtil { get => _idUtil; set => _idUtil = value; }
        internal Roles Role { get => _role; set => _role = value; }
        #endregion

        #region méthode de vérification de classe
        public bool IsVerifMotDePasse ( string mP )
        {
            Regex rgx = new Regex(_patternMp);
            return rgx.IsMatch(mP);
        }

        public bool IsVerifCourriel ( string courriel )
        {
            if (string.IsNullOrEmpty(courriel))
            {
                return true;
            }
            else
            {
                Regex rgx = new Regex(_patterMail);
                return rgx.IsMatch(courriel);
            }
            
        }

        public bool IsVerifNomUtil ( string nomUtil )
        {
            Regex rgx = new Regex(_patternUtil);
            return rgx.IsMatch(nomUtil);
        }

        #endregion

        #region methode hérité
        public override bool Equals(object obj)
        {
            return obj is Utilisateur util &&
                this.NomUtil == util.NomUtil;
        }

        public override int GetHashCode()
        {
            return this.NomUtil.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format($"{IdUtil};{NomUtil};{Courriel}");
        }
        #endregion


    }
}
