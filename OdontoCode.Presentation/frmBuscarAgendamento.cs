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
    public partial class frmBuscarAgendamento : Form
    {
        private readonly IAgendamentoService _agendamentoService;
        Agendamento agendamento;
        public frmBuscarAgendamento(IAgendamentoService _agendamento)
        {
            InitializeComponent();
            _agendamentoService = _agendamento;
        }

        private void frmBuscarAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {
            string busca = " ";
            string buscaPNome = " ";
            string buscaPcpf = "";
            string buscaDNome = " ";
            string buscaDC = " ";
            //DateTime buscaDH = Convert.ToDateTime("2022-08-05T10:00:00");
            buscaPNome = txtNomePaciente.Text;
            buscaPcpf = txtCpfPaciente.Text;
            buscaDNome = txtNomeDentista.Text;
            buscaDC = txtDescricao.Text;
            //buscaDH = Convert.ToDateTime(txtDataEHora.Text);
            var x = new AgendamentoService();
            var agendamento = _agendamentoService.SearchForApointment(buscaPcpf, buscaPNome, buscaDNome, buscaDC);
            foreach (var item in agendamento)
            {
                listAgendamento.Items.Add($"{item.Show()} | Paciente: {x.GetPacientName(item.Id_paciente)} | Dentista: {x.GetDentistName(item.Id_dentista)}");
            }
            lblAgendamentoEncontrado.Visible = true;
            listAgendamento.Visible = true;
            btnLimpar.Visible = true;
            
        }

        void label1_Click(object sender, EventArgs e)
        {

        }

        void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtNomePaciente.Text = String.Empty;
            txtCpfPaciente.Text = String.Empty;
            txtNomeDentista.Text = String.Empty;
            txtDataEHora.Text = String.Empty;
            txtDescricao.Text = String.Empty;
            listAgendamento.Items.Clear();
            lblAgendamentoEncontrado.Visible = false;
            listAgendamento.Visible = false;
            btnLimpar.Visible = false;
            
        }
    }
}
