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
            frmBuscarDentista frmBuscarDentista = new frmBuscarDentista(_dentistService);
            frmBuscarDentista.ShowDialog();
            this.Show();
        }

        private void menuDentistaDesligar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDesligarDentista frmDesligarDentista = new frmDesligarDentista(_dentistService);
            frmDesligarDentista.ShowDialog();
            this.Show();
        }

        private void menuDetistaNovo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNovoDentista frmNovoDentista = new frmNovoDentista(_dentistService);
            frmNovoDentista.ShowDialog();
            this.Show();

        }

        private void menuDentistaAtualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAtualizarDentista frmAtualizarDentista = new frmAtualizarDentista(_dentistService);
            frmAtualizarDentista.ShowDialog();
            this.Show();
        }

        private void opcNovoAgendamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNovoAgendamento frmNovoAgendamento = new frmNovoAgendamento(_agendamentoService);
            frmNovoAgendamento.ShowDialog();
            this.Show();
        }

        private void opcAgendamentosBuscar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBuscarAgendamento frmBuscarAgendamento = new frmBuscarAgendamento(_agendamentoService);
            frmBuscarAgendamento.ShowDialog();
            this.Show();
        }

        private void opcAlterarAgendamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAlterarAgendamento frmAlterarAgendamento = new frmAlterarAgendamento (_agendamentoService);
            frmAlterarAgendamento.ShowDialog();
            this.Show();
        }

        private void menuAgendamentoCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelarAgendamento frmCancelarAgendamento = new frmCancelarAgendamento(_agendamentoService);
            frmCancelarAgendamento.ShowDialog();
            this.Show();
        }
    }
}
