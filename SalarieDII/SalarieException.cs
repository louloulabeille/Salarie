using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SalarieDII
{
    /// <summary>
    /// classe de gestion des exceptions de la classe Salarie
    /// hérite de la classe ApplicationException
    /// hérite de l'interface Iserializable
    /// </summary>
    [Serializable]
    class SalarieException : ApplicationException
    {
        private string _idMessage = string.Empty;

        #region constructeur
        /// <summary>
        ///  constructeur de base
        /// </summary>
        public SalarieException()
            :base()
        {

        }

        /// <summary>
        /// constructeur avec idmessage et le message
        /// </summary>
        /// <param name="idMessage"></param>
        /// <param name="message">message qui sera affiché lors de la levé de l'exception</param>
        public SalarieException(string idMessage, string message)
            :base(message)
        {
            IdMessage = idMessage;
        }

        /// <summary>
        /// constructeur avec l'exception en plus
        /// </summary>
        /// <param name="idMessage"></param>
        /// <param name="message"></param>
        /// <param name="inner">Exception levé en parametre</param>
        public SalarieException(string idMessage, string message, Exception inner)
            :base(message,inner)
        {
            IdMessage = idMessage;
        }
        #endregion

        #region assesseur
        public string IdMessage { get => _idMessage; set => _idMessage = value; }
        #endregion

        #region serialisation
        /// <summary>
        /// constructeur avec la sérialization
        /// </summary>
        /// <param name="sInfo"></param>
        /// <param name="sContext"></param>
        protected SalarieException(SerializationInfo sInfo, StreamingContext sContext)
            :base(sInfo,sContext)
        {

        }
        #endregion
    }
}
