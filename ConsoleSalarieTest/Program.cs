using System;
using System.Diagnostics;
using SalarieDII;
using SalarieList;

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
            //Salarie personne, personne2,personne3 = null;

            //try
            //{
            //    personne = new Salarie("loulou", "labeille", "45HGF45");
            //    personne.SalaireBrut = 2500.00m;
            //    personne.TauxCS = 0.01m;
            //    personne2 = new Salarie(personne);
            //    personne3 = new Salarie("coucou","houhou","81GFD12");

            //} catch ( Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.WriteLine(string.Format($"Nb instance :{Salarie.Compteur}"));
            //Console.ReadLine();
            //personne2 = null;
            //personne3 = null;
            //Console.WriteLine($"Nb instance avant le passage du garbage collector :{Salarie.Compteur}");
            //Console.ReadLine();
            //GC.Collect();
            //System.Threading.Thread.Sleep(1000); // va mettre en pause le programme de 500 milliseconde
            //Console.WriteLine($"Nb instance après le passage du garbage collector:{Salarie.Compteur}");
            //Console.ReadLine();

            // méthode de test des méthodes io de la classe Salaries (classe de typage List<Salarie>)
            //TestIoFichier();


            TestEvenementDelague();
        }

        /// <summary>
        /// méthode de test pour tester les méthodes de Salaries
        /// entré/sortie
        /// pour fichier texte
        /// pour ficher binaire
        /// pour fichier en xml
        /// </summary>
        static void TestIoFichier ()
        {
            /****************************/
            // test de la classe Salaries (list de salarié)

            Salarie s1 = new Salarie("Cousin", "Cedric", "12LFG85");
            s1.DateNaissance = new DateTime(1980, 02, 01);
            s1.SalaireBrut = 2500m;
            s1.TauxCS = 0.27m;

            Salarie s2 = new Salarie("Cousine", "Mylene", "22LFG75")
            { DateNaissance = new DateTime(1975, 05, 22), SalaireBrut = 2200m, TauxCS = 0.25m };

            Salarie s3 = new Salarie("Tonton", "Jojo", "89DFG72")
            { DateNaissance = new DateTime(1999, 04, 26), SalaireBrut = 1800m, TauxCS = 0.22m };

            Salarie s4 = new Salarie("Tante", "Jeanine", "72DTH45")
            { DateNaissance = new DateTime(1994, 12, 25), SalaireBrut = 3800m, TauxCS = 0.32m };


            //Salaries listSalarie = new Salaries() {};
            Salaries listSalarie = new Salaries() { s1, s2, s3, s4 };
            Salaries listSalaries = new Salaries();

            /***Gestion en csv*****/
            //listSalarie.SaveText("salaries.csv");
            //listSalaries.LoadText("salaries.csv",1);

            //listSalarie.SaveBinary("salaries.dat");
            //listSalaries.LoadBinary("salaries.dat");

            listSalarie.SaveXml("salaries.xml");
            listSalaries.LoadXml("salaries.xml");

            foreach (Salarie item in listSalaries)
            {
                Debug.WriteLine(item.ToString());
            }

            foreach (Salarie item in listSalarie)
            {
                Debug.WriteLine(item.ToString());
            }
        }


        /// <summary>
        /// méthode de teste des évènement et délégué
        /// </summary>
        static void TestEvenementDelague ()
        {
            Salarie s1 = new Salarie("Solange", "Juju", "45GFK52")
            {
                DateNaissance = new DateTime(1986, 8, 5),
                SalaireBrut = 3000m,
                TauxCS = 0.28m
            };

            s1.EventSalary += Salarie_EventSalary;
            s1.SalaireBrut = 3300m;
        }


        /// <summary>
        /// méthode de évènement EventSalary de type délégué EventHandler<T>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Salarie_EventSalary(object sender, EventSalaryEventArgs e)
        {
            decimal différence = ((e.NouveauSalaire - e.AncienSalaire) / e.AncienSalaire) * 100;

            Debug.WriteLine(string.Format($"Changement de salaire augmentation de {Math.Round(différence,2)}%"));
            Debug.WriteLine($"ancien salaire {e.AncienSalaire}€ / nouveau salaire {e.NouveauSalaire}€");
        }
    }
}
