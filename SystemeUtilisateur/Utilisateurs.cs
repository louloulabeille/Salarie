using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SystemeUtilisateur
{
    /// <summary>
    ///  classe de liste d'utilisateur
    /// </summary>
    public class Utilisateurs : List<Utilisateur>
    {
        protected const string _path = "utilisateurs.json";
        
        #region méthode de gestion de la liste
        /// <summary>
        /// méthode qui va extraire l'utilisateur dans la liste
        /// </summary>
        /// <param name="nomUtil">Nom utilisateur</param>
        /// <returns></returns>
        public Utilisateur Extract(string nomUtil)
        {
            return base.Find(x => x.NomUtil.Equals(nomUtil));
        }

        /// <summary>
        /// ajoute a la liste un nouvel utilisateur
        /// </summary>
        /// <param name="item">object Utilisateur à ajouter</param>
        public new void Add(Utilisateur item)
        {
            if ( item!= null && !this.Contains(item))
            {
                base.Add(item);
            }
            else
            {
                OnEventNomUtil();
                throw (new ApplicationException("Impossible d'ajouter un nouvel utilisateur qui existe déjà.\nChanger le nom d'utilisateur."));
            }
        }

        /// <summary>
        /// Supprime un utilisateur dans la liste
        /// </summary>
        /// <param name="item">object Utilisateur à supprimer</param>
        /// <returns></returns>
        public new bool Remove(Utilisateur item)
        {
            return base.Remove(item);
        }

        /// <summary>
        /// supprime un utilisateur qui a pour nom et mot de passe défini
        /// </summary>
        /// <param name="nomUtil">nom utilisateur</param>
        /// <returns></returns>
        public bool Remove (string nomUtil)
        {
            return Remove(Extract(nomUtil));
        }
        #endregion

        #region système de sauvegarde et de chargement des utilisateurss
        public void SaveJson()
        {
            JsonSerializer jS = new JsonSerializer();
            using StreamWriter sW = new StreamWriter(_path);
            using JsonWriter jW = new JsonTextWriter(sW);

            jS.Serialize(jW, JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            })) ;

            jW.Close();
            sW.Close();

        }

        public void LoadJson()
        {
            JsonSerializer jS = new JsonSerializer();
            using StreamReader sR = new StreamReader(_path);
            using JsonReader jR = new JsonTextReader(sR);

            this.AddRange(JsonConvert.DeserializeObject<Utilisateurs>(jS.Deserialize(jR).ToString(),
                    new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.All
                    }));
            jR.Close();
            sR.Close();

        }
        #endregion

        #region event

        /// <summary>
        /// evenement et ca méthode qui se lève quand
        /// le nom utilisateur est identique a un nom utilisateur déjà existant
        /// </summary>
        public event EventHandler EventNomUtil;

        protected virtual void OnEventNomUtil()
        {
            EventHandler handler = EventNomUtil;
            handler?.Invoke(this, new EventArgs());
        }
        ///////////

        #endregion

    }
}
