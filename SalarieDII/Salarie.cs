using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SalarieDII
{
    public class Salarie
    {
        private string _matricule;
        private string _nom;
        private string _prenom;
        private decimal _salaireBrut;
        private decimal _tauxCS;         // -- taux cotisation sociale
        private DateTime _dateNaissance;
        private static int _compteur;   // compteur d'instance

        public const string _patternMatricule = @"^\d{2}[A-Z]{3}\d{2}$";
        public const string _patternNom = @"^[A-Za-z]{3,30}?$";
        public const decimal _maxTaux = 0.60m;
        public const decimal _minTaux = 0.0m;
        public const int _anneeMin = -15;


        /// <summary>
        /// constructeur on passe un object dans le constructeur
        /// on vérifie s'il est du même type
        /// </summary>
        /// <param name="sal">type object</param>
        public Salarie( object sal )
        {
            if ( this.GetType() == sal.GetType() )
            {
                Salarie nouveauSal = (Salarie)sal;
                this._matricule = nouveauSal.Matricule;
                this._nom = nouveauSal.Nom;
                this._prenom = nouveauSal.Prenom;
                this._salaireBrut = nouveauSal.SalaireBrut;
                this._tauxCS = nouveauSal.TauxCS;
                this._dateNaissance = nouveauSal.DateNaissance;
                _compteur++;
            }
            else
            {
                throw new Exception(string.Format("Impossible de faire une copie de l'objet passé en paramètre du constructeur."));
            }
        }
        /// <summary>
        /// constructeur sans rien
        /// </summary>
        public Salarie()
        {
            _compteur++;
        }

        /// <summary>
        /// constructeur qui initialise le nom et le prénom
        /// </summary>
        /// <param name="n">nom du salarié</param>
        /// <param name="p">prénom du salarié</param>
        /// <param name="m">matricule du salarié</param>
        public Salarie(string n, string p, string m)
        {
            this.Nom = n;
            this.Prenom = p;
            this.Matricule = m;
            this.SalaireBrut = 0.0m;
            this.TauxCS = 0.0m;
            this.DateNaissance = this.InitDateDeNaissance();
            _compteur++;
        }

        ~Salarie()
        {
            _compteur--;            
        }

        public string Matricule { get => this._matricule;
            set
            {
                this._matricule = isVerifMatricule(value) ? value : throw new Exception(string.Format($"La saisie du matricule est incorect, il doit être de forme '12DFG15' et vous avez saisie '{value}'. "));
            }
        }

        public string Nom { get => this._nom;
            set
            {
                this._nom = isVerifNomPrenom(value) ? value : throw new Exception(string.Format($"La saisie du nom est incorect, il doit comporter de 3 à 30 caractères non décimal et vous avez saisie '{value}'. "));
            }
        }
        public string Prenom { get => this._prenom;
            set
            {
                this._prenom = isVerifNomPrenom(value) ? value : throw new Exception(string.Format($"La saisie du prénom est incorect, il doit comporter de 3 à 30 caractères non décimal et vous avez saisie '{value}'. "));
            }
        }
        public decimal SalaireBrut { get => this._salaireBrut; set => this._salaireBrut = value; }
        public decimal TauxCS { get => this._tauxCS;
            set
            {
                this._tauxCS = isVerifTaux( value )? value: throw new Exception(string.Format($"La saisie du taux est invalide, il doit être compris entre {_minTaux} et {_maxTaux}."));
            }
        }
        public DateTime DateNaissance { get => this._dateNaissance;
            set
            {
                this._dateNaissance = isVerifDateNaissance(value) ? value : throw new Exception(string.Format("La date est incorrecte, elle doit être supérieur à 01/01/1900 et inférieur de 15 ans à la date du jour"));
            }
        
        }
        public decimal SalaireNet {      // calcul du salaire Nets
            get
            {
                return CalculSalaireNet();
            }
        }

        public static int Compteur { 
            get
            {
                return Salarie._compteur;
            }    
        }


        /// <summary>
        /// Calcul du salaire net avec l'aide du salaire brute et du taux
        /// </summary>
        /// <returns></returns>
        private decimal CalculSalaireNet ()
        {
            return this._salaireBrut  * (1-this.TauxCS);
        }

        /// <summary>
        /// méthode static qui vérifie si le matricule
        /// a bien été saisie sous le format de décimal décimal Majuscule Majuscule Majuscule Décima décimal
        /// exemple : 45LDM32. voir la constanste @"^\d{2}[A-Z]{3}\d{2}$"
        /// </summary>
        /// <param name="mat">chaine de caractère a vérifié</param>
        /// <returns></returns>
        public static bool isVerifMatricule ( string mat )
        {
            Regex rgx = new Regex(_patternMatricule);
            return rgx.IsMatch(mat);
        }
        /// <summary>
        /// verifie si le nom a entre 3 et 30 caractères
        /// et non numérique. Voir la constante _patternNom
        /// </summary>
        /// <param name="name">nom ou le prénom de la personne</param>
        /// <returns></returns>
        public static bool isVerifNomPrenom ( string name )
        {
            Regex rgx = new Regex(_patternNom);
            return rgx.IsMatch(name);
        }
        /// <summary>
        /// Verifis le taux s'il est compris entre 0 et 0.6
        /// c'est a dire entre le nimTaux et maxTaux
        /// </summary>
        /// <param name="taux"> taux à vérifier</param>
        /// <returns></returns>
        public static bool isVerifTaux ( decimal taux )
        {
            return taux >= _minTaux & taux <= _maxTaux;
        }

        /// <summary>
        /// Vérificatio, fed la date de naissance du salarié
        /// il doit être supérieur à 01/01/1900
        /// et doit être inférieur à la date du jour moins 15 ans
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static bool isVerifDateNaissance ( DateTime date )
        {
            DateTime dateJour = DateTime.Now;
            DateTime minDateNaissance = new DateTime(1900, 1, 1);
            dateJour = dateJour.AddYears(_anneeMin);

            if (DateTime.Compare(minDateNaissance, date) <= 0 && dateJour.CompareTo(date) >= 0)
            {
                return true;
            }
            return false;
            
        }

        private DateTime InitDateDeNaissance()
        {
            return DateTime.Now.AddYears(_anneeMin);
        }
    }
}
