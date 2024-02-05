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
    public partial class ActualizarCoche : Form
    {
        String matriculaCoche, marcaCoche, modeloCoche;

        public ActualizarCoche(String matricula)
        {
            InitializeComponent();
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&buscarCoches=true&matricula=" + matricula + "&XDEBUG_SESSION_START=netbeans-xdebug");

            try
            {
                var registros = JsonConvert.DeserializeObject<Coches>(output);



                //    var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&buscarCoches=true&matricula=" + matricula + "&XDEBUG_SESSION_START=netbeans-xdebug");

                //   lblErrorMarca.Visible = false;
                // lblErrorMatricula.Visible = false;
                lblErrorDescripcion.Visible = false;
                lblErrorEstado.Visible = false;
                lblErrorImagenes.Visible = false;
                lblErrorPrecioAlquiler.Visible = false;
                lblErrorPrecioCompra.Visible = false;
                // lblErrorModelo.Visible = false;
                lblErrorColor.Visible = false;

                this.enAlquilerInput.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
                this.enVentaInput.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
                this.enTallerInput.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

                var a = registros;
                if (registros.propietario != "")
                {
                    propietarioOriLbl.Text = registros.propietario;
                }
                else
                {
                    propietarioOriLbl.Text = "Nadie";
                }

                precioCompraInput.Text = registros.precioCompra;
                precioAlquilerInput.Text = registros.precioAlquiler;
                colorInput.Text = registros.color;
                matriculaLabel.Text = registros.matricula;
                matriculaCoche = registros.matricula;
                descripcionInput.Text = registros.descripcion;
                string[] listaImagenes = registros.imagenes.Split(',');
                for (int i = 0; i < listaImagenes.Count(); i++)
                {
                    imgList.Items.Add(listaImagenes[i]);
                }
                //imagenesInput.Text = registros.imagenes;
                estadoInput.Items.Add("Nuevo");
                estadoInput.Items.Add("SemiNuevo");
                estadoInput.Items.Add("Defectuoso");
                estadoInput.Items.Add("Piezas");
                if (registros.motivo != "")
                {
                    dataTallerList.Items.Add(registros.motivo);
                }
                if (registros.precioTaller != "")
                {
                    dataTallerList.Items.Add(registros.precioTaller);
                }
                if (registros.fechaCita != "")
                {
                    dataTallerList.Items.Add(registros.fechaCita);
                }

                estadoInput.SelectedItem = registros.estado;
                if (registros.enAlquiler == "1")
                {
                    enAlquilerInput.Checked = true;
                }
                else if (registros.enVenta == "1")
                {
                    enVentaInput.Checked = true;
                }
                else if (registros.enTaller == "1")
                {
                    enTallerInput.Checked = true;
                }

                marcaCoche = registros.marca;
                modeloCoche = registros.modelo;

                var outputUsuarios = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerUsuarios.php?webNoActiva=true&buscarUsuarios=true");
                var registrosUsuario = JsonConvert.DeserializeObject<List<Usuarios>>(outputUsuarios);
                propietarioInput.Items.Add("Nadie");
                for (int i = 0; i < registrosUsuario.Count; i++)
                {
                    propietarioInput.Items.Add(registrosUsuario[i].codigo + "\t" + registrosUsuario[i].nombre + "\t" + registrosUsuario[i].apellidos);
                    propietarioInput.SelectedIndex = 0;
                }

            }
            catch (Exception e)
            { }
        }

        /*      private void agregarConfirmBtn_Click(object sender, EventArgs e)
              {
                  bool resultado = validarCampos();
                  if (resultado == true)
                  {
                      string matricula = "", modelo = "", propietario = "", precioCompra = "", precioAlquiler = "", marca = "", estado = "", enVenta = "";
                      string enTaller = "", enAlquiler = "", color = "", descripcion = "", imagenes = "";
                      Coches coche = new Coches(matricula, modelo, propietario, precioCompra, precioAlquiler, marca, estado,
                          enVenta, enTaller, enAlquiler, color, descripcion, imagenes);

                      var valor = propietarioInput.SelectedItem.ToString().Split('\t');
                      propietario = valor[0];
                      precioCompra = precioCompraInput.Text;
                      precioAlquiler = precioAlquilerInput.Text;
                      estado = estadoInput.Text;
                      enVenta = enVentaInput.Checked ? "1" : "0";
                      enTaller = enTallerInput.Checked ? "1" : "0";
                      enAlquiler = enAlquilerInput.Checked ? "1" : "0";
                      color = colorInput.Text;
                      descripcion = descripcionInput.Text;
                      imagenes = imagenesInput.Text;

                      string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&actualizarCoche=true&XDEBUG_SESSION_START=netbeans-xdebug";
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
                                  imagenes
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
                          MessageBox.Show(resultadosWeb.ToString());
                      }
                  }
                  else
                  {
                      MessageBox.Show("Errores en el formulario");
                  }
              }
      */
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

        private bool validarCampos()
        {
            bool resultado = true;

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
            if (imgList.Items == null)
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

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (imgList.SelectedIndex >= 0)
            {
                imgList.Items.RemoveAt(imgList.SelectedIndex);
            }
        }

        private void imgButton_Click(object sender, EventArgs e)
        {
            imgList.Items.Add(imagenesInput.Text);
            imagenesInput.Text = "";

        }

        private void ActualizarCoche_Load(object sender, EventArgs e)
        {

        }

        private void precioAlquilerInput_TextChanged(object sender, EventArgs e)
        {

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

        private void ActualizarCoche_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void agregarConfirmBtn_Click_1(object sender, EventArgs e)
        {

            bool resultado = validarCampos();
            if (resultado == true)
            {
                string matricula = "", modelo = "", propietario = "", precioCompra = "", precioAlquiler = "", marca = "", estado = "", enVenta = "";
                string enTaller = "", enAlquiler = "", color = "", descripcion = "", imagenes = "";
                var valor = propietarioInput.SelectedItem.ToString().Split('\t');
                propietario = valor[0];
                if (propietario.Equals("Nadie"))
                {
                    propietario = "0";
                }
                precioCompra = precioCompraInput.Text;
                precioAlquiler = precioAlquilerInput.Text;
                estado = estadoInput.Text;
                enVenta = enVentaInput.Checked ? "1" : "0";
                enTaller = enTallerInput.Checked ? "1" : "0";
                enAlquiler = enAlquilerInput.Checked ? "1" : "0";
                color = colorInput.Text;
                descripcion = descripcionInput.Text;
                imagenes = String.Join("|", imgList.Items.OfType<string>().ToArray());

                string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&actualizarCoche=true&XDEBUG_SESSION_START=netbeans-xdebug";
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
                            "marca",
                            marcaCoche
                        },
                        {
                            "modelo",
                            modeloCoche
                        },
                        {
                            "matricula",
                            matriculaCoche
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
                    MessageBox.Show(resultadosWeb.ToString());
                }
            }
            else
            {
                MessageBox.Show(Strings.erroresFormulario);
            }
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
    }
}