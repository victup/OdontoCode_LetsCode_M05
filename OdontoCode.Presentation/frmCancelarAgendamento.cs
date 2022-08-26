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

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {
            string busca = " ";
            string buscaPNome = " ";
            string buscaPcpf = "";
            string buscaDNome = " ";
            string buscaDC = " ";
            buscaPNome = txtNomePaciente.Text;
            buscaPcpf = txbCpfPaciente.Text;
            buscaDNome = txtNomeDentista.Text;
            buscaDC = txtDescricao.Text;

            var x = new AgendamentoService();
            var agendamento = _agendamentoService.SearchForApointment(buscaPcpf, buscaPNome, buscaDNome, buscaDC);
            foreach (var item in agendamento)
            {
                lstAgendamento.Items.Add($"{item.Show()} | Paciente: {x.GetPacientName(item.Id_paciente)} | Dentista: {x.GetDentistName(item.Id_dentista)}");
            }

            txtIdAgendamento.Text = agendamento[0].Id_agendamento.ToString();
            txtNomePaciente.Text = _agendamentoService.GetPacientName(agendamento[0].Id_paciente);
            txbCpfPaciente.Text = _agendamentoService.SearchPacintCPFForID(agendamento[0].Id_paciente);
            txtNomeDentista.Text = _agendamentoService.GetDentistName(agendamento[0].Id_dentista);
            txtDescricao.Text = agendamento[0].Desc_consulta;
            txtData.Text = agendamento[0].Data.ToString();


            lblDentista.Visible = true;
            txtNomeDentista.Visible = true;
            lblDataAgendamento.Visible = true;
            txtData.Enabled = true;
            txtData.Visible = true;
            lblDescricaoAgendamento.Visible = true;
            txtDescricao.Visible = true;
            lstAgendamento.Visible = true;
            btnCancelarAgendamento.Visible = true;
            btnLimpar.Visible = true;
        }

        private void btnCancelarAgendamento_Click(object sender, EventArgs e)
        {
            int id_agendamento;
            int.TryParse(txtIdAgendamento.Text, out id_agendamento);
            Agendamento agendamento = _agendamentoService.BuscarAgendamentoPorID(id_agendamento);

            if (_agendamentoService.CancelAppointment(id_agendamento))
            {
                MessageBox.Show($"Agendamento Cancelado!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomePaciente.Text = String.Empty;
            txbCpfPaciente.Text = String.Empty;
            txtNomeDentista.Text = String.Empty;
            txtData.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            txtIdAgendamento.Text = String.Empty;
            lstAgendamento.Items.Clear();
        }
    }
}
