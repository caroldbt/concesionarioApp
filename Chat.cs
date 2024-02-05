using Newtonsoft.Json;
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
    public partial class Chat : Form
    {
        public Chat()
        {
            InitializeComponent();

        }
        private int codigEmisor;
        private void backButton_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();
        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        List<MensajesChat> mensajes;
        List<MensajesChat> mensajeEmpleado;
        private void Chat_Load(object sender, EventArgs e)
        {
            enviarBtn.Enabled = false;
            elegirUsuario.Enabled = false;
            codigEmisor = 0;
            cargarConversaciones();
            cargarUsuarios();

        }



        private void cargarConversaciones()
        {


            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerMensajes.php?webNoActiva=true&CargarMensajes=true&empleado=true&codigoUsuario=" + Login.user.codigo + "&XDEBUG_SESSION_START=netbeans-xdebug");
            mensajes = JsonConvert.DeserializeObject<List<MensajesChat>>(output);
            listMensajes.Items.Clear();
            
            for (int i = 0; i < mensajes.Count; i++)
            {
                if (listMensajes.Items.Contains(mensajes[i].emisor) == false)
                {
                    listMensajes.Items.Add(mensajes[i].emisor);
                }

            }

        }

        private void cargarUsuarios()
        {
            // listaUsuarioMensajes

            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerUsuarios.php?webNoActiva=true&mostrarUsuarios=true&empleado=true&codigoUsuario=" + Login.user.codigo + "&XDEBUG_SESSION_START=netbeans-xdebug");
            var listaUsuarios = JsonConvert.DeserializeObject<List<Usuarios>>(output);
            listaUsuarioMensajes.Items.Clear();
            bool ignorar = false;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                ignorar = false;
                for (int j = 0; j < mensajes.Count; j++)
                {

                    if (listaUsuarios[i].codigo == mensajes[j].codigoEmisor)
                    {
                        ignorar = true;
                    }
                }
                if (ignorar == false)
                {
                    listaUsuarioMensajes.Items.Add(listaUsuarios[i].codigo + "\t" + listaUsuarios[i].nombre + "\t" + listaUsuarios[i].apellidos);

                }

            }

        }


        private void mensajesEmpleado(int emisor)
        {
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerMensajes.php?webNoActiva=true&BuscarMensajes=true&empleado=true&codigoUsuario=" + Login.user.codigo + "&codigoEmisor=" + emisor + "&XDEBUG_SESSION_START=netbeans-xdebug");
            mensajeEmpleado = JsonConvert.DeserializeObject<List<MensajesChat>>(output);
        }
        private void listMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarMensajes();
            elegirUsuario.Enabled = false;
            listaUsuarioMensajes.SelectedIndex = -1;
            enviarBtn.Enabled = true;
            elegirUsuario.Enabled = false;
        }

        /*
         
         
                 private void cargarMensajes()
        {
            if (listMensajes.SelectedItem != null)
            {

                conversacionesList.Items.Clear();
                for (int i = 0; i < mensajes.Count; i++)
                {
                    if (listMensajes.SelectedItem.ToString().Equals(mensajes[i].emisor))
                    {
                        codigEmisor = mensajes[i].codigoEmisor;
                        mensajesEmpleado(mensajes[i].codigoEmisor);
                        break;
                    }

                }
                for (int i = 0; i < mensajes.Count; i++)
                {
                    if (codigEmisor == mensajes[i].codigoEmisor)
                    {

                        mensajeEmpleado.Add(mensajes[i]);

                    }

                }
                mensajeEmpleado.Sort(delegate (MensajesChat x, MensajesChat y)
                {
                    if (x.fecha == null && y.fecha == null) return 0;
                    else if (x.fecha == null) return -1;
                    else if (y.fecha == null) return 1;
                    else return x.fecha.CompareTo(y.fecha);
                });

                for (int j = 0; j < mensajeEmpleado.Count; j++)
                {

                    if (mensajeEmpleado[j].codigoEmisor == codigEmisor)
                    {
                        conversacionesList.Items.Add(mensajeEmpleado[j].emisor.ToString() + " " + "/ " + mensajeEmpleado[j].fecha.ToString());
                        //  conversacionesList.Items[0].Drawing.ForeColor = Color.Red;
                        conversacionesList.Items.Add("==--->" + mensajeEmpleado[j].texto.ToString());

                    }
                    else
                    {
                        conversacionesList.Items.Add("Yo: " + "/ " + mensajeEmpleado[j].fecha.ToString());
                        conversacionesList.Items.Add("==>" + mensajeEmpleado[j].texto.ToString());
                    }
                    conversacionesList.Items.Add("\n");


                }
            }
        }
         
         */

        private void cargarMensajes()
        {
            if (listMensajes.SelectedItem != null)
            {

                conversacionesList.Items.Clear();
                for (int i = 0; i < mensajes.Count; i++)
                {
                    if (listMensajes.SelectedItem.ToString().Equals(mensajes[i].emisor))
                    {
                        codigEmisor = mensajes[i].codigoEmisor;
                        mensajesEmpleado(mensajes[i].codigoEmisor);
                        break;
                    }

                }
                for (int i = 0; i < mensajes.Count; i++)
                {
                    if (codigEmisor == mensajes[i].codigoEmisor)
                    {

                        mensajeEmpleado.Add(mensajes[i]);

                    }

                }
                mensajeEmpleado.Sort(delegate (MensajesChat x, MensajesChat y)
                {
                    if (x.fecha == null && y.fecha == null) return 0;
                    else if (x.fecha == null) return -1;
                    else if (y.fecha == null) return 1;
                    else return x.fecha.CompareTo(y.fecha);
                });

                for (int j = 0; j < mensajeEmpleado.Count; j++)
                {
                    if (mensajeEmpleado[j].texto != "")
                    {
                        if (mensajeEmpleado[j].codigoEmisor == codigEmisor)
                        {
                            conversacionesList.Items.Add(mensajeEmpleado[j].emisor.ToString() + " " + "/ " + mensajeEmpleado[j].fecha.ToString());
                            //  conversacionesList.Items[0].Drawing.ForeColor = Color.Red;
                            conversacionesList.Items.Add("==--->" + mensajeEmpleado[j].texto.ToString());

                        }
                        else
                        {
                            conversacionesList.Items.Add("Yo: " + "/ " + mensajeEmpleado[j].fecha.ToString());
                            conversacionesList.Items.Add("==>" + mensajeEmpleado[j].texto.ToString());
                        }
                        conversacionesList.Items.Add("\n");
                    }
                }
            }
        }
        private void enviarBtn_Click(object sender, EventArgs e)
        {
            var seleccionado = listMensajes.SelectedIndex;
            string mensajeNuevo = enviarInput.Text;
            string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerMensajes.php?webNoActiva=true&nuevoMensaje=true&empleado=true&XDEBUG_SESSION_START=netbeans-xdebug";
            int codigoUser = Login.user.codigo;
            string fecha = DateTime.Now.ToString();
            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                    {
                        "mensaje",
                        mensajeNuevo
                    },
                    {
                        "emisor",
                        codigoUser.ToString()
                    },
                    {
                        "remitente",
                        codigEmisor.ToString()
                    }

                };


                String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                MessageBox.Show(resultadosWeb.ToString());
                incializarMensajes();
                listMensajes.SelectedIndex = seleccionado;
            }
        }
        private void incializarMensajes()
        {
            cargarUsuarios();
            cargarConversaciones();
            enviarInput.Text = "";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // listMensajes.Items.Add(listaUsuarioMensajes.SelectedItem.ToString());
            //istMensajes.SelectedIndex = listMensajes.Items.Count - 1;
            string cadena = listaUsuarioMensajes.SelectedItem.ToString();
            string[] mensajeDivid = cadena.Split('\t');
            codigEmisor = Int32.Parse(mensajeDivid[0]);

            string mensajeNuevo = enviarInput.Text;
            string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerMensajes.php?webNoActiva=true&nuevoMensaje=true&empleado=true&XDEBUG_SESSION_START=netbeans-xdebug";
            int codigoUser = Login.user.codigo;
            string fecha = DateTime.Now.ToString();
            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                    {
                        "mensaje",
                        mensajeNuevo
                    },
                    {
                        "emisor",
                        codigoUser.ToString()
                    },
                    {
                        "remitente",
                        codigEmisor.ToString()
                    }

                };


                String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                MessageBox.Show(resultadosWeb.ToString());
                incializarMensajes();
                elegirUsuario.Enabled = false;
                listaUsuarioMensajes.SelectedIndex = -1;

            }

        }

        private void listaUsuarioMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            elegirUsuario.Enabled = true;
            enviarBtn.Enabled = false;
            listMensajes.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}