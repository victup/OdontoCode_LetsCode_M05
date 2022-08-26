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
            if (!String.IsNullOrEmpty(txtNomePaciente.Text) ||
                !String.IsNullOrEmpty(txtCpfPaciente.Text) ||
                !String.IsNullOrEmpty(txtTelPaciente.Text) ||
                !String.IsNullOrEmpty(txtCepPaciente.Text) ||
                !String.IsNullOrEmpty(txtUfPaciente.Text) ||
                !String.IsNullOrEmpty(txtCidadePaciente.Text) ||
                !String.IsNullOrEmpty(txtBairroPaciente.Text) ||
                !String.IsNullOrEmpty(txtRuaPaciente.Text) ||
                !String.IsNullOrEmpty(txtNumPaciente.Text)
                 )
            {
                lblaviso.Visible = false;

                string busca = "";

                if (!String.IsNullOrEmpty(txtCpfPaciente.Text))
                    busca = txtCpfPaciente.Text;
                else
                    busca = txtNomePaciente.Text;

                Paciente paciente = _pacienteService.ObterPaciente(busca);

                if (paciente.CPF != null)
                {
                    txtCpfPaciente.Text = paciente.CPF;
                    txtCpfPaciente.Enabled = false;
                    txtCpfPaciente.Visible = true;
                    lblCpfPaciente.Visible = true;

                    txtNomePaciente.Text = paciente.Nome;
                    txtNomePaciente.Enabled = false;
                    txtNomePaciente.Visible = true;
                    lblNomePaciente.Visible = true;

                    txtTelPaciente.Text = paciente.Telefone;
                    txtTelPaciente.Enabled = false;
                    txtTelPaciente.Visible = true;
                    lblTelPaciente.Visible = true;

                    txtCepPaciente.Text = paciente.CEP;
                    txtCepPaciente.Enabled = false;
                    txtCepPaciente.Visible = true;
                    lblCepPaciente.Visible = true;

                    txtUfPaciente.Text = paciente.UF;
                    txtUfPaciente.Enabled = false;
                    txtUfPaciente.Visible = true;
                    lblUfPaciente.Visible = true;

                    txtCidadePaciente.Text = paciente.Cidade;
                    txtCidadePaciente.Enabled = false;
                    txtCidadePaciente.Visible = true;
                    lblCidadePaciente.Visible = true;

                    txtBairroPaciente.Text = paciente.Bairro;
                    txtBairroPaciente.Enabled = false;
                    txtBairroPaciente.Visible = true;
                    lblBairroPaciente.Visible = true;

                    txtRuaPaciente.Text = paciente.Rua;
                    txtRuaPaciente.Enabled = false;
                    txtRuaPaciente.Visible = true;
                    lblRuaPaciente.Visible = true;

                    txtNumPaciente.Text = paciente.Numero.ToString();
                    txtNumPaciente.Enabled = false;
                    txtNumPaciente.Visible = true;
                    lblNumPaciente.Visible = true;

                    btnLimparPaciente.Visible = true;
                    btnEncontrarPaciente.Visible = false;
                }
                else
                {
                    MessageBox.Show($"Não encontramos nenhum paciente com os valores fornecidos.");
                    btnEncontrarPaciente.Visible = true;
                    btnLimparPaciente.Visible = false;
                }

            }
            else
            {
                lblaviso.Visible = true;
                lblaviso.Text = $"Espera-se pelo menos um campo preenchido para realizar a busca.";
                lblaviso.ForeColor = Color.Red;
            }
    }

        private void btnLimparPaciente_Click(object sender, EventArgs e)
        {
            btnLimparPaciente.Visible = false;
            btnEncontrarPaciente.Visible = true;

            txtCpfPaciente.Text = String.Empty;
            txtCpfPaciente.Enabled = true;


            txtNomePaciente.Text = String.Empty;
            txtNomePaciente.Enabled = true;


            txtTelPaciente.Text = String.Empty;
            txtTelPaciente.Enabled = true;
            txtTelPaciente.Visible = false;
            lblTelPaciente.Visible = false;

            txtCepPaciente.Text = String.Empty;
            txtCepPaciente.Enabled = true;
            txtCepPaciente.Visible = false;
            lblCepPaciente.Visible = false;

            txtUfPaciente.Text = String.Empty;
            txtUfPaciente.Enabled = true;
            txtUfPaciente.Visible = false;
            lblUfPaciente.Visible = false;

            txtCidadePaciente.Text = String.Empty;
            txtCidadePaciente.Enabled = true;
            txtCidadePaciente.Visible = false;
            lblCidadePaciente.Visible = false;

            txtBairroPaciente.Text = String.Empty;
            txtBairroPaciente.Enabled = true;
            txtBairroPaciente.Visible = false;
            lblBairroPaciente.Visible = false;

            txtRuaPaciente.Text = String.Empty;
            txtRuaPaciente.Enabled = true;
            txtRuaPaciente.Visible = false;
            lblRuaPaciente.Visible = false;

            txtNumPaciente.Text = String.Empty;
            txtNumPaciente.Enabled = true;
            txtNumPaciente.Visible = false;
            lblNumPaciente.Visible = false;
        }
    }
}
