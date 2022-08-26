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
    
    public partial class frmAlterarAgendamento : Form
    {
        private readonly IAgendamentoService _agendamentoService;
        Agendamento agendamento;
        public frmAlterarAgendamento(IAgendamentoService _agendamento)
        {
            InitializeComponent();
            _agendamentoService = _agendamento;
        }

        private void frmAlterarAgendamento_Load(object sender, EventArgs e)
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
            string busca = " ";
            string buscaPNome = " ";
            string buscaPcpf = "";
            string buscaDNome = " ";
            string buscaDC = " ";

            //DateTime buscaDH = Convert.ToDateTime("2022-08-05T10:00:00");

            buscaPNome = txtNomePaciente.Text;

            buscaPcpf = txbCpfPaciente.Text;

            buscaDNome = txtNomeDentista.Text;

            buscaDC = txtDescricao.Text;

            //buscaDH = Convert.ToDateTime(txtDataEHora.Text);
            var x = new AgendamentoService();
            var agendamento = _agendamentoService.SearchForApointment(buscaPcpf, buscaPNome, buscaDNome, buscaDC);
            foreach (var item in agendamento)
            {
                lstAgendamento.Items.Add($"{item.Show()} | Paciente: {x.GetPacientName(item.Id_paciente)} | Dentista: {x.GetDentistName(item.Id_dentista)}");
            }
            
            lblDentista.Visible = true;
            txtNomeDentista.Visible = true;
            lblDataAgendamento.Visible = true;
            txtData.Visible = true;
            lblDescricaoAgendamento.Visible = true;
            txtDescricao.Visible = true;
            btnAlterarAgendamento.Visible = true;
        }

        private void btnAlterarAgendamento_Click(object sender, EventArgs e)
        {
            var data = Convert.ToDateTime(txtData.Text);
            var ds_consulta = txtDescricao.Text;
            _agendamentoService.ChangeAppointment(ds_consulta,data);

            MessageBox.Show("Agendamento alterado!");
        }
    }
}
