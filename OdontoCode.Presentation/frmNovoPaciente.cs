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
    public partial class frmNovoPaciente : Form
    {
        private readonly IPacienteService _pacienteService;
        public frmNovoPaciente(IPacienteService _paciente)
        {
            InitializeComponent();
            _pacienteService = _paciente;
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtNomePaciente.Text) &&
               !String.IsNullOrEmpty(txtCpfPaciente.Text) &&
               !String.IsNullOrEmpty(txtTelPaciente.Text) &&
               !String.IsNullOrEmpty(txtCepPaciente.Text) &&
               !String.IsNullOrEmpty(txtUfPaciente.Text) &&
               !String.IsNullOrEmpty(txtCidadePaciente.Text) &&
               !String.IsNullOrEmpty(txtBairroPaciente.Text) &&
               !String.IsNullOrEmpty(txtRuaPaciente.Text) &&
               !String.IsNullOrEmpty(txtRuaPaciente.Text)
               )
                {
                    _pacienteService.RegistrarNovoPaciente(new Paciente(_pacienteService.GerarId(), txtNomePaciente.Text, txtCpfPaciente.Text, txtTelPaciente.Text, txtCepPaciente.Text, txtUfPaciente.Text, txtCidadePaciente.Text, txtBairroPaciente.Text, txtRuaPaciente.Text, int.Parse(txtNumPaciente.Text), true));
                    MessageBox.Show($"Paciente {txtNomePaciente.Text} cadastrado com sucesso");
                }
             else
            {
                MessageBox.Show($"Existem campos em branco, todos devem ser preenchidos.", "Parâmetros faltantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
                
           
        }
    }
}
