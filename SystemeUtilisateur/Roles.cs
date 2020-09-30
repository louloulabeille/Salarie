using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SystemeUtilisateur
{
    /// <summary>
    /// classe de gestion des roles pour un utilisateur
    /// </summary>
    public class Roles : List<Role>
    {
        //adresse et nom du fichier des roles
        private const string _path = "role.json";

        #region méthode de gestion venant de l'héritage de List<>
        /// <summary>
        /// ajoute un nouveau role pour un utilisateur
        /// </summary>
        /// <param name="item">nouveau role</param>
        public new void Add( Role item )
        {
            if ( item != null && !this.Contains(item))
            {
                base.Add(item);
            }
        }

        /// <summary>
        /// supprime un role pour utilisateur
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public new bool Remove( Role item )
        {
            return base.Remove(item);
        }

        /// <summary>
        /// Retourne tous les roles d'un utilisateur
        /// </summary>
        /// <param name="idUtil"></param>
        /// <returns></returns>
        public Roles FindAll(string idUtil)
        {
            Roles r = new Roles();
            r.AddRange(base.FindAll(x => x.IdUtil.Equals(idUtil)));
            return r;
        }
        #endregion

        #region méthode d'enregistrement des roles

        /// <summary>
        /// méthode d'enregistrement des roles des utilisateurs dans la base
        /// </summary>
        /// <returns></returns>
        public bool SaveJson ()
        {
            try
            {
                JsonSerializer jS = new JsonSerializer();
                using StreamWriter tw = new StreamWriter(_path);
                using JsonWriter jW = new JsonTextWriter(tw);

                jS.Serialize(tw, JsonConvert.SerializeObject(this, Formatting.Indented, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                }));
                return true;
            } catch( JsonException e )
            {
                OnEventJsonError( new EventJsonErrorEventArgs(e));
                return false;
            }
        }

        /// <summary>
        /// méthode de chargement de tous les roles des utilisateurs
        /// </summary>
        /// <returns></returns>
        public bool LoadJson()
        {
            try
            {
                JsonSerializer jS = new JsonSerializer();
                using StreamReader sR = new StreamReader(_path);
                using JsonReader jR = new JsonTextReader(sR);

                this.AddRange(JsonConvert.DeserializeObject<Roles>(jS.Deserialize(jR).ToString(),
                    new JsonSerializerSettings()
                    {
                        TypeNameHandling = TypeNameHandling.All
                    }));
               

                return true;
            }catch (JsonException e)
            {
                OnEventJsonError( new EventJsonErrorEventArgs(e));
                return false;
            }
        }
        #endregion

        #region event de la classe Roles
        public event EventHandler<EventJsonErrorEventArgs> EventJsonError;

        protected virtual void OnEventJsonError( EventJsonErrorEventArgs e)
        {
            EventHandler<EventJsonErrorEventArgs> handler = EventJsonError;
            handler?.Invoke(this, e);
        }
        #endregion

    }
}
