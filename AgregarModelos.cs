using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionarioApp
{
    public partial class AgregarModelos : Form
    {
        public AgregarModelos()
        {
            InitializeComponent();
            erroresInputModelo.Visible = false;
            nombreLbl.Text = Strings.nombre;
            marcaLbl.Text = Strings.marca;
            titLbl.Text = Strings.TituloModelos;
            descripcionLbl.Text = Strings.descripcion;
            var outputMarcas = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&cargarMarcas=true");
            var registros = JsonConvert.DeserializeObject<List<Marcas>>(outputMarcas);
            for (int i = 0; i < registros.Count; i++)
            {
                marcaInput.Items.Add(registros[i].nombre);
                marcaInput.SelectedIndex = 0;

            }
        }
        private void marcaInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirmModelBtn_Click(object sender, EventArgs e)
        {
            if (validarForm() == true)
            {
                string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerModelos.php?webNoActiva=true&nuevoModelo=true&XDEBUG_SESSION_START=netbeans-xdebug";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                        {
                            "nombre",
                            nombreInput.Text
                        },
                        {
                            "marca",
                            marcaInput.SelectedItem.ToString()
                        },
                        {
                            "descripcion",
                            descripcionInput.Text
                        }
                    };

                    String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    var registros = JsonConvert.DeserializeObject<MensajesError>(resultadosWeb);

                    erroresInputModelo.Text = registros.msg.ToString();
                    MessageBox.Show(resultadosWeb.ToString());
                }
            }
            else
            {
                MessageBox.Show(Strings.erroresFormulario);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool validarForm()
        {
            bool valido = true;
            erroresInputModelo.Text = "";
            erroresInputModelo.Visible = false;
            if (nombreInput.Text.Length <= 0)
            {
                erroresInputModelo.Text = erroresInputModelo.Text + "\n" + "No se ha introducido nombre del modelo";
                valido = false;
            }
            if (descripcionInput.Text.Length <= 0)
            {
                erroresInputModelo.Text = erroresInputModelo.Text + "\n" + "No se ha introducido la descripción";
                valido = false;
            }
            if (marcaInput.SelectedItem == null)
            {
                erroresInputModelo.Text = erroresInputModelo.Text + "\n" + "No se ha seleccionado la marca";
                valido = false;
            }

            if (valido == false)
            {
                erroresInputModelo.Visible = true;
            }
            return valido;

        }
        private void backBtn_Click(object sender, EventArgs e)
        {

            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();


        }

        private void AgregarModelos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}