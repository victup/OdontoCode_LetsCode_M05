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

        Dentista dentista;
        public frmDesligarDentista(IDentistaService dentistaService)
        {
            InitializeComponent();

            _dentistService = dentistaService;

        }

        private void btnEncontrarDentista_Click(object sender, EventArgs e)
        {
            string busca = "";

            if (!String.IsNullOrEmpty(txtCroDentistaDesligar.Text))
                busca = txtCroDentistaDesligar.Text;
            else
            if (!String.IsNullOrEmpty(txtDentistaCpfDesligar.Text))
                busca = txtDentistaCpfDesligar.Text;
            else
                busca = txtNomeDesligarDentista.Text;



            dentista = _dentistService.BuscarDentista(busca);

            txtCroDentistaDesligar.Text = dentista.CRO;
            txtNomeDesligarDentista.Text = dentista.Nome;
            txtTelefoneDesligarDentista.Text = dentista.Telefone;
            txtDentistaCpfDesligar.Text = dentista.CPF;

            btnDesligarDentista.Visible = true;
        }

        private void btnDesligarDentista_Click(object sender, EventArgs e)
        {
            _dentistService.DesligarDentista(dentista);
            MessageBox.Show($"Dentista {dentista.Nome} desligado com sucesso");

            txtCroDentistaDesligar.Text = String.Empty;
            txtNomeDesligarDentista.Text = String.Empty;
            txtTelefoneDesligarDentista.Text = String.Empty;

       
        }
    }
}
