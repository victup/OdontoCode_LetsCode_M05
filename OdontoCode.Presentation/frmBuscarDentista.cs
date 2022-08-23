using OdontoCode.Domain;
using OdontoCode.Services;
using OdontoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdontoCode.Presentation
{
    public partial class frmBuscarDentista : Form
    {

        private readonly IDentistaService _dentistService;
        public frmBuscarDentista(IDentistaService _dentists)
        {
            InitializeComponent();
          
            _dentistService = _dentists;


        }
  

        private void btnEncontrarDentista_Click(object sender, EventArgs e)
        {
            btnEncontrarDentista.Visible = false;
            btnLimparDentista.Visible = true;

            string busca = "";

            if (!String.IsNullOrEmpty(txtCroBuscarDentista.Text))
                busca = txtCroBuscarDentista.Text;
            else
                busca = txtNomeBuscarDentista.Text;

           

            Dentista dentist = _dentistService.GetDentist(busca);

            txtCroBuscarDentista.Text = dentist.CRO;
            txtCroBuscarDentista.Enabled = false;

            txtNomeBuscarDentista.Text = dentist.Nome;
            txtNomeBuscarDentista.Enabled = false;

            txtTelefoneBuscarDentista.Text = dentist.Telefone;
            txtTelefoneBuscarDentista.Enabled = false;

        }

        private void btnLimparDentista_Click(object sender, EventArgs e)
        {
            btnLimparDentista.Visible = false;
            btnEncontrarDentista.Visible = true;

            txtNomeBuscarDentista.Text = String.Empty;
            txtCroBuscarDentista.Text = String.Empty;
            txtTelefoneBuscarDentista.Text = String.Empty;

            txtTelefoneBuscarDentista.Enabled = true;
            txtNomeBuscarDentista.Enabled = true;
            txtCroBuscarDentista.Enabled = true;
            
        }
    }
}
