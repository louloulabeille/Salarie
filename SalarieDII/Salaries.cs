using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using SalarieDII;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Converters;

namespace SalarieList
{
    [Serializable()]
    [XmlInclude(typeof(Commercial))]

    public class Salaries : List<Salarie>
    {
        #region méthode de gestion de salarie
        /// <summary>
        /// méthode qui ajoute un nouveau salarie
        /// mais vérifie si le salarie existe déjà dans la liste
        /// au niveau du numéro de métricule
        /// </summary>
        /// <param name="item">salarie à ajouter</param>
        public new void Add(Salarie item)
        {
            if (item != null && !this.Contains(item))
            {   // je peux l'ajouter
                base.Add(item);
            }

        }


        /// <summary>
        /// méthode qui va rechercher un salarié dans la liste à l'aide de n° matricule et
        /// le retourne
        /// </summary>
        /// <param name="mat">N° de matricule du salarié</param>
        /// <returns></returns>
        public Salarie Extract(string mat)
        {
            return base.Find(x => x.Matricule.Equals(mat));
        }

        /// <summary>
        /// supprime dans la liste 
        /// le salarié passé en argument même si ici on n'en a pas besoin
        /// </summary>
        /// <param name="item">object Salarie</param>
        /// <returns></returns>
        public new bool Remove(Salarie item)
        {
            return base.Remove(item);
        }

        /// <summary>
        /// supprime le salarié qui à pour matricule
        /// </summary>
        /// <param name="mat">matricule du salarié</param>
        /// <returns></returns>
        public bool Remove(string mat)
        {
            return base.Remove(this.Extract(mat));
        }

        #endregion

        #region méthode de gestion de sauvegarde des listes et de lecture sur fichier csv
        /// <summary>
        /// méthode de sauvegarde de la liste des salariés
        /// le nom du fichier sera de l'ordre nom de la classe + extension
        /// </summary>
        /// <param name="chemin">chemin pour la sauvegarde du fichier</param>
        public void SaveText(string path )
        {
            // ouverture du file stream créer le fichier s'il existe ou sinon l'ouvre mais
            // re-écrit par dessus

            using (TextWriter textWriter = File.CreateText(@path))
            {
                //écrit la première ligne
                textWriter.WriteLine("Matricule;Nom;Prenom;Date de naissance;Salaire Brute;Salaire Net;Taux securite social");
                foreach (Salarie item in this)
                {
                    textWriter.WriteLine($"{item.Matricule};{item.Nom};{item.Prenom};{item.DateNaissance};{item.SalaireBrut};{item.SalaireNet};{item.TauxCS}");
                    //textWriter.WriteLine($"{item.ToString()}");
                }
                textWriter.Dispose();
                textWriter.Close();
            }
        }

        /// <summary>
        /// méthode de chargement du fichiers de salariés
        /// et de son remplissage dans cette liste
        /// </summary>
        /// <param name="chemin">chemin du fichier à aller chercher</param>
        /// <param name="pas">si 0 on prend en compte la première ligne sinon la deuxieme</param>
        public void LoadText( string path, int pas = 0 )
        {
            using (TextReader tR = File.OpenText(@path))
            {
                // lit la première ligne et déclare les variables 
                string ligne;
                string[] lignes;
                if ( pas == 1 )
                {
                     ligne = tR.ReadLine();
                }
                
                while ( (ligne = tR.ReadLine()) !=null )
                {
                    lignes = ligne.Split(";");
                    Salarie sal = new Salarie(lignes[1], lignes[2], lignes[0])
                    {
                        SalaireBrut = decimal.Parse(lignes[4]),
                        TauxCS = decimal.Parse(lignes[6])
                    };
                    string[] dateN = lignes[3].Split("/");
                    sal.DateNaissance = new DateTime(int.Parse(dateN[2].Substring(0, 4)), int.Parse(dateN[1]), int.Parse(dateN[0]));
                    this.Add(sal);
                }
                tR.Dispose();
                tR.Close();
            }
        }

