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
    public partial class frmAtualizarPaciente : Form
    {
        private readonly IPacienteService _pacienteService;
        Paciente paciente;
        public frmAtualizarPaciente(IPacienteService pacienteService)
        {
            InitializeComponent();
            _pacienteService = pacienteService;
        }

        private void btnAtualizarPaciente_Click(object sender, EventArgs e)
        {
            if (paciente != null)
            {
                string cpfAntigo = paciente.CPF;

                paciente.Nome = txtNomePaciente.Text;
                paciente.CPF = txtCpfPaciente.Text;
                paciente.Telefone = txtTelPaciente.Text;
                paciente.Bairro = txtBairroPaciente.Text;
                paciente.CEP = txtCepPaciente.Text;
                paciente.Cidade = txtCidadePaciente.Text;
                paciente.Numero = int.Parse(txtNumPaciente.Text);
                paciente.Rua = txtRuaPaciente.Text;
                paciente.UF = txtUfPaciente.Text;

                btnAtualizarPaciente.Visible = false;
                btnEncontrarPaciente.Visible = true;

                _pacienteService.AlterarPaciente(cpfAntigo, paciente);

                MessageBox.Show($"Paciente {paciente.Nome} atualizado com sucesso!");

                txtCpfPaciente.Text = String.Empty;

                txtNomePaciente.Text = String.Empty;

                txtTelPaciente.Text = String.Empty;
                txtTelPaciente.Visible = false;
                lblTelPaciente.Visible = false;

                txtCepPaciente.Text = String.Empty;
                txtCepPaciente.Visible = false;
                lblCepPaciente.Visible = false;

                txtUfPaciente.Text = String.Empty;
                txtUfPaciente.Visible = false;
                lblUfPaciente.Visible = false;

                txtCidadePaciente.Text = String.Empty;
                txtCidadePaciente.Visible = false;
                lblCidadePaciente.Visible = false;

                txtBairroPaciente.Text = String.Empty;
                txtBairroPaciente.Visible = false;
                lblBairroPaciente.Visible = false;

                txtRuaPaciente.Text = String.Empty;
                txtRuaPaciente.Visible = false;
                lblRuaPaciente.Visible = false;

                txtNumPaciente.Text = String.Empty;
                txtNumPaciente.Visible = false;
                lblNumPaciente.Visible = false;
            }
        }

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNomePaciente.Text) ||
                !String.IsNullOrEmpty(txtCpfPaciente.Text)
               )
            {
                lblaviso.Visible = false;

                string busca = "";

                if (!String.IsNullOrEmpty(txtCpfPaciente.Text))
                    busca = txtCpfPaciente.Text;
                else
                    busca = txtNomePaciente.Text;

                paciente = _pacienteService.ObterPaciente(busca);

                if (paciente.CPF != null)
                {
                    txtCpfPaciente.Text = paciente.CPF;
                    txtCpfPaciente.Visible = true;
                    lblCpfPaciente.Visible = true;

                    txtNomePaciente.Text = paciente.Nome;
                    txtNomePaciente.Visible = true;
                    lblNomePaciente.Visible = true;

                    txtTelPaciente.Text = paciente.Telefone;
                    txtTelPaciente.Visible = true;
                    lblTelPaciente.Visible = true;

                    txtCepPaciente.Text = paciente.CEP;
                    txtCepPaciente.Visible = true;
                    lblCepPaciente.Visible = true;

                    txtUfPaciente.Text = paciente.UF;
                    txtUfPaciente.Visible = true;
                    lblUfPaciente.Visible = true;

                    txtCidadePaciente.Text = paciente.Cidade;
                    txtCidadePaciente.Visible = true;
                    lblCidadePaciente.Visible = true;

                    txtBairroPaciente.Text = paciente.Bairro;
                    txtBairroPaciente.Visible = true;
                    lblBairroPaciente.Visible = true;

                    txtRuaPaciente.Text = paciente.Rua;
                    txtRuaPaciente.Visible = true;
                    lblRuaPaciente.Visible = true;

                    txtNumPaciente.Text = paciente.Numero.ToString();
                    txtNumPaciente.Visible = true;
                    lblNumPaciente.Visible = true;
                    btnAtualizarPaciente.Visible = true;

                }
                else
                    MessageBox.Show($"Não encontramos nenhum paciente com os valores fornecidos.");
            }
            else
            {
                lblaviso.Visible = true;
                lblaviso.Text = $"Espera-se pelo menos um campo preenchido para realizar a busca.";
                lblaviso.ForeColor = Color.Red;
            }
        }
    }
}
