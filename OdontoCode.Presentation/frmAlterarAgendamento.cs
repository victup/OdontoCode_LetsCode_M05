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
            var id_paciente = SetName();
            txbCpfPaciente.Text = _agendamentoService.SearchPacintCPFForID(id_paciente);
            txtNomePaciente.Text = _agendamentoService.GetPacientName(id_paciente);

            var id_dentista = SetDentist();
            txtNomeDentista.Text = _agendamentoService.GetDentistName(id_dentista);
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
