using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concesionarioApp
{
    class Taller
    {
        [JsonProperty("codigo")]
        public string codigo { get; set; }
        [JsonProperty("coche")]
        public string coche { get; set; }
        [JsonProperty("mecanico")]
        public string mecanico { get; set; }
        [JsonProperty("motivo")]
        public string motivo { get; set; }
        [JsonProperty("fechaSolicitud")]
        public string fechaSolicitud { get; set; }
        [JsonProperty("fechaCita")]
        public string fechaCita { get; set; }
        [JsonProperty("precio")]
        public string precio { get; set; }
        [JsonProperty("resuelto")]
        public string resuelto { get; set; }
    }
}
