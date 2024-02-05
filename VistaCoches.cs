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



    public partial class VistaCoches : Form
    {
        public List<Coches> registros;
        public static Coches coches;
        public static string filtroActual;
        public VistaCoches()
        {
            InitializeComponent();
            validarVentaBtn.Enabled = false;
            validarVentaBtn.Visible = false;
            this.TodosRadioButton.Text = Strings.TodosRadioButton;
            this.VentasRadioButton.Text = Strings.VentasRadioButton;
            this.AlquilerRadioButton.Text = Strings.AlquilerRadioButton;
            this.TallerRadioButton.Text = Strings.TallerRadioButton;
            this.TodosRadioButton.Checked = true;
            //this.NuevosButton.Text = Strings.NuevosButton;
            this.TodosRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.VentasRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.AlquilerRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.TallerRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            this.VentasPendientesRadioButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);
            //this.NuevosButton.CheckedChanged += new EventHandler(radioButton_CheckedChanged);


        }

        DataTable dtable;
        private void Form3_Load(object sender, EventArgs e)
        {

            tablaCoche("");


        }

        /*
         
         
         */
        private void tablaCoche(String filtro)
        {
            filtroActual = filtro;
            this.dataCarView.Columns.Clear();
            dtable = new DataTable();
            var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&mostrarCoches=true" + filtro + "&XDEBUG_SESSION_START=netbeans-xdebug");
            try
            {
                registros = JsonConvert.DeserializeObject<List<Coches>>(output);
                var a = registros;
                if (registros != null && registros.Count >= 1)
                {
                    /*
        for (int i = 0; i < registros.Count; i++) {
            listBox1.Items.Add(registros[i].infoCoche());
        }*/
                    //dtable.Columns.Add("Eliminar", typeof(DataGridViewButtonColumn));
                    dtable.Columns.Add(Strings.matricula, typeof(string));
                    dtable.Columns.Add(Strings.modelo, typeof(string));
                    dtable.Columns.Add(Strings.propietario, typeof(string));
                    dtable.Columns.Add(Strings.precioCompra, typeof(string));
                    dtable.Columns.Add(Strings.precioAlquiler, typeof(string));
                    dtable.Columns.Add(Strings.marca, typeof(string));
                    dtable.Columns.Add(Strings.estado, typeof(string));
                    dtable.Columns.Add(Strings.enVenta, typeof(string));
                    dtable.Columns.Add(Strings.enTaller, typeof(string));
                    dtable.Columns.Add(Strings.enAlquiler, typeof(string));
                    dtable.Columns.Add(Strings.color, typeof(string));
                    dtable.Columns.Add(Strings.imagenes, typeof(string));
                    dtable.Columns.Add(Strings.descripcion, typeof(string));


                    /*
                     
                    eliminar[i] = new DataGridViewButtonColumn();
                    eliminar[i].DefaultCellStyle.Font = new Font("Arial", 1);
                    eliminar[i].Name = registros[i].matricula;
                    eliminar[i].HeaderText = Strings.eliminar;
                    eliminar[i].Text = registros[i].matricula;
                    eliminar[i].UseColumnTextForButtonValue = true;

                   

                     
                     */


                    //    DataGridViewRow row =new DataGridViewRow[registros.Count + 1];
                    // DataGridViewButtonColumn[] eliminar = new DataGridViewButtonColumn[registros.Count + 1];

                    int columnIndex = 0;

                    for (int i = 0; i < registros.Count; i++)
                    {
                        columnIndex = 0;
                        if (dataCarView.Columns["eliminar"] == null)
                        {
                            //        dataCarView.Columns.Insert(columnIndex, eliminar[i]);
                        }
                        dtable.Rows.Add(registros[i].matricula, registros[i].modelo, registros[i].propietario, registros[i].precioCompra, registros[i].precioAlquiler,
                            registros[i].marca, registros[i].estado, registros[i].enVenta.Equals("1") ? "Si" : "No", registros[i].enTaller.Equals("1") ? "Si" : "No", registros[i].enAlquiler.Equals("1") ? "Si" : "No", registros[i].color, registros[i].imagenes, registros[i].descripcion);
                    }
                    DataGridViewButtonColumn eliminar = new DataGridViewButtonColumn();
                    if (dataCarView.Columns["eliminar"] == null && filtro != "&filtro=esperandoVenta")
                    {
                        dataCarView.Columns.Insert(columnIndex, eliminar);
                    }
                    DataGridViewButtonColumn editar = new DataGridViewButtonColumn();
                    if (dataCarView.Columns["editar"] == null && filtro != "&filtro=esperandoVenta")
                    {
                        dataCarView.Columns.Insert(columnIndex, editar);
                    }
                    if (filtroActual != "&filtro=esperandoVenta")
                    {
                        dataCarView.CellClick += new DataGridViewCellEventHandler(EliminarCocheButton_Click);
                    }
                }

            }
            catch (Exception e)
            {

            }
            if (filtro == "&filtro=esperandoVenta")
            {
                cmbPorcentajes();
            }
            dataCarView.DataSource = dtable;


        }

        private void dataCarView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (filtroActual != "&filtro=esperandoVenta")
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 0)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = 20;
                    var h = 20;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Resource1.papelera, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
                if (e.ColumnIndex == 1)
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    var w = 20;
                    var h = 20;
                    var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                    var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                    e.Graphics.DrawImage(Resource1.lapiz, new Rectangle(x, y, w, h));
                    e.Handled = true;
                }
            }
        }


        private void EliminarCocheButton_Click(object sender, DataGridViewCellEventArgs e)
        {

            if (filtroActual != "&filtro=esperandoVenta")
            {
                if (e.ColumnIndex == 0 && e.RowIndex >= 0)
                {
                    var matriculaValue = dtable.Rows[e.RowIndex][e.ColumnIndex].ToString();
                    var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&eliminarCoches=true&matricula=" + matriculaValue + "&XDEBUG_SESSION_START=netbeans-xdebug");

                    dataCarView.Columns.Clear();
                    dataCarView.Refresh();
                    this.TodosRadioButton.Checked = true;
                }
                else if (e.ColumnIndex == 1 && e.RowIndex >= 0)
                {
                    var matriculaValue = dtable.Rows[e.RowIndex][e.ColumnIndex - 1].ToString();
                    ActualizarCoche actualizar = new ActualizarCoche(matriculaValue);
                    actualizar.Show();
                    this.Hide();
                    /*
                    var output = BaseDeDatos.inforPhp("http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&buscarCoches&matricula=" + matriculaValue + "&XDEBUG_SESSION_START=netbeans-xdebug");

                    dataCarView.Columns.Clear();
                    dataCarView.Refresh();
                    tablaCoche("");*/
                }
            }

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            PaginaPrincipal pgPr = new PaginaPrincipal();
            this.Hide();
            pgPr.Show();
        }

        private void VistaCoches_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void cmbPorcentajes()
        {


            if (registros != null)
            {

                DataGridViewComboBoxColumn dgvCmb = new DataGridViewComboBoxColumn();
                dgvCmb.HeaderText = "Se Compra por";
                dgvCmb.Name = "Se Compra por";
                dgvCmb.HeaderText = "Se Compra por";
                string[] porcentajes = new string[] { "30", "40", "50", "60", "70" };
                for (int i = 0; i < porcentajes.Length; i++)
                {
                    dgvCmb.Items.Add(porcentajes[i]);

                }
                dataCarView.Columns.Add(dgvCmb);
            }


        }


        void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            generarGrafica.Enabled = false;
            validarVentaBtn.Enabled = false;
            validarVentaBtn.Visible = false;
            generarGrafica.Visible = false;

            if (rb.Checked == true)
            {
                if (rb.Name.Equals("TodosRadioButton"))
                {
                    generarGrafica.Enabled = true;
                    generarGrafica.Visible = true;

                    tablaCoche("");
                    return;
                }
                else if (rb.Name.Equals("VentasRadioButton"))
                {
                    tablaCoche("&filtro=enVenta");
                    return;
                }
                else if (rb.Name.Equals("VentasPendientesRadioButton"))
                {
                    validarVentaBtn.Enabled = true;
                    validarVentaBtn.Visible = true;
                    tablaCoche("&filtro=esperandoVenta");
                    return;
                }
                else if (rb.Name.Equals("AlquilerRadioButton"))
                {
                    tablaCoche("&filtro=enAlquiler");

                    return;
                }
                else if (rb.Name.Equals("TallerRadioButton"))
                {
                    tablaCoche("&filtro=enTaller");
                    return;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataCarView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void generarGrafica_Click(object sender, EventArgs e)
        {
            Grafica graficas = new Grafica(registros, "");
            graficas.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataCarView.Rows)
            {


                if (dataCarView.Columns.Contains("Se Compra por")
                     && dataCarView.Columns.Contains(Strings.propietario) && dataCarView.Columns.Contains(Strings.matricula))
                {
                    actualizarCompra(dr.Cells[Strings.matricula].Value.ToString(),
                dr.Cells[Strings.precioCompra].Value.ToString()
                , dr.Cells["Se Compra por"].Value.ToString(), dr.Cells[Strings.propietario].Value.ToString());

                }

            }
        }
        private void actualizarCompra(String matricula, String precioCompra, String porcentaje, String propietario)
        {

            string urlAddress = "http://localhost/ProyectoCoches/controllers/controllerCoches.php?webNoActiva=true&venderCoche=true&XDEBUG_SESSION_START=netbeans-xdebug";
            double precio = Convert.ToDouble(precioCompra) * (Convert.ToDouble(porcentaje) / 100);
            string[] propietarioString = propietario.Split(' ');

            using (WebClient client = new WebClient())
            {
                NameValueCollection postData = new NameValueCollection()
                {
                    {
                        "matriculaCoche",
                        matricula
                    },
                    {
                        "propietario",
                        propietarioString[0]
                    },
                    {
                        "rembolsado",
                        precio.ToString()
                    },


                };

                String resultadosWeb = Encoding.UTF8.GetString(client.UploadValues(urlAddress, postData));
                MessageBox.Show(resultadosWeb);
                this.TodosRadioButton.Checked = true;

                //    var registros = JsonConvert.DeserializeObject<Mesajes>(resultadosWeb);
            }
        }
    }
}