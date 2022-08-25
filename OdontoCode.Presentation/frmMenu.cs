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
        private readonly IAgendamentoService _agendamentoService;
        public frmMenu(IDentistaService _dentists, IAgendamentoService agendamentoService)
        {
            InitializeComponent();

            _dentistService = _dentists;
            _agendamentoService = agendamentoService;
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

        private void opcNovoAgendamento_Click(object sender, EventArgs e)
        {

        }
    }
}
