﻿using System;
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
            personne.SalaireBrut = 3000.00m;
            personne.TauxCS = 0.45m;
            personne.DateNaissance = new DateTime(1900, 1, 1);
            Object j = new object();

            //j = personne;
            
            Salarie personne2 = new Salarie(j);
            Console.WriteLine($"personne2 nom {personne2.Nom}");
            Console.WriteLine($"personne2 nom {personne2.Prenom}");
            */

            //
            Salarie personne, personne2,personne3 = null;

            try
            {
                personne = new Salarie("loulou", "labeille", "45HGF45");
                personne.SalaireBrut = 2500.00m;
                personne.TauxCS = 0.01m;
                personne2 = new Salarie(personne);
                personne3 = new Salarie("coucou","houhou","81GFD12");

            } catch ( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*
            Console.WriteLine($"Nom de la personne {personne.Nom}");
            Console.WriteLine($"taux de la personne {personne.TauxCS}");
            Console.WriteLine($"date de naissance {personne.DateNaissance}");
            */

            /*
            Console.WriteLine(string.Format($"Nb instance :{Salarie.Compteur}"));
            Console.ReadLine();
            personne2 = null;
            personne3 = null;
            Console.WriteLine($"Nb instance avant le passage du garbage collector :{Salarie.Compteur}");
            Console.ReadLine();
            GC.Collect();
            System.Threading.Thread.Sleep(500); // va mettre en pause le programme de 500 milliseconde
            Console.WriteLine($"Nb instance après le passage du garbage collector:{Salarie.Compteur}");
            Console.ReadLine();
            */

            /////// --- test de la classe Commercial qui hérite de salarie

            try
            {
                Commercial com = new Commercial("loulou", "labeille", "45HGF45");
                com.DateNaissance = new DateTime(1979, 4, 1);
                com.SalaireBrut = 1500m;
                com.TauxCS = 0.25m;
                com.ChiffreAffaire = 250000m;
                com.Commission = 0.01m;
                Console.WriteLine(com.SalaireNet);
                Console.WriteLine(com.ToString());

                Salarie salCom = new Salarie("floflo", "florian", "19HGT12");
                salCom.DateNaissance = new DateTime(1991,1,1);
                salCom.SalaireBrut = 1600m;
                salCom.TauxCS = 0.25m;
                Commercial com2 = new Commercial(salCom);
                //Commercial com3 = new Commercial(com2);
                
                Console.WriteLine(com2.ToString());
                
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
