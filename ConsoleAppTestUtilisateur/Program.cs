using System;
using System.Diagnostics;
using SystemeUtilisateur;

namespace ConsoleAppTestUtilisateur
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestRole();
            //TestMotdePasse();
            //TestNomUtilisateur();
            //TestCourriel();
            TestRole();
        }
        #region Test Role
        static void TestRole()
        {
            try
            {
                // test enregistrement de role par intermédiaire de Roles et récupération
                Role r = new Role("12JP", roleInterne.admin, new DateTime(2005, 12, 1));
                Role r1 = new Role("11CP", roleInterne.utilisateur, new DateTime(2020, 1, 1));
                Role r2 = new Role("12JP", roleInterne.superAdmin, new DateTime(2005, 12, 1));
                Roles l = new Roles();
                l.Add(r);
                l.Add(r1);
                l.Add(r2);
                Roles l1 =  l.FindAll("12JP");
                foreach ( Role item in l )
                {
                    Debug.WriteLine(item.ToString());
                }
                Debug.WriteLine("\n");
                foreach (Role item in l1)
                {
                    Debug.WriteLine(item.ToString());
                }

                l.SaveJson();
                l1.Clear();
                l1.LoadJson();
                Debug.WriteLine("\n");
                foreach (Role item in l1)
                {
                    Debug.WriteLine(item.ToString());
                }
            }
            catch (ApplicationException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        #endregion

        static void TestUtilisateur ()
        {

        }

        static void TestNomUtilisateur ()
        {
            try
            {
                Utilisateur util = new Utilisateur();
                Debug.WriteLine($"{util.IsVerifNomUtil("loulou")}==false");
                Debug.WriteLine($"{util.IsVerifNomUtil("loulou4")}==false");
                Debug.WriteLine($"{util.IsVerifNomUtil("louloulabeille")}==true");
                Debug.WriteLine($"{util.IsVerifNomUtil("loulou46")}==true");
                Debug.WriteLine($"{util.IsVerifNomUtil("14louloulabeille")}==true");
            }
            catch ( ApplicationException e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        static void TestMotdePasse()
        {
            try
            {
                Utilisateur util = new Utilisateur();
                Debug.WriteLine ($"{util.IsVerifMotDePasse("azerty")}== false");
                Debug.WriteLine($"{util.IsVerifMotDePasse("aze4rty")}== false");
                Debug.WriteLine($"{util.IsVerifMotDePasse("aze4r5ty")}== true");
                Debug.WriteLine($"{util.IsVerifMotDePasse("aze4rtyu")}== true");
                Debug.WriteLine($"{util.IsVerifMotDePasse("4aze4r5ty")}== true");
                Debug.WriteLine($"{util.IsVerifMotDePasse("aze4r5ty")}== true");
            }
            catch(ApplicationException e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        static void TestCourriel()
        {
            try
            {
                Utilisateur util = new Utilisateur();
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhkjskjhf.fdkshf.com")} = false");
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhkjskjhf@.com")} = false");
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhkjskjhf@fsdfs.com45")} = false");
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhkjskjhf@fsdfs.45")} = false");
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhkjskjhf@fsdfs.com")} = true");
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhkjskjhf454545@fsdfs.com")} = true");
                Debug.WriteLine($"{util.IsVerifCourriel("kjhfksfksfhk.jskjhf454545@fsd.fs.com")} = true");
            }
            catch(ApplicationException e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    }
}
