using OdontoCode.Domain;
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
    public partial class frmDesligarDentista : Form
    {
        private readonly IDentistaService _dentistService;

        Dentista dentist;
        public frmDesligarDentista(IDentistaService _dentists)
        {
            InitializeComponent();

            _dentistService = _dentists;

        }

        private void btnEncontrarDentista_Click(object sender, EventArgs e)
        {
            string busca = "";

            if (!String.IsNullOrEmpty(txtCroDesligarDentista.Text))
                busca = txtCroDesligarDentista.Text;
            else
                busca = txtNomeDesligarDentista.Text;



            dentist = _dentistService.GetDentist(busca);

            txtCroDesligarDentista.Text = dentist.CRO;
            txtNomeDesligarDentista.Text = dentist.Nome;
            txtTelefoneDesligarDentista.Text = dentist.Telefone;

            btnDesligarDentista.Visible = true;
        }

        private void btnDesligarDentista_Click(object sender, EventArgs e)
        {
            _dentistService.DeleteDentist(dentist);
            MessageBox.Show($"Dentista {dentist.Nome} desligado com sucesso");

            txtCroDesligarDentista.Text = String.Empty;
            txtNomeDesligarDentista.Text = String.Empty;
            txtTelefoneDesligarDentista.Text = String.Empty;

       
        }
    }
}
