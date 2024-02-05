using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace concesionarioApp
{


    public class Coches
    {
        public Coches(string matricula, string modelo, string propietario, string precioCompra, string precioAlquiler, string marca, string estado, string enVenta, string enTaller, string enAlquiler, string color, string descripcion, string imagenes)
        {
            this.matricula = matricula;
            this.modelo = modelo;
            this.propietario = propietario;
            this.precioCompra = precioCompra;
            this.precioAlquiler = precioAlquiler;
            this.marca = marca;
            this.estado = estado;
            this.enVenta = enVenta;
            this.enTaller = enTaller;
            this.enAlquiler = enAlquiler;
            this.color = color;
            this.descripcion = descripcion;
            this.imagenes = imagenes;
        }

        [JsonProperty("matricula")]
        public string matricula { get; set; }
        [JsonProperty("modelo")]
        public string modelo { get; set; }
        [JsonProperty("propietario")]
        public string propietario { get; set; }
        [JsonProperty("precioCompra")]
        public string precioCompra { get; set; }
        [JsonProperty("precioAlquiler")]
        public string precioAlquiler { get; set; }
        [JsonProperty("marca")]
        public string marca { get; set; }
        [JsonProperty("estado")]
        public string estado { get; set; }
        [JsonProperty("enVenta")]
        public string enVenta { get; set; }
        [JsonProperty("enTaller")]
        public string enTaller { get; set; }
        [JsonProperty("enAlquiler")]
        public string enAlquiler { get; set; }
        [JsonProperty("color")]
        public string color { get; set; }
        [JsonProperty("descripcion")]
        public string descripcion { get; set; }
        [JsonProperty("imagenes")]
        public string imagenes { get; set; }
        [JsonProperty("motivo")]
        public string motivo { get; set; }
        [JsonProperty("precioTaller")]
        public string precioTaller { get; set; }
        [JsonProperty("fechaCita")]
        public string fechaCita { get; set; }
        [JsonProperty("fechaAdquisicion")]
        public string fechaAdquisicion { get; set; }
        [JsonProperty("esperandoVenta")]
        public string esperandoVenta { get; set; }



        public string infoCoche()
        {
            return "Matricula:" + this.matricula + " ; Modelo: " + this.modelo + " ; Propietario:"
                + this.propietario + " ; Precio Compra:" + this.precioCompra + " ; Precio Alquiler:" + this.precioCompra +
                " ; Marca:" + this.marca + " ; Estado:" + this.estado + "" + " ; Color:" + this.color + "";
        }
    }


}
