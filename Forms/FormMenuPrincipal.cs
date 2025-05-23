using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestigadorAI_Final.Forms
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            this.Text = "Menú Principal - InvestigadorAI";

            this.Controls.Add(btnInvestigar);
            this.Controls.Add(btnVerRegistros);
        }
        private void btnInvestigar_Click(object sender, EventArgs e)
        {
            var formInvestigacion = new Form1();
            formInvestigacion.Show();
        }

        private void btnVerRegistros_Click(object sender, EventArgs e)
        {
            var formRegistros = new FormRegistrosBD();
            formRegistros.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
