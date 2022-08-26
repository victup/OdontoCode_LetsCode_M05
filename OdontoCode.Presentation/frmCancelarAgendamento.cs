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
    public partial class frmCancelarAgendamento : Form
    {
        private readonly IAgendamentoService _agendamentoService;
        Agendamento agendamento;
        public frmCancelarAgendamento(IAgendamentoService _agendamento)
        {
            InitializeComponent();
            _agendamentoService = _agendamento;
        }

        private void frmCancelarAgendamento_Load(object sender, EventArgs e)
        {

        }

        private int SetName()
        {
            var id_paciente = new List<int>() { 0 };
            if (txbCpfPaciente.Text != "")
            {
                var CPFPaciente = txbCpfPaciente.Text;
                id_paciente = _agendamentoService.SearchPacientIDForCPF(CPFPaciente);
            }
            if (txtNomePaciente.Text != "")
            {
                var nomePaciente = txtNomePaciente.Text;
                id_paciente = _agendamentoService.SearchPacientIDForName(nomePaciente);
            }
            return id_paciente[0];
        }

        private int SetDentist()
        {
            var id_dentista = new List<int>() { 0 };
            if (txtNomeDentista.Text != "")
            {
                var nomeDentista = txtNomeDentista.Text;
                id_dentista = _agendamentoService.SearchDentistID(nomeDentista);
            }

            return id_dentista[0];
        }

        

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {
            var id_paciente = SetName();
            txbCpfPaciente.Text = _agendamentoService.SearchPacintCPFForID(id_paciente);
            txtNomePaciente.Text = _agendamentoService.GetPacientName(id_paciente);

            var id_dentista = SetDentist();
            txtNomeDentista.Text = _agendamentoService.GetDentistName(id_dentista);

            lblDentista.Visible = true;
            txtNomeDentista.Visible = true;
            lblDataAgendamento.Visible = true;
            txtData.Visible = true;
            lblDescricaoAgendamento.Visible = true;
            txtDescricao.Visible = true;
            btnCancelarAgendamento.Visible = true;
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            _agendamentoService.CancelAppointment(agendamento);

            MessageBox.Show("Agendamento cancelado!");
        }
        private void btncount_Click(object sender, EventArgs e)
        {
            string x = _agendamentoService.AgendamentoCount();
            MessageBox.Show(x);
        }
    }
}
