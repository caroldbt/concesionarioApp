using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{


    public class Marcas
    {

        [JsonProperty("codigo")]
        public string codigo { get; set; }
        [JsonProperty("nombre")]
        public string nombre { get; set; }

    }
    

}
