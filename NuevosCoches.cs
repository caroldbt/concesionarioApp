using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;

namespace concesionarioApp
{
    public partial class NuevosCoches : Form
    {
        public NuevosCoches()
        {
            InitializeComponent();
        }
        private void NuevosCoches_Load(object sender, EventArgs e)
        {
			
			fechaCocheInput.MinDate=new DateTime();
			lblErrorMarca.Visible = false;
            lblErrorMatricula.Visible = false;
            lblErrorDescripcion.Visible = false;
            lblErrorEstado.Visible = false;
            lblErrorImagenes.Visible = false;
            lblErrorPrecioAlquiler.Visible = false;
            lblErrorPrecioCompra.Visible = false;
            lblErrorModelo.Visible = false;
            lblErrorColor.Visible = false;
            dataTallerList.Enabled = false;
            dataTallerbtn.Enabled = false;
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&nuevoCoche=true&modelo=toyota&propietario=1&precioCompra=20&precioAlquiler=20&marca=audi&estado=nuevo&enVenta=1&enTaller=0&enAlquiler=0&color=negro&descripcion=es_negro&imagenes=dccd.jpg&matricula=0000ZZZ");
            estadoInput.Items.Add("Nuevo");
            estadoInput.Items.Add("SemiNuevo");
            estadoInput.Items.Add("Defectuoso");
            estadoInput.Items.Add("Piezas");
            estadoInput.SelectedIndex = 0;
            propietarioBox.SelectedIndex = 1;
            colorInput.Text = "#FFFFFF";
            enVentaInput.Checked = true;
            DateTime fecha = DateTime.Now;
            fechaCocheInput.MinDate = fecha.AddYears(-70);
            colorInput.Enabled = false;
            this.enAlquilerInput.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.enVentaInput.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.enTallerInput.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            var outputMarcas = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&cargarMarcas=true");
            var registros = JsonConvert.DeserializeObject<List<Marcas>>(outputMarcas);
            for (int i = 0; i < registros.Count; i++)
            {
                marcaInput.Items.Add(registros[i].nombre);

            }
            propietarioInput.Enabled = false;
            propietarioInput.Visible = false;
        }

