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
    public partial class ComprobarTaller : Form
    {

        string filtroActual;

        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked == true)
            {
                actualizarBtn.Enabled = true;
                if (rb.Name.Equals("esperarValidacionRd"))
                {
                    tablaCoche("filtro=SinMecanico");
                    return;
                }
                else if (rb.Name.Equals("resueltasRd"))
                {
                    filtroActual = "resueltasRd";
                    tablaCoche("filtro=resueltas");
                    actualizarBtn.Enabled = false;
                    return;
                }
                else if (rb.Name.Equals("noResuletasRd"))
                {
                    tablaCoche("filtro=noresueltas");
                    return;
                }
            }
        }


        public ComprobarTaller()
        {

            InitializeComponent();
            esperarValidacionRd.Text = Strings.esperarValidacionRd;
            resueltasRd.Text = Strings.resueltasRd;
            noResuletasRd.Text = Strings.noResuletasRd;

            esperarValidacionRd.Checked = true;
            //this.NuevosButton.Text = Strings.NuevosButton;
            esperarValidacionRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            resueltasRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            noResuletasRd.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

            tablaCoche("filtro=SinMecanico");
        }

        /*


 */
        DataTable dtable;
        private void tablaCoche(String filtro)
        {
            this.dataCarView.Columns.Clear();
            dtable = new DataTable();
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerTaller.php?webNoActiva=true&mostrarTaller=true&" + filtro + "&XDEBUG_SESSION_START=netbeans-xdebug");
            try
            {
                var registros = JsonConvert.DeserializeObject<List<Taller>>(output);
                var a = registros;
                if (registros != null && registros.Count >= 1)
                {
                    dtable.Columns.Add(Strings.codigo, typeof(string));
                    dtable.Columns.Add(Strings.coche, typeof(string));
                    if (filtro.Equals("filtro=SinMecanico") == false)
                    {
                        dtable.Columns.Add(Strings.mecanico, typeof(string));
                    }

                    dtable.Columns.Add(Strings.motivo, typeof(string));
                    dtable.Columns.Add(Strings.fechaSolicitud, typeof(string));
                    dtable.Columns.Add(Strings.fechaCita, typeof(string));
                    dtable.Columns.Add(Strings.precio, typeof(string));
                    dtable.Columns.Add(Strings.resuelto, typeof(string));

                    // int columnIndex = 0;

                    for (int i = 0; i < registros.Count; i++)
                    {
                        //  dtable.Rows.Add(1, registros[i].coche.ToString());

                        if (filtro.Equals("filtro=SinMecanico") == false)
                        {

                            dtable.Rows.Add(registros[i].codigo, registros[i].coche, registros[i].mecanico, registros[i].motivo, registros[i].fechaSolicitud,
                                registros[i].fechaSolicitud, registros[i].precio, registros[i].resuelto);
                        }
                        else
                        {
                            dtable.Rows.Add(registros[i].codigo, registros[i].coche, registros[i].motivo, registros[i].fechaSolicitud,
                                registros[i].fechaSolicitud, registros[i].precio, registros[i].resuelto);


                        }
                    }
                    if (filtro.Equals("filtro=SinMecanico") == true)
                    {
                        filtroActual = "SinMecanico";
                        cmbMecanicosTabla();
                    }
                    else if (filtro.Equals("filtro=noresueltas") == true)
                    {
                        filtroActual = "noresueltas";
                        validarTabla();
                    }
                }
            }
            catch (Exception e)
            {

            }


            dataCarView.DataSource = dtable;

        }
        private void validarTabla()
        {

            DataGridViewCheckBoxColumn dgvChb = new DataGridViewCheckBoxColumn();
            dgvChb.HeaderText = "Validaciones";
            dgvChb.Name = "Validaciones";
            dgvChb.FlatStyle = FlatStyle.Standard;
            dataCarView.Columns.Add(dgvChb);
        }
        private void cmbMecanicosTabla()
        {
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerEmpleados.php?webNoActiva=true&cargarEmpleados=true");
            var registros = JsonConvert.DeserializeObject<List<Empleados>>(output);

            if (registros != null)
            {

                DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
                dgvCmb.HeaderText = "Mecanicos";
                dgvCmb.Name = "Mecanicos";
                dgvCmb.HeaderText = "Mecanicos";
                for (int i = 0; i < registros.Count; i++)
                {
                    if (registros[i].puesto.ToUpper().Equals("MECANICO"))
                    {
                        dgvCmb.Items.Add(registros[i].codigo + "\t" + registros[i].nombre + "\t" + registros[i].apellidos);
                    }
                }

                dgvCmb.Name = "Mecanicos";
                dataCarView.Columns.Add(dgvCmb);


                // DataGridViewTextBoxColumn dgText = new DataGridViewTextBoxColumn();
                //      DataGridViewNumericUpDownColumn dgText = new DataGridViewTextBoxColumn();
                DataGridViewComboBoxColumn dgText = new DataGridViewComboBoxColumn();
                dgText.HeaderText = "Precio taller";
                dgText.Name = "Precio taller";
                dgText.HeaderText = "Precio taller";
                string[] porcentajes = new string[] { "10", "20", "30", "40", "50", "60", "70", "80", "90", "100", "200" };
                for (int i = 0; i < porcentajes.Length; i++)
                {
                    dgText.Items.Add(porcentajes[i]);


                }



                dataCarView.Columns.Add(dgText);
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataCarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void actualizarTaller(String codigo, String mecanico, String precioTaller)
        {
            if (precioTaller != "" && mecanico != "")
            {



                string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerTaller.php?webNoActiva=true&actualizarTaller=true&XDEBUG_SESSION_START=netbeans-xdebug";
                var codigoMecanico = mecanico.Split('\t');
                using (WebClient client = new WebClient())
                {
                    NameValueCollection postData = new NameValueCollection()
                {
                    {
                        "codigo",
                        codigo
                    },
                    {
                        "mecanico",
                        codigoMecanico[0]
                    },
                       {
                        "precioTaller",
                        precioTaller
                    },


                };

                    String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                    MessageBox.Show(resultadosWeb);
                    this.esperarValidacionRd.Checked = true;
                }
                //    var registros = JsonConvert.DeserializeObject<Mesajes>(resultadosWeb);
            }
            else
            {
                MessageBox.Show("no se puede actualizar aquellos que tienen el campo de precio y mecanico vacio:" + codigo);

            }
        }
        private void validarTaller(String codigo)
        {

            string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerTaller.php?webNoActiva=true&validar=true&XDEBUG_SESSION_START=netbeans-xdebug";
            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                    {
                        "codigo",
                        codigo
                    }


                };

                String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                MessageBox.Show(resultadosWeb);
                this.resueltasRd.Checked = true;
                //    var registros = JsonConvert.DeserializeObject<Mesajes>(resultadosWeb);
            }
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            if (filtroActual.Equals("resueltasRd") == false)
            {

                foreach (DataGridViewRow dr in dataCarView.Rows)
                {

                    if (filtroActual.Equals("SinMecanico"))
                    {
                        if (dataCarView.Columns.Contains("Mecanicos") && dr.Cells["Mecanicos"] != null)
                        {
                            if (dr.Cells["Mecanicos"].Value == null)
                            {
                                var idArticulo = dr.Cells["Coche"].Value;

                            }

                            else
                            {
                                if (dr.Cells["Precio taller"].Value != null && dr.Cells["Mecanicos"].Value != null)
                                {
                                    actualizarTaller(dr.Cells["Codigo"].Value.ToString(), dr.Cells["Mecanicos"].Value.ToString(), dr.Cells["Precio taller"].Value.ToString());
                                    this.noResuletasRd.Checked = true;
                                }
                                else
                                {
                                    MessageBox.Show("Se debe seleccionar un mecanico y un precio para la cita");
                                }

                            }
                        }

                    }
                    else if (dataCarView.Columns.Contains("Validaciones") && filtroActual.Equals("noresueltas"))
                    {
                        if (dr.Cells["Validaciones"] != null)
                        {
                            if (dr.Cells["Validaciones"].Value == null)
                            {
                                var idArticulo = dr.Cells["Coche"].Value;

                            }

                            else
                            {
                                validarTaller(dr.Cells["Codigo"].Value.ToString());
                            }
                        }
                    }

                }

            }


            /*
             foreach (DataGridViewRow row in dataGridView1.Rows)
    {
        if (Convert.ToBoolean(row.Cells[CheckBoxColumn1.Name].Value) == true)
        {
            rows_with_checked_column.Add(row);
        }
    }

             */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();
        }

        private void ComprobarTaller_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}