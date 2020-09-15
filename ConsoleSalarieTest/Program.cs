using System;
using SalarieDII;

namespace ConsoleSalarieTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Test de la méthode de vérification du matricule");
            Console.WriteLine($"Chaine vide. {!Salarie.isVerifMatricule("")}");
            Console.WriteLine($"longueur supérieur à 7. {!Salarie.isVerifMatricule("451DLF45")}");
            Console.WriteLine($"caractère spéciaux. {!Salarie.isVerifMatricule("45^FG45")}");
            Console.WriteLine($"Non décimaux. {!Salarie.isVerifMatricule("FGFKGF4")}");
            Console.WriteLine($"Chaine vide. {!Salarie.isVerifMatricule(" ")}");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Test de la méthode de vérification du nom et prénom");
            Console.WriteLine($"Chaine vide. {!Salarie.isVerifNomPrenom("")}");
            Console.WriteLine($"longueur supérieur à 30. {!Salarie.isVerifNomPrenom("lkjfldsjfdsjflsjlflksjfkjsklfjlkjfd")}");
            Console.WriteLine($"Longueur inférieu à 3. {!Salarie.isVerifNomPrenom("FG")}");
            Console.WriteLine($"caractère spéciaux. {!Salarie.isVerifNomPrenom("khjfhds()")}");
            Console.WriteLine($"caractère numérique. {!Salarie.isVerifNomPrenom("khjfhd54")}");
            Console.WriteLine($"Chaine vide. {!Salarie.isVerifNomPrenom(" ")}");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Test de la méthode de vérification de la date de naissance");
            Console.WriteLine($"Date Time vide. {!Salarie.isVerifDateNaissance(new DateTime())}");
            Console.WriteLine($"Date 01/01/1899. {!Salarie.isVerifDateNaissance(new DateTime(1899,1,1))}");
            DateTime dateDuJour1 = DateTime.Now;
            dateDuJour1.AddDays(1);
            Console.WriteLine($"Date supérieur à la date du jour + 1 jour. {!Salarie.isVerifDateNaissance(dateDuJour1)}");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Vérification du taux de cautisation sociale");
            Console.WriteLine($"Taux négatif. {!Salarie.isVerifTaux(-1)}");
            Console.WriteLine($"Supérieur à 0.6 {!Salarie.isVerifTaux(0.7)}");
            */

            /*
            // test du constructeur en passant un type Object en argument
            Salarie personne = new Salarie();
            personne.Matricule = "15AMG34";
            personne.Nom = "loulou";
            personne.Prenom = "labeille";
            personne.SalaireBrut = 3000.00;
            personne.TauxCS = 0.45;
            personne.DateNaissance = new DateTime(1900, 1, 1);
            Object j = new object();

            //j = personne;
            
            Salarie personne2 = new Salarie(j);
            Console.WriteLine($"personne2 nom {personne2.Nom}");
            Console.WriteLine($"personne2 nom {personne2.Prenom}");
            */

            //
            Salarie personne = new Salarie("loulou","labeille","45HGF45");
            Console.WriteLine($"Nom de la personne {personne.Nom}");
            Console.WriteLine($"taux de la personne {personne.TauxCS}");
            Console.WriteLine($"date de naissance {personne.DateNaissance}");
            Salarie personne2 = new Salarie(personne);
            personne2 = null;
            Console.WriteLine($"Nb instance après le passage du garbage collector :{Salarie._compteur}");

        }
    }
}
