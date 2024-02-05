using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionarioApp
{
    public partial class RegistrarEmpleados : Form
    {
        public RegistrarEmpleados()
        {
            InitializeComponent();
            lblErrorApellidos.Visible = false;
            lblErrorEmail.Visible = false;
            lblErrorFecha.Visible = false;
            lblErrorNombre.Visible = false;
            lblErrorPassword.Visible = false;
            lblErrorPuesto.Visible = false;
            puestoInput.Visible = true;
            lblErrorTelefono.Visible = false;
            lblErrorUsuario.Visible = false;
            puestoInput.Items.Add("ADMINISTRADOR");
            puestoInput.Items.Add("VENDEDOR");
            puestoInput.Items.Add("JEFE");
            puestoInput.Items.Add("MECANICO");
            puestoInput.SelectedIndex = 3;
            DateTime fecha = DateTime.Now;
            fechaNacimientoInput.MinDate = fecha.AddYears(-99);
            fechaNacimientoInput.MaxDate = fecha.AddYears(-18);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();
        }

        private void RegistrarEmpleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void RegistrarEmpleados_Load(object sender, EventArgs e)
        {

        }


        private bool validarCampos()
        {
            bool resultado = true;
            if (nombreInput.Text.Length < 1)
            {
                lblErrorNombre.Text = Strings.errorNombre;
                lblErrorNombre.ForeColor = Color.Red;
                lblErrorNombre.Visible = true;
                resultado = false;

            }
            else
            {
                lblErrorNombre.Visible = false;
            }
            if (apellidosInput.Text.Length < 1)
            {
                lblErrorApellidos.Text = Strings.errorApellidos;
                lblErrorApellidos.ForeColor = Color.Red;
                resultado = false;
                lblErrorApellidos.Visible = true;
            }
            else
            {
                lblErrorApellidos.Visible = false;
            }
            if (usuarioInput.Text.Length < 1)
            {

                lblErrorUsuario.Text = Strings.errorUsuario;
                lblErrorUsuario.ForeColor = Color.Red;
                resultado = false;
                lblErrorUsuario.Visible = true;
            }
            else
            {
                lblErrorUsuario.Visible = false;
            }
            if (passwordInput.Text.Length < 1)
            {
                lblErrorPassword.Text = Strings.errorPassword;
                lblErrorPassword.ForeColor = Color.Red;
                resultado = false;
                lblErrorPassword.Visible = true;

            }
            else
            {
                lblErrorPassword.Visible = false;
            }
            if (emailInput.Text.Length < 1)
            {
                lblErrorEmail.Text = Strings.errorEmail;
                lblErrorEmail.ForeColor = Color.Red;
                resultado = false;
                lblErrorEmail.Visible = true;
            }
            else
            {
                lblErrorEmail.Visible = false;
            }
            if (telefonoInput.Text.Length < 1)
            {
                lblErrorTelefono.Text = Strings.errorTelefono;
                lblErrorTelefono.ForeColor = Color.Red;
                resultado = false;
                lblErrorTelefono.Visible = true;
            }
            else
            {
                lblErrorTelefono.Visible = false;
            }
            if (puestoInput.SelectedItem == null)
            {
                lblErrorPuesto.Text = Strings.errorPuesto;
                lblErrorPuesto.ForeColor = Color.Red;
                resultado = false;
                lblErrorPuesto.Visible = true;
            }
            else
            {
                lblErrorPuesto.Visible = false;
            }
            if (fechaNacimientoInput.Value == null)
            {
                lblErrorFecha.Text = Strings.errorFechaNacimiento;
                lblErrorFecha.ForeColor = Color.Red;
                resultado = false;
                lblErrorFecha.Visible = true;
            }
            else
            {
                lblErrorFecha.Visible = false;
            }
            return resultado;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {


            bool resultado = validarCampos();
            if (resultado == true)
            {

                string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerEmpleados.php?webNoActiva=true&registroEmpleados=true&XDEBUG_SESSION_START=netbeans-xdebug";

                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                    {
                        {
                            "nombre",
                            nombreInput.Text
                        },
                        {
                            "apellidos",
                            apellidosInput.Text
                        },
                        {
                            "usuario",
                            usuarioInput.Text
                        },
                        {
                            "password",
                            passwordInput.Text
                        },
                        {
                            "email",
                            emailInput.Text
                        },
                        {
                            "telefono",
                            telefonoInput.Text
                        },
                        {
                            "puesto",
                            puestoInput.SelectedItem.ToString()
                        },
                        {
                            "fechaNacimiento",
                            fechaNacimientoInput.Text
                        },
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

        private void lblErrorTelefono_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}