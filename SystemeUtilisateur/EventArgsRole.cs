using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeUtilisateur
{
    public class EventJsonErrorEventArgs : EventArgs
    {
        private JsonException _error;

        public EventJsonErrorEventArgs(JsonException error)
        {
            Error = error;
        }

        public JsonException Error { get => _error; set => _error = value; }
    }

}
