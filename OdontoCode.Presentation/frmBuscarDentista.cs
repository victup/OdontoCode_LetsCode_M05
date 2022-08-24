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
        public frmBuscarDentista(IDentistaService dentistaService)
        {
            InitializeComponent();
          
            _dentistService = dentistaService;


        }
  

        private void btnEncontrarDentista_Click(object sender, EventArgs e)
        {
            btnEncontrarDentista.Visible = false;
            btnLimparDentista.Visible = true;

            string busca = "";

            if (!String.IsNullOrEmpty(txtCroDentistaBuscar.Text))
                busca = txtCroDentistaBuscar.Text;
            else
            if (!String.IsNullOrEmpty(txtDentistaCpfBuscar.Text))
                busca = txtDentistaCpfBuscar.Text;
            else
                busca = txtNomeBuscarDentista.Text;

           

            Dentista dentist = _dentistService.BuscarDentista(busca);

            txtCroDentistaBuscar.Text = dentist.CRO;
            txtCroDentistaBuscar.Enabled = false;

            txtNomeBuscarDentista.Text = dentist.Nome;
            txtNomeBuscarDentista.Enabled = false;

            txtTelefoneBuscarDentista.Text = dentist.Telefone;
            txtTelefoneBuscarDentista.Enabled = false;

            txtDentistaCpfBuscar.Text = dentist.CPF;
            txtDentistaCpfBuscar.Enabled = false;

        }

        private void btnLimparDentista_Click(object sender, EventArgs e)
        {
            btnLimparDentista.Visible = false;
            btnEncontrarDentista.Visible = true;

            txtNomeBuscarDentista.Text = String.Empty;
            txtCroDentistaBuscar.Text = String.Empty;
            txtTelefoneBuscarDentista.Text = String.Empty;
            txtDentistaCpfBuscar.Text = String.Empty ;
            
            txtDentistaCpfBuscar.Enabled = true;
            txtTelefoneBuscarDentista.Enabled = true;
            txtNomeBuscarDentista.Enabled = true;
            txtCroDentistaBuscar.Enabled = true;
            
        }
    }
}