        private void agregarConfirmBtn_Click(object sender, EventArgs e)
        {
            bool resultado = validarCampos();
            if (resultado == true)
            {
                string matricula = "", modelo = "", propietario = "", precioCompra = "", precioAlquiler = "", marca = "", estado = "", enVenta = "";
                string enTaller = "", enAlquiler = "", color = "", descripcion = "", imagenes = "";

                /*
                                                                                 * S
            Coches coche = new Coches(matricula, modelo, propietario, precioCompra, precioAlquiler, marca, estado,
                 enVenta, enTaller, enAlquiler, color, descripcion, imagenes);*/

                matricula = matriculaInput.Text;
                modelo = modelosInput.Text;
                if (propietarioBox.SelectedItem.ToString().ToUpper().Equals("SI"))
                {
                    var valor = propietarioInput.SelectedItem.ToString().Split('\t');
                    propietario = valor[0];
                }
                else
                {
                    propietario = null;
                }

                precioCompra = precioCompraInput.Text;
                precioAlquiler = precioAlquilerInput.Text;
                marca = marcaInput.Text;
                estado = estadoInput.Text;
                enVenta = enVentaInput.Checked ? "1" : "0";
                enTaller = enTallerInput.Checked ? "1" : "0";
                enAlquiler = enAlquilerInput.Checked ? "1" : "0";
                color = colorInput.Text;
                descripcion = descripcionInput.Text;
                imagenes = String.Join("|", imgList.Items.OfType<string>().ToArray());


                string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&nuevoCoche=true&XDEBUG_SESSION_START=netbeans-xdebug";

                string motivo = "", precioTaller = "", fechaCita = "";
                if (dataTallerList.Items.Count > 1)
                {
                    motivo = dataTallerList.Items[0].ToString();
                    precioTaller = dataTallerList.Items[1].ToString();
                    fechaCita = dataTallerList.Items[2].ToString();

                }
                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                        {
                            "matricula",
                            matricula
                        },
                        {
                            "modelo",
                            modelo
                        },
                        {
                            "propietario",
                            propietario
                        },
                        {
                            "precioCompra",
                            precioCompra
                        },
                        {
                            "precioAlquiler",
                            precioAlquiler
                        },
                        {
                            "marca",
                            marca
                        },
                        {
                            "estado",
                            estado
                        },
                        {
                            "enVenta",
                            enVenta
                        },
                        {
                            "enTaller",
                            enTaller
                        },
                        {
                            "enAlquiler",
                            enAlquiler
                        },
                        {
                            "color",
                            color
                        },
                        {
                            "descripcion",
                            descripcion
                        },
                        {
                            "imagenes",
                            imagenes.ToString()
                        },
                        {
                            "motivo",
                            motivo
                        },
                        {
                            "fechaCita",
                            fechaCita
                        },
                        {
                            "precioTaller",
                            precioTaller
                        }
                    };


                    String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    MessageBox.Show(resultadosWeb);

                }
            }
            else
            {
                MessageBox.Show(Strings.erroresFormulario);
            }
        }

        private void propietarioBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (propietarioBox.SelectedItem.ToString().ToUpper().Equals("SI"))
            {
                propietarioInput.Enabled = true;
                propietarioInput.Visible = true;
                try
                {
                    var outputUsuarios = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerUsuarios.php?webNoActiva=true&buscarUsuarios=true");
                    var registros = JsonConvert.DeserializeObject<List<Usuarios>>(outputUsuarios);
                    for (int i = 0; i < registros.Count; i++)
                    {
                        propietarioInput.Items.Add(registros[i].codigo + "\t" + registros[i].nombre + "\t" + registros[i].apellidos);
                        propietarioInput.SelectedIndex = 0;
                    }
                }
                catch (Exception)
                { }
            }
            else
            {
                propietarioInput.Enabled = false;
                propietarioInput.Visible = false;
            }
        }

        private void elegirColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = colorInput.ForeColor;
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                colorInput.ForeColor = MyDialog.Color;
                colorInput.Text = "#" + (MyDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                colorInput.BackColor = MyDialog.Color;
            }


        }

        private void modelosInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void marcaInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelosInput.Items.Clear();
            var outputModelos = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerModelos.php?webNoActiva=true&cargarModelos=true&marca=" + marcaInput.SelectedItem + "");
            var registros = JsonConvert.DeserializeObject<List<Modelos>>(outputModelos);

            if (registros != null && registros.Count > 0)
            {
                for (int i = 0; i < registros.Count; i++)
                {
                    modelosInput.Items.Add(registros[i].nombre);
                    modelosInput.SelectedIndex = 0;

                }


            }
            else
            {
                MessageBox.Show("No hay modelos para la marca introducida, escoge otra");
            }
        }

        private void precioCompraInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void precioAlquilerInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();
        }

        private void matriculaInput_TextChanged(object sender, EventArgs e)
        {
            if (matriculaInput.Text.Length <= 4 && matriculaInput.Text.Length > 0)
            {
                char c = matriculaInput.Text[matriculaInput.Text.Length - 1];
                if (char.IsDigit(c) == false)
                {

                    MessageBox.Show("no se puede introducir valores que no sean números");
                    matriculaInput.Text = matriculaInput.Text.Substring(0, matriculaInput.Text.Length - 1);
                    matriculaInput.SelectionStart = matriculaInput.Text.Length;
                    matriculaInput.SelectionLength = 0;
                }
            }
            else if (matriculaInput.Text.Length > 4)
            {
                char c = matriculaInput.Text[matriculaInput.Text.Length - 1];
                if (char.IsDigit(c))
                {

                    MessageBox.Show("no se puede introducir mas numeros");
                    matriculaInput.Text = matriculaInput.Text.Substring(0, matriculaInput.Text.Length - 1);
                    matriculaInput.SelectionStart = matriculaInput.Text.Length;
                    matriculaInput.SelectionLength = 0;
                }
                else if (char.IsLetter(c) == false)
                {
                    MessageBox.Show("no se puede introducir valores que no sean letras");
                    matriculaInput.Text = matriculaInput.Text.Substring(0, matriculaInput.Text.Length - 1);
                    matriculaInput.SelectionStart = matriculaInput.Text.Length;
                    matriculaInput.SelectionLength = 0;
                }
                else
                {
                    string cadena = "";
                    cadena = matriculaInput.Text.Substring(0, matriculaInput.Text.Length - 1);
                    matriculaInput.Text = cadena + Char.ToUpper(c) + "";
                    matriculaInput.SelectionStart = matriculaInput.Text.Length;
                }
            }

        }
        private bool validarCampos()
        {
            bool resultado = true;
            if (matriculaInput.Text.Length < 7)
            {
                lblErrorMatricula.Text = Strings.errorMatricula;
                lblErrorMatricula.ForeColor = Color.Red;
                lblErrorMatricula.Visible = true;
                resultado = false;

            }
            else
            {
                lblErrorMatricula.Visible = false;
            }
            if (modelosInput.SelectedItem == null)
            {
                lblErrorModelo.Text = Strings.errorModelo;
                lblErrorModelo.ForeColor = Color.Red;
                resultado = false;
                lblErrorModelo.Visible = true;
            }
            else
            {
                lblErrorModelo.Visible = false;
            }
            if (precioCompraInput.Text.Length < 1)
            {

                lblErrorPrecioCompra.Text = Strings.errorPrecioCompra;
                lblErrorPrecioCompra.ForeColor = Color.Red;
                resultado = false;
                lblErrorPrecioCompra.Visible = true;
            }
            else
            {
                lblErrorPrecioCompra.Visible = false;
            }
            if (precioAlquilerInput.Text.Length < 1)
            {
                lblErrorPrecioAlquiler.Text = Strings.errorPrecioAlquiler;
                lblErrorPrecioAlquiler.ForeColor = Color.Red;
                resultado = false;
                lblErrorPrecioAlquiler.Visible = true;

            }
            else
            {
                lblErrorPrecioAlquiler.Visible = false;
            }
            if (marcaInput.SelectedItem == null)
            {
                lblErrorMarca.Text = Strings.errorMarca;
                lblErrorMarca.ForeColor = Color.Red;
                resultado = false;
                lblErrorMarca.Visible = true;
            }
            else
            {
                lblErrorMarca.Visible = false;
            }
            if (estadoInput.SelectedItem == null)
            {
                lblErrorEstado.Text = Strings.errorEstado;
                lblErrorEstado.ForeColor = Color.Red;
                resultado = false;
                lblErrorEstado.Visible = true;
            }
            else
            {
                lblErrorEstado.Visible = false;
            }
            if (colorInput.Text == null)
            {
                lblErrorColor.Text = Strings.errorColor;
                lblErrorColor.ForeColor = Color.Red;
                resultado = false;
                lblErrorColor.Visible = true;
            }
            else
            {
                lblErrorColor.Visible = false;
            }
            if (descripcionInput.Text.Length < 1)
            {
                lblErrorDescripcion.Text = Strings.errorDescripcion;
                lblErrorDescripcion.ForeColor = Color.Red;
                resultado = false;
                lblErrorDescripcion.Visible = true;
            }
            else
            {
                lblErrorDescripcion.Visible = false;
            }
            if (imgList.Items.Count < 1)
            {

                lblErrorImagenes.Text = Strings.errorImagenes;
                lblErrorImagenes.ForeColor = Color.Red;
                resultado = false;
                lblErrorImagenes.Visible = true;
            }
            else
            {
                lblErrorImagenes.Visible = false;
            }
            return resultado;
        }
        private void colorInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupCoche_Enter(object sender, EventArgs e)
        {

        }

        private void NuevosCoches_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            imagenesInput.Text = imagenesInput.Text.Trim();
            if (imagenesInput.Text != "")
            {
                imgList.Items.Add(imagenesInput.Text);
                imagenesInput.Text = "";

            }
        }

        private void dataTallerbtn_Click(object sender, EventArgs e)
        {
            DatosTaller datosT = new DatosTaller(this);
            datosT.ShowDialog();
            List<string> datosDelTaller = datosT.getData();
            if (datosDelTaller.Count > 1)
            {
                dataTallerList.Items.Clear();
            }
            for (int i = 0; i < datosDelTaller.Count; i++)
            {
                dataTallerList.Items.Add(datosDelTaller[i].ToString());
            }
        }
        private void dataTallerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked == true)
            {
                if (rb.Name.Equals("enTallerInput"))
                {
                    dataTallerbtn.Enabled = true;
                    dataTallerList.Enabled = true;
                    return;
                }
                else
                {
                    dataTallerList.Enabled = false;
                    dataTallerbtn.Enabled = false;

                }
            }
        }

        private void imgList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgList.SelectedIndex >= 0)
            {
                imgList.Items.RemoveAt(imgList.SelectedIndex);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

		private void fechaCocheInput_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}