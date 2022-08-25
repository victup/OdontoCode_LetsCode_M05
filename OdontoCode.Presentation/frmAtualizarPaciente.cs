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
                paciente.Numero = txtNumPaciente.Text;
                paciente.Rua = txtRuaPaciente.Text;
                paciente.UF = txtUfPaciente.Text;

                btnAtualizarPaciente.Visible = false;
                btnEncontrarPaciente.Visible = true;

                _pacienteService.AlterarPaciente(cpfAntigo, paciente);

                MessageBox.Show($"Paciente {paciente.Nome} atualizado com sucesso!");

                txtNomePaciente.Text = String.Empty;
                txtCpfPaciente.Text = String.Empty;
                txtTelPaciente.Text = String.Empty;
                txtBairroPaciente.Text = String.Empty;
                txtCepPaciente.Text = String.Empty;
                txtCidadePaciente.Text = String.Empty;
                txtNumPaciente.Text = String.Empty;
                txtRuaPaciente.Text = String.Empty;
                txtUfPaciente.Text = String.Empty;
            }
        }

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {
            //if ((String.IsNullOrEmpty(txtNomePaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtCpfPaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtTelPaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtBairroPaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtCepPaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtCidadePaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtNumPaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtRuaPaciente.Text)) &&
            //    (String.IsNullOrEmpty(txtUfPaciente.Text))
            //    )
            //{
            //    lblValidaEntradas.Visible = true;
            //    lblValidaEntradas.Text = "Pelo menos um campo deve ser preenchido";
            //    lblValidaEntradas.ForeColor = Color.Red;
            //}
            //else
            //{
                string busca = "";

                if (!String.IsNullOrEmpty(txtTelPaciente.Text))
                    busca = txtTelPaciente.Text;
                else if (!String.IsNullOrEmpty(txtCpfPaciente.Text))
                    busca = txtCpfPaciente.Text;
                else
                    busca = txtNomePaciente.Text;

                paciente = _pacienteService.ObterPaciente(busca);

                if (paciente.CPF != null)
                {
                    btnEncontrarPaciente.Visible = false;
                    btnAtualizarPaciente.Visible = true;
                    lblTelPaciente.Visible = true;
                    txtTelPaciente.Visible = true;
                    lblBairroPaciente.Visible = true;
                    txtBairroPaciente.Visible = true;
                    lblCepPaciente.Visible = true;
                    txtCepPaciente.Visible = true;
                    lblUfPaciente.Visible = true;
                    txtUfPaciente.Visible = true;
                    lblCidadePaciente.Visible = true;
                    txtCidadePaciente.Visible = true;
                    lblRuaPaciente.Visible = true;
                    txtRuaPaciente.Visible = true;
                    lblNumPaciente.Visible = true;
                    txtNumPaciente.Visible = true;

                    txtNomePaciente.Text = paciente.Nome;
                    txtCpfPaciente.Text = paciente.CPF;
                    txtTelPaciente.Text = paciente.Telefone;
                    txtBairroPaciente.Text = paciente.Bairro;
                    txtCepPaciente.Text = paciente.CEP;
                    txtCidadePaciente.Text = paciente.Cidade;
                    txtNumPaciente.Text = paciente.Numero.ToString();
                    txtRuaPaciente.Text = paciente.Rua;
                    txtUfPaciente.Text = paciente.UF;
                }
                else
                {
                    MessageBox.Show($"Não encontramos nenhum dentista com os valores fornecidos.");
                    btnEncontrarPaciente.Visible = true;

                }

            }
        }
    }
}
