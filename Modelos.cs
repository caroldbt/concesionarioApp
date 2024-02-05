using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{


    public class Modelos
    {

        [JsonProperty("codigo")]
        public string codigo { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }
        [JsonProperty("marca")]
        public string marca { get; set; }
        [JsonProperty("descripcion")]
        public string descripcion { get; set; }

    }


}
