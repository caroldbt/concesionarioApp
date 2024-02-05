using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{
    public class MensajesError
    {
        [JsonProperty("msg")]
        public string msg { get; set; }
    }
}
