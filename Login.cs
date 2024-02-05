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
using Newtonsoft.Json;
namespace concesionarioApp
{

    public partial class Login : Form
    {
        public static Empleados user;
        public Login()
        {
            InitializeComponent();
            errorInicioLbl.Visible = false;
            errorInicioLbl2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String usuarioTexto = userTxt.Text;
            String passwordTexto = passwordTxt.Text;
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerEmpleados.php?webNoActiva=true&loginEmpleados=true&usuario=" + usuarioTexto + "&password=" + passwordTexto + "&XDEBUG_SESSION_START=netbeans-xdebug");
            try
            {
                user = JsonConvert.DeserializeObject<Empleados>(output);
                if (user.codigo >= 1)
                {
                    PaginaPrincipal perfil = new PaginaPrincipal();
                    this.Hide();
                    perfil.Show();
                }
                else
                {
                    errorInicioLbl.Visible = true;
                    errorInicioLbl.Text = user.msgInicio;
                    errorInicioLbl.ForeColor = Color.Red;

                }
            }
            catch (Exception)
            { }


        }

        private void Login_Load(object sender, EventArgs e)
        {
            TitLoginLbl.Text = Strings.login;
            usuarioLbl.Text = Strings.usuario;
            passwordLbl.Text = Strings.password;
        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}