        /// <summary>
        /// méthode qui enrgistre la liste des salariés en binaire
        /// utilisation de la sérialisation
        /// </summary>
        /// <param name="path">chemin du fichier</param>
        public void SaveBinary (string path )
        {
            using (FileStream fS = File.Exists(@path) ? File.Open(@path, FileMode.Open) : File.Open(@path, FileMode.Create))
            {
                BinaryFormatter format = new BinaryFormatter();
                format.Serialize(fS,this);
                fS.Dispose();
                fS.Close();
            }
        }

        /// <summary>
        /// méthode qui charge ma liste de salariés venant d'un fichier binaire 
        /// ici utilisation de la de-serialization
        /// </summary>
        /// <param name="path">chemin du fichier</param>
        public void LoadBinary (string path)
        {
            using (FileStream fS = File.Exists(@path) ? File.Open(@path, FileMode.Open) : File.Open(@path, FileMode.Create))
            {
                BinaryFormatter format = new BinaryFormatter();
                this.AddRange (format.Deserialize(fS) as Salaries);
                fS.Dispose();
                fS.Close();
            }
        }

        /// <summary>
        /// méthode d'enregistrement d'une liste de salaries 
        /// sous format xml en sérialisant
        /// </summary>
        /// <param name="path"></param>
        public void SaveXml (string path)
        {
            using (TextWriter tW = File.CreateText(@path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Salaries));
                ser.Serialize(tW,this);
                tW.Close();
            }
        }

        /// <summary>
        /// méthode de lecture d'un fichier sérialisé en xml
        /// </summary>
        /// <param name="path"></param>
        public void LoadXml(string path)
        {
            using (TextReader tR = File.OpenText(@path))
            {
                XmlSerializer ser = new XmlSerializer(typeof(Salaries));
                this.AddRange(ser.Deserialize(tR) as Salaries);
                tR.Close();
            }
        }

        /// <summary>
        /// méthode d'écriture dans un fichier json avec option setting
        /// TypeNameHanding pour prendre en compte l'héritage
        /// </summary>
        /// <param name="path"></param>
        public void SaveJson ( string path )
        {
            JsonSerializer output = new JsonSerializer();
            using StreamWriter sW = new StreamWriter(@path);
            using JsonWriter jW = new JsonTextWriter(sW);

            //output.Serialize(jW, this, typeof(Salaries));
            
            //mode coupe
            string preserveReferenacesAll = JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            {
                //PreserveReferencesHandling = PreserveReferencesHandling.All,
                TypeNameHandling = TypeNameHandling.All,
                //TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
            });
            output.Serialize(jW, preserveReferenacesAll);

            //mode online one
            //output.Serialize(jW, JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
            //{
                ////PreserveReferencesHandling = PreserveReferencesHandling.All,
             //   TypeNameHandling = TypeNameHandling.All,
                ////TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
            //}));

            jW.Close();
            sW.Close();
        }

        /// <summary>
        /// méthode de lecture de la sérialization en jSon
        /// </summary>
        /// <param name="path"></param>
        public void LoadJson ( string path )
        {
            JsonSerializer input = new JsonSerializer();
            using StreamReader sR = new StreamReader(@path);
            using JsonReader jR = new JsonTextReader(sR);

            // mode découpe
            string salDe = input.Deserialize(jR).ToString();
            Salaries sal = JsonConvert.DeserializeObject<Salaries>
                (salDe,
                new JsonSerializerSettings()
                {
                    //PreserveReferencesHandling = PreserveReferencesHandling.All,
                    TypeNameHandling = TypeNameHandling.All,
                    //TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
                });

            this.AddRange(sal);

            // online one
            //this.AddRange(JsonConvert.DeserializeObject<Salaries>
            //    (input.Deserialize(jR).ToString(),
            //    new JsonSerializerSettings()
            //    {
            //        //PreserveReferencesHandling = PreserveReferencesHandling.All,
            //       TypeNameHandling = TypeNameHandling.All,
            //        //TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full
            //    }));

            jR.Close();
            sR.Close();
        }

        #endregion
    }
    
   
    /// <summary>
    /// classe de gestion de salarie 
    /// avec Hashset
    /// </summary>
    public class SalarieHashSet : HashSet<Salarie> {
        
    }
}
