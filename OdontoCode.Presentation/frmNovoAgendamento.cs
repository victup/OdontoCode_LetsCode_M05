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
using System.Xml.Linq;

namespace OdontoCode.Presentation
{
    public partial class frmNovoAgendamento : Form
    {
        private readonly IAgendamentoService _agendamentoService;
        Agendamento agendamento;
        public frmNovoAgendamento(IAgendamentoService _agendamento)
        {
            InitializeComponent();
            _agendamentoService = _agendamento;
        }

        private void frmNovoAgendamento_Load(object sender, EventArgs e)
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

        private Agendamento NewApointment()
        {
            var aService = new AgendamentoService();
            var data = Convert.ToDateTime(txtData.Text);
            var ds_consulta = txtDescricao.Text;
            var nomePaciente = txtNomePaciente.Text;
            var id_paciente = aService.SearchPacientIDForName(nomePaciente);
            var nomeDentista = txtNomeDentista.Text;
            var id_dentista = aService.SearchDentistID(nomeDentista);

            var id = _agendamentoService.GerarNovoId();

            return agendamento = new Agendamento(id, data, ds_consulta, id_paciente[0], id_dentista[0]);

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
            btnAgendar.Visible = true;
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            var agendamento = NewApointment();
            _agendamentoService.NewAppointment(agendamento);
           
            MessageBox.Show("Agendamento confirmado!");
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            string x = _agendamentoService.AgendamentoCount();
            MessageBox.Show(x);
        }
    }
}
