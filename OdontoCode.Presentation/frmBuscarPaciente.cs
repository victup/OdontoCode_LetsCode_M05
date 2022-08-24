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
    public partial class frmBuscarPaciente : Form
    {
        private readonly IPacienteService _pacienteService;

        public frmBuscarPaciente(IPacienteService _paciente)
        {
            InitializeComponent();
            _pacienteService = _paciente;
        }

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {
            string busca = "";
            if (!String.IsNullOrEmpty(txtCpfPaciente.Text))
                busca = txtCpfPaciente.Text;
            else
                busca = txtNomePaciente.Text;
            
            Paciente paciente = _pacienteService.ObterPaciente(busca);

            txtCpfPaciente.Text = paciente.CPF;
            txtCpfPaciente.Enabled = false;

            txtNomePaciente.Text = paciente.Nome;
            txtNomePaciente.Enabled = false;

            txtTelPaciente.Text = paciente.Telefone;
            txtTelPaciente.Enabled = false;

            txtCepPaciente.Text = paciente.CEP;
            txtCepPaciente.Enabled = false;

            txtUfPaciente.Text = paciente.UF;
            txtUfPaciente.Enabled = false;

            txtCidadePaciente.Text = paciente.Cidade;
            txtCidadePaciente.Enabled = false;

            txtBairroPaciente.Text = paciente.Bairro;
            txtBairroPaciente.Enabled = false;

            txtRuaPaciente.Text = paciente.Rua;
            txtRuaPaciente.Enabled = false;

            txtNumPaciente.Text = paciente.Numero.ToString();
            txtNumPaciente.Enabled = false;
        }
    }
}
