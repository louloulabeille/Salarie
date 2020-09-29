using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SalarieDII
{
    [Serializable()]
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
        public const string _patternNom = @"^\w[^0-9]{3,30}?$";
        public const decimal _maxTaux = 0.60m;
        public const decimal _minTaux = 0.0m;
        public const int _anneeMin = -15;

        #region contructeur
        /// <summary>
        /// constructeur sans rien
        /// </summary>
        public Salarie()
        {
            Salarie.OnEventCompteur(this, new EventArgs());
            _compteur++;
        }

        /// <summary>
        /// constructeur qui initialise le nom ,le prénom et le matricule
        /// </summary>
        /// <param name="n">nom du salarié</param>
        /// <param name="p">prénom du salarié</param>
        /// <param name="m">matricule du salarié</param>
        public Salarie(string n, string p, string m)
            : this()
        {
            this.Nom = n;
            this.Prenom = p;
            this.Matricule = m;
            this.DateNaissance = this.InitDateDeNaissance();
        }

        /// <summary>
        /// constructeur on passe un object dans le constructeur
        /// on vérifie s'il est du même type
        /// </summary>
        /// <param name="sal">type object</param>
        public Salarie(Salarie sal)
            : this(sal.Nom, sal.Prenom, sal.Matricule)
        {
            if (sal != null)
            {
                this._salaireBrut = sal.SalaireBrut;
                this._tauxCS = sal.TauxCS;
                this._dateNaissance = sal.DateNaissance;
            }
            else
            {
                throw new Exception(string.Format("Impossible de faire une copie de l'objet passé en paramètre du constructeur."));
            }
        }
        #endregion

        #region Destructeur
        ~Salarie()
        {
            _compteur--;
            Salarie.EventCompteur(this, new EventArgs());
        }
        #endregion

        #region Set et Get
        public string Matricule { get => this._matricule;
            set
            {
                this._matricule = IsVerifMatricule(value) ? value : throw new Exception(string.Format($"La saisie du matricule est incorect, il doit être de forme '12DFG15' et vous avez saisie '{value}'. "));
            }
        }

        public string Nom { get => this._nom;
            set
            {
                if ( !string.IsNullOrEmpty(this._nom) && !string.Equals(this._nom,value) )
                {
                    OnEventNameNickName(this, new EventNameNickNameEventArgs(this.Nom, this.Prenom, value, this.Prenom));
                }
                this._nom = IsVerifNomPrenom(value) ? value : throw new Exception(string.Format($"La saisie du nom est incorect, il doit comporter de 3 à 30 caractères non décimal et vous avez saisie '{value}'. "));
            }
        }
        public string Prenom { get => this._prenom;
            set
            {
                if( !string.IsNullOrEmpty(this.Prenom) && !string.Equals(this._prenom,value) )
                {
                    OnEventNameNickName(this, new EventNameNickNameEventArgs(this.Nom, this.Prenom, this.Nom, value));
                }
                this._prenom = IsVerifNomPrenom(value) ? value : throw new Exception(string.Format($"La saisie du prénom est incorect, il doit comporter de 3 à 30 caractères non décimal et vous avez saisie '{value}'. "));
            }
        }
        public decimal SalaireBrut
        {
            get => this._salaireBrut;
            set
            {
                // appel de event si les conditions sont bonne sinon rien

                if ( value != 0 && this._salaireBrut != value )
                {
                    OnEventSalary(this,new EventSalaryEventArgs(string.Format($"{ this.Nom } {this.Prenom}"),this.SalaireBrut,value,this.TauxCS));
                }
                this._salaireBrut = value;
            }
        }
        public decimal TauxCS { get => this._tauxCS;
            set
            {
                // ajout d'un évènement quand modification du salaire brute pour afficher l'ancien
                // salaire et taux d'augmentation

                // enregistrement
                this._tauxCS = IsVerifTaux(value) ? value : throw new Exception(string.Format($"La saisie du taux est invalide, il doit être compris entre {_minTaux} et {_maxTaux}."));
            }
        }
        public DateTime DateNaissance { get => this._dateNaissance;
            set
            {
                this._dateNaissance = IsVerifDateNaissance(value) ? value : throw new Exception(string.Format("La date est incorrecte, elle doit être supérieur à 01/01/1900 et inférieur de 15 ans à la date du jour"));
            }

        }
        public virtual decimal SalaireNet {      // calcul du salaire Nets
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
        #endregion


        #region méthode de vérification de classe en static
        /// <summary>
        /// méthode static qui vérifie si le matricule
        /// a bien été saisie sous le format de décimal décimal Majuscule Majuscule Majuscule Décima décimal
        /// exemple : 45LDM32. voir la constanste @"^\d{2}[A-Z]{3}\d{2}$"
        /// </summary>
        /// <param name="mat">chaine de caractère a vérifié</param>
        /// <returns></returns>
        public static bool IsVerifMatricule(string mat)
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
        public static bool IsVerifNomPrenom(string name)
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
        public static bool IsVerifTaux(decimal taux)
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
        public static bool IsVerifDateNaissance(DateTime date)
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
        #endregion

        #region méthode de la classe
        /// <summary>
        /// Calcul du salaire net avec l'aide du salaire brute et du taux
        /// </summary>
        /// <returns></returns>
        private decimal CalculSalaireNet()
        {
            return this._salaireBrut * (1 - this.TauxCS);
        }

        /// <summary>
        /// méthode d'intitialisation  de la date de Naissance
        /// qui prend la date du jour moins -15 ans
        /// </summary>
        /// <returns></returns>
        private DateTime InitDateDeNaissance()
        {
            return DateTime.Now.AddYears(_anneeMin);
        }
        #endregion

        #region Surcharge des méthode Object
        /// <summary>
        /// surcharge de méthode equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Salarie salarie &&
                   _matricule == salarie._matricule;
        }

        /// <summary>
        /// surcharge de la méthode getHascode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this._matricule.GetHashCode();
        }


        /// <summary>
        /// surcharge de la méthode ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"Matricule {this.Matricule};Nom {this.Nom};Prenom {this.Prenom};Salaire Brute {this.SalaireBrut}" +
                $";Salaire Net {this.SalaireNet};Taux charge sociale {this._tauxCS};Date de naissance {this.DateNaissance}");
        }
        #endregion

        #region Gestion du délégué et des évènement dans la classe Salarie

        //public delegate void EventSalaryChangeHandler(object sender, EventSalaryEventArgs e);
        //public event EventSalaryChangeHandler EventSalary;

        /// <summary>
        /// declaration de event de type de classe EventHandler<T>
        /// type délégué généritque
        /// </summary>
        public event EventHandler<EventSalaryEventArgs> EventSalary;

        protected virtual void OnEventSalary(object sender, EventSalaryEventArgs e)
        {
            EventHandler<EventSalaryEventArgs> handler = EventSalary;
            if (handler != null) handler(sender,e);
        }


        /// <summary>
        /// Event de type static cela ne change pas grand chose
        /// mais c'est possible de le faire
        /// </summary>
        public event EventHandler<EventNameNickNameEventArgs> EventNameNickName;

        protected virtual void OnEventNameNickName(object sender, EventNameNickNameEventArgs e)
        {
            EventHandler<EventNameNickNameEventArgs> handler = EventNameNickName;
            if (handler != null) handler(sender, e);
        }


        public static event EventHandler EventCompteur;

        protected static void OnEventCompteur(object sender,EventArgs e)
        {
            EventHandler handler = EventCompteur;
            if (handler != null) handler(sender,e);
        }

        #endregion
    }
}
