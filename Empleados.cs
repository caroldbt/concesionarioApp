using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{
    public class Empleados
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
        [JsonProperty("puesto")]
        public string puesto { get; set; }
        [JsonProperty("msgInicio")]
        public string msgInicio { get; set; }
        public DataTable infoEmpleado() {

            DataTable dtable = new DataTable();

            dtable.Columns.Add(Strings.nombre, typeof(string));
            dtable.Columns.Add(Strings.apellidos, typeof(string));
            dtable.Columns.Add(Strings.telefono, typeof(string));
            dtable.Columns.Add(Strings.email, typeof(string));
            dtable.Columns.Add(Strings.puesto, typeof(string));
            dtable.Rows.Add(this.nombre,this.apellidos,this.telefono,this.email,this.puesto);

            return dtable;
        }
    }
}
