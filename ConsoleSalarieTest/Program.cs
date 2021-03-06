﻿using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
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


            // méthode de test pour la gestion des délégué
            //TestEvenement();
            try
            {
                TestException(0);
            } catch ( ArgumentNullException aNE)
            {
                Debug.WriteLine(aNE.Message);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        #region méthode de test des entré sortie
        /// <summary>
        /// méthode de test pour tester les méthodes de Salaries
        /// entré/sortie
        /// pour fichier texte
        /// pour ficher binaire
        /// pour fichier en xml
        /// </summary>
        static void TestIoFichier ()
        {
            try
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
                { DateNaissance = new DateTime(1994, 12, 25), TauxCS = 0.32m };

                Salarie s5 = new Salarie("Voisin", "Florian", "45FGL25")
                { DateNaissance = new DateTime(1989, 5, 21), SalaireBrut = 1800m, TauxCS = 0.30m };

                Commercial c1 = new Commercial(s5)
                { ChiffreAffaire = 150000m, Commission = 0.01m };



                //Salaries listSalarie = new Salaries() {};
                Salaries listSalarie = new Salaries() { s1, s2, s3, c1, s4 };
                Salaries listSalaries = new Salaries();

                /***Gestion en csv*****/
                //listSalarie.SaveText("salaries.csv");
                //listSalaries.LoadText("salaries.csv",1);

                /*****gestion en binaire ****/
                //listSalarie.SaveBinary("salaries.dat");
                //listSalaries.LoadBinary("salaries.dat");

                /*****gestion en xml ****/
                //listSalarie.SaveXml("salaries.xml");
                //listSalaries.LoadXml("salaries.xml");

                /**** gestion en json avec Newtonsolft ****/
                listSalarie.SaveJson("salaries.txt");
                listSalaries.LoadJson("salaries.txt");

                int i = 0;
                foreach (Salarie item in listSalaries)
                {
                    Debug.WriteLine($"{item.ToString()}");
                    Debug.WriteLine($"{listSalarie[i].ToString()}");
                    Debug.WriteLine($"Egalité entre les objects {object.Equals(item, listSalarie[i])}");
                    //Debug.WriteLine(item.ToString());
                    i++;
                }

            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            
            
        }
        #endregion

        #region méthode de test Event Static test
        /// <summary>
        /// méthode de teste des évènement et délégué
        /// </summary>
        static void TestEvenement()
        {
            try
            {
                Salarie.EventCompteur += Salarie_EventCompteur;

                Salarie s1 = new Salarie("Solange", "Juju", "45GFK52")
                {
                    DateNaissance = new DateTime(1986, 8, 5),
                    SalaireBrut = 3000m,
                    TauxCS = 0.28m
                };

                s1.EventSalary += Salarie_EventSalary;
                s1.SalaireBrut = 3300m;

                Salarie s2 = new Commercial("Brive", "Sylvain", "15LFK45")
                {
                    DateNaissance = new DateTime(1985, 12, 1),
                    SalaireBrut = 1500m,
                    TauxCS = 0.22m,
                    ChiffreAffaire = 145000m,
                    Commission = 0.01m
                };

                s2.EventSalary += Salarie_EventSalary;
                s2.SalaireBrut = 1800.0m;

                s2.EventNameNickName += Salarie_EventNameNickName;
                s2.Prenom = "César";

                Salarie s3 = new Salarie("Trump", "Donald", "85MPD56");

                if (true)
                {
                    // tester le desdructeur de monde
                    Salarie s4 = new Salarie();
                }

                Salarie s5 = new Salarie();

            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        #endregion

        #region methode des event
        /// <summary>
        /// méthode de évènement EventSalary de type délégué EventHandler<T>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Salarie_EventSalary(object sender, EventSalaryEventArgs e)
        {
            decimal différence = ((e.NouveauSalaire - e.AncienSalaire) / e.AncienSalaire) * 100m;
            Debug.WriteLine($"Changement de salaire pour {e.NomPrenom}");
            Debug.WriteLine(string.Format($"Il y a une augmentation de {Math.Round(différence, 2)}%"));
            Debug.WriteLine($"ancien salaire {e.AncienSalaire}€ / nouveau salaire {e.NouveauSalaire}€");
        }

        /// <summary>
        /// méthode de évenement static EventNameNickName de la classe Salarie
        /// elle est utilisée lors du changement du nom ou prénom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Salarie_EventNameNickName(object sender, EventNameNickNameEventArgs e)
        {
            Debug.WriteLine($"Changement au niveau du nom ou du prénom");
            Debug.WriteLine($"ancien :{e.OldName} {e.OldNickName} et voici les nouveaux {e.NewName} {e.NewNickName}");
        }

        /// <summary>
        /// méthode de event changement du compteur de la classe Salarie
        /// static _compteur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Salarie_EventCompteur(object sender, EventArgs e)
        {
            Debug.WriteLine($"Voici le nombre de salarie ouvert {Salarie.Compteur}");
        }
        #endregion

        #region test des Exception
        static void TestException (int  option)
        {
            if ( option == 0 ) // -- option 0 on laisse propager les exception
            {
                try
                {
                    Salarie s1 = new Salarie();
                    s1.Matricule = "24fds4g4s5g456s4g65s4g6s6g46s";
                    
                }
                catch (ApplicationException aE)
                {
                    Debug.WriteLine($"{aE.Message} \n Application : {aE.Source} " +
                        $"\n Fonction : {aE.TargetSite} \n Pile : {aE.StackTrace}");
                }
                catch (Exception e)
                {
                    Debug.WriteLine($"{e.Message} \n Application : {e.Source} " +
                        $"\n Fonction : {e.TargetSite} \n Pile : {e.StackTrace}");
                }
            }
            
        }
        #endregion
    }
}
