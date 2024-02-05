using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concesionarioApp
{
    public partial class DatosTaller : Form
    {
        private Form logicalParent;
        private bool seConfirma;
        public DatosTaller(Form parent)
        {
            InitializeComponent();
            logicalParent = parent;
            seConfirma = false;
            inputCita.MinDate = DateTime.Now.AddDays(2);
            inputCita.MaxDate = DateTime.Now.AddYears(1);
        }

        private bool validarFormulario()
        {
            bool valido = true;
            if (inputMotivo.Text.Length <= 1)
            {
                valido = false;
            }
            if (inputPrecio.Text.Length <= 1)
            {
                valido = false;
            }

            if (inputCita.Value == null)
            {
                valido = false;
            }
            return valido;
        }
        private void inputPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        public List<string> getData()
        {
            List<string> datosTaller = new List<string>();
            if (validarFormulario())
            {
                datosTaller.Add(inputMotivo.Text);
                datosTaller.Add(inputPrecio.Text);
                datosTaller.Add(inputCita.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            return datosTaller;
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                seConfirma = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(Strings.erroresFormulario);
            }
        }

        private void DatosTaller_Load(object sender, EventArgs e)
        {

        }

        private void DatosTaller_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (seConfirma == false)
            {
                inputMotivo.Text = "";
                inputPrecio.Text = "";
            }

        }
    }
}