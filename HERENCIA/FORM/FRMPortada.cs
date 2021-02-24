using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORM
{
    public partial class FRMPortada : Form
    {
        public FRMPortada()
        {
            InitializeComponent();
        }

        public static void Main ()
        {
            FORM.FRMPortada INICIO = new FORM.FRMPortada();
            INICIO.ShowDialog();
        }

        private void BTNCLIENT_Click(object sender, EventArgs e)
        {
            FORM.FRMCliente CLIENTS = new FORM.FRMCliente();
            CLIENTS.Show();
        }

        private void BTNEMPLEADO_Click(object sender, EventArgs e)
        {
            FORM.FRMEmpleado EMPLEADO = new FORM.FRMEmpleado();
            EMPLEADO.Show();
        }

        private void BTNSALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
