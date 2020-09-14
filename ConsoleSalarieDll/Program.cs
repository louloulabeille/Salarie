using System;

namespace SalarieDII
{
    class Program
    {
        static void Main(string[] args)
        {
            Salarie personne = new Salarie();
            personne.Matricule = "15APG34";
            personne.Nom = "lo4ulou";
            personne.Prenom = "l'abeille";
            personne.SalaireBrut = 3000.00;
            personne.TauxCS = 25.00;

            Console.WriteLine(personne.SalaireNet);
        }

         
    }
}
