using System;
using SalarieDII;

namespace ConsoleSalarieDll
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie personne = new Salarie();
            personne.Matricule = "15AMG34";
            personne.Nom = "lo4ulou";
            personne.Prenom = "l'abeille";
            personne.SalaireBrut = 3000.00;
            personne.TauxCS = 0.45;
            personne.DateNaissance = new DateTime(1900,1,1);
            Console.WriteLine($"Salarié : {personne.Matricule} | nom : {personne.Nom} | prénom : {personne.Prenom}");

        }

         
    }


}
