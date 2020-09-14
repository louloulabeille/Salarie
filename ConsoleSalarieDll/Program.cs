using System;

namespace SalarieDII
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie personne = new Salarie();
            personne.Matricule = "14APG44";
            personne.Nom = "lLujy0";
            personne.Prenom = "l'abeille";
            personne.SalaireBrut = 3000.00;
            personne.TauxCS = 25.00;

            Console.WriteLine($"Matricule :{personne.Matricule} \nNom :{personne.Nom}");
        }

         
    }
}
