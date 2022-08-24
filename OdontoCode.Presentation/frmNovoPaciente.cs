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
        Paciente paciente;
        public frmNovoPaciente(IPacienteService _paciente)
        {
            InitializeComponent();
            _pacienteService = _paciente;
        }

        private void btnCadastrarPaciente_Click(object sender, EventArgs e)
        {
             _pacienteService.RegistrarNovoPaciente(paciente);
            MessageBox.Show($"Paciente {paciente.Nome} cadastrado com sucesso");
        }
    }
}
