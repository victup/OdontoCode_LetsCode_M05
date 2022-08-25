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
    public partial class frmMenu : Form
    {
        private readonly IDentistaService _dentistService;
        private readonly IPacienteService _pacienteService;
        public frmMenu(IDentistaService _dentists, IPacienteService _paciente)
        {
            InitializeComponent();

            _dentistService = _dentists;
            _pacienteService = _paciente;
        }

        private void menuDentistaBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarDentista frmBuscar = new frmBuscarDentista(_dentistService);
            frmBuscar.ShowDialog();
            this.Show();
        }

        private void menuDentistaDesligar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesligarDentista frmDesligar = new frmDesligarDentista(_dentistService);
            frmDesligar.ShowDialog();
            this.Show();
        }

        private void menuDetistaNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNovoDentista frmNovo = new frmNovoDentista(_dentistService);
            frmNovo.ShowDialog();
            this.Show();

        }

        private void menuDentistaAtualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAtualizarDentista frmAtualizar = new frmAtualizarDentista(_dentistService);
            frmAtualizar.ShowDialog();
            this.Show();
        }

        private void menuSobre_Click(object sender, EventArgs e)
        {
            frmSobreSistema frmSobre = new frmSobreSistema();
            frmSobre.ShowDialog();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado =  MessageBox.Show("Tem certeza que deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
                this.Close();

        }

        private void menuPacienteNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNovoPaciente frmNovo = new frmNovoPaciente(_pacienteService);
            frmNovo.ShowDialog();
            this.Show();
        }

        private void menuPacienteAtualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAtualizarPaciente frmAtualizar = new frmAtualizarPaciente(_pacienteService);
            frmAtualizar.ShowDialog();
            this.Show();
        }

        private void menuPacienteBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarPaciente frmBuscar = new frmBuscarPaciente(_pacienteService);
            frmBuscar.ShowDialog();
            this.Show();
        }

        private void menuPacienteDesligar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesligarPaciente frmDesligar = new frmDesligarPaciente(_pacienteService);
            frmDesligar.ShowDialog();
            this.Show();
        }
    }
}
