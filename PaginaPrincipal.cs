using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Scripting.Hosting;
//using Microsoft.Scripting;
using System.Windows.Forms;
//using IronPython.Hosting;
//dynamic language runtime
//iron python
namespace concesionarioApp
{
    public partial class PaginaPrincipal : Form
    {

        public PaginaPrincipal()
        {
            InitializeComponent();
            /*
            label1.Text = Strings.nombre+":"+Login.user.codigo+"";
            label2.Text = Strings.nombre + ":" + Login.user.nombre + "";
            label3.Text = Strings.apellidos + ":" + Login.user.apellidos + "";
            label4.Text = Strings.email + ":" + Login.user.email + "";
            label5.Text = Strings.telefono + ":" + Login.user.telefono + "";*/
            anadirCoche.Text = Strings.anadirCoche;
            tallerCoches.Text = Strings.agregarModelos;
            comprobarCoches.Text = Strings.comprobarCoches;
            //   alquilerCoches.Text = Strings.alquilerCoches;
            // ventasCoche.Text = Strings.ventasCoche;

            DataTable dTabla = new DataTable("tabCoches");
            infoUserGrid.DataSource = Login.user.infoEmpleado();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            crearUsuario.Enabled = false;
            if (Login.user.puesto.ToUpper().Equals("JEFE") || Login.user.puesto.ToUpper().Equals("ADMINISTRADOR"))
            {
                crearUsuario.Enabled = true;
            }
            crearUsuario.Enabled = true;


        }

        private void comprobarCoches_Click(object sender, EventArgs e)
        {
            VistaCoches form3 = new VistaCoches();
            this.Hide();
            form3.Show();
        }

        private void anadirCoche_Click(object sender, EventArgs e)
        {
            NuevosCoches nuevos = new NuevosCoches();
            this.Hide();
            nuevos.Show();
        }

        private void tallerCoches_Click(object sender, EventArgs e)
        {
            AgregarModelos nuevoModelos = new AgregarModelos();
            nuevoModelos.Show();
            this.Hide();
        }

        private void tallerBtn_Click(object sender, EventArgs e)
        {
            ComprobarTaller taller = new ComprobarTaller();
            this.Hide();
            taller.Show();
        }

        private void chatbtn_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.Show();
            this.Hide();
        }

        private void crearUsuario_Click(object sender, EventArgs e)
        {
            RegistrarEmpleados registar = new RegistrarEmpleados();
            registar.Show();
            this.Hide();
        }

        private void PaginaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Grafica graficas = new Grafica(registros);
            //graficas.ShowDialog();
            // String path = @"c:\Users\graficas.py";

            //var engine = Python.CreateEngine();
            //dynamic pyProgram = pyRunTime.UseFile(path);
            //pyProgram.Grafica();

        }
    }
}
//ScriptRuntime pyRunTime = Python.CreateRuntime();