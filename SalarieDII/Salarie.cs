using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SalarieDII
{
    public class Salarie
    {
        private string _matricule;
        private string _nom;
        private string _prenom;
        private double _salaireBrut;
        private double _tauxCS;         // -- taux cotisation sociale
        private DateTime _dateNaissance;

        public const string _patternMatricule = @"^\d{2}[A-Z]{3}\d{2}$";
        public const string _patternNom = @"[a-zA-Z][a-zA-Z]";

        public string Matricule { get => _matricule;
            set
            {
                _matricule = VerifMatricule(value) ? value : null;
                    //throw new Exception(string.Format($"La saisie du matricule est incorect, il doit être de forme '12DFG15' et vous avez saisie '{value}'. "));
            }
        }

        public string Nom { get => _nom;
            set
            {
                _nom = VerifNom(value) ? value : null;
                    //throw new Exception(string.Format($"La saisie du matricule est incorect, il doit comporter de 3 à 30 caractères non décimal et vous avez saisie '{value}'. "));
            }
        }
        public string Prenom { get => _prenom; set => _prenom = value; }
        public double SalaireBrut { get => _salaireBrut; set => _salaireBrut = value; }
        public double TauxCS { get => _tauxCS; set => _tauxCS = value; }
        public DateTime DateNaissance { get => _dateNaissance; set => _dateNaissance = value; }
        public double SalaireNet {      // calcul du salaire Nets
            get
            {
                return CalculSalaireNet();
            }
        }

        private double CalculSalaireNet ()
        {
            return _salaireBrut - ((_salaireBrut*_tauxCS)/100);
        }

        /// <summary>
        /// méthode static qui vérifie si le matricule
        /// a bien été saisie sous le format de décimal décimal Majuscule Majuscule Majuscule Décima décimal
        /// exemple : 45LDM32. voir la constanste @"^\d{2}[A-Z]{3}\d{2}$"
        /// </summary>
        /// <param name="mat">chaine de caractère a vérifié</param>
        /// <returns></returns>
        public static bool VerifMatricule ( string mat )
        {
            Regex rgx = new Regex(_patternMatricule);
            return rgx.IsMatch(mat);
        }

        /// <summary>
        /// verifie si le nom a entre 3 et 30 caractères
        /// et non numérique. Voir la constante _patternNom
        /// </summary>
        /// <param name="name">nom de la personne</param>
        /// <returns></returns>
        public static bool VerifNom ( string name )
        {
            Regex rgx = new Regex(_patternNom);
            return rgx.IsMatch(name);
        }

    }
}
