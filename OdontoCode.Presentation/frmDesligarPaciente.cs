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
    public partial class frmDesligarPaciente : Form
    {
        private readonly IPacienteService _pacienteService;
        Paciente paciente;
        public frmDesligarPaciente(IPacienteService _paciente)
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

            paciente = _pacienteService.ObterPaciente(busca);

            txtCpfPaciente.Text = paciente.CPF;

            txtNomePaciente.Text = paciente.Nome;

            txtTelPaciente.Text = paciente.Telefone;

            txtCepPaciente.Text = paciente.CEP;

            txtUfPaciente.Text = paciente.UF;

            txtCidadePaciente.Text = paciente.Cidade;

            txtBairroPaciente.Text = paciente.Bairro;

            txtRuaPaciente.Text = paciente.Rua;

            txtNumPaciente.Text = paciente.Numero.ToString();

        }

        private void btnAtualizarPaciente_Click(object sender, EventArgs e)
        {
            _pacienteService.ApagarPaciente(paciente);
            MessageBox.Show($"Paciente {paciente.Nome} desligado com sucesso");
        }
    }
}
