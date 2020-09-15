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
            personne.Nom = "loulou";
            personne.Prenom = "labeille";
            personne.SalaireBrut = 3000.00m;
            personne.TauxCS = 0.45m;
            personne.DateNaissance = new DateTime(1900,1,1);
            Console.WriteLine($"Salarié : {personne.Matricule} | nom : {personne.Nom} | prénom : {personne.Prenom} | salaire net : {personne.SalaireNet}" );

        }

         
    }


}
