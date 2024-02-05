using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{
    public class MensajesChat
    {
        [JsonProperty("codigo")]
        public int codigo { get; set; }
        [JsonProperty("emisor")]
        public string emisor { get; set; }
        [JsonProperty("remitente")]
        public string remitente { get; set; }
        [JsonProperty("texto")]
        public string texto { get; set; }
        [JsonProperty("fecha")]
        public string fecha { get; set; }
        [JsonProperty("codigoEmisor")]
        public int codigoEmisor { get; set; }
    }
}
