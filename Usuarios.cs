using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{
    public class Usuarios
    {
        [JsonProperty("codigo")]
        public int codigo { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("apellidos")]
        public string apellidos { get; set; }
        [JsonProperty("fechaNacimiento")]
        public string fechaNacimiento { get; set; }
        [JsonProperty("usuario")]
        public string usuario { get; set; }
        [JsonProperty("password")]
        public string password { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("telefono")]
        public string telefono { get; set; }
        [JsonProperty("direccion")]
        public string direccion { get; set; }
        [JsonProperty("identificacion")]
        public string identificacion { get; set; }
        [JsonProperty("gastado")]
        public string gastado { get; set; }
    }
}
