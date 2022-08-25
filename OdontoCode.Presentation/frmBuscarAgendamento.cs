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
        public frmBuscarAgendamento(IAgendamentoService _agendamento)
        {
            InitializeComponent();
            _agendamentoService = _agendamento; 
        }

        private void frmBuscarAgendamento_Load(object sender, EventArgs e)
        {

        }

        private void SearchForApointment(string cpfPaciente, string nomePaciente, string nomeDentista, string ds_consulta)
        {
            var busca = new AgendamentoService();
            var listaImp = new List<int>();
            var listForDentistName = busca.SearchApointmentForDentistID(busca.SearchDentistID(nomeDentista));
            var listForPacientCPF = busca.SearchApointmentForPacientID(busca.SearchPacientIDForCPF(cpfPaciente));
            var listForPacientName = busca.SearchApointmentForPacientID(busca.SearchPacientIDForName(nomePaciente));
            var listForConsultDS = busca.SearchApointmentID(ds_consulta);

            var list = new List<Agendamento>();
            foreach (var item in listaAgendamento3)
            {
                if ((listForDentistName.Contains(item.Id_agendamento) || nomeDentista == "") &&
                    (listForPacientCPF.Contains(item.Id_agendamento) || cpfPaciente == "") &&
                    (listForDentistName.Contains(item.Id_agendamento) || nomePaciente == "") &&
                    (listForConsultDS.Contains(item.Id_agendamento) || ds_consulta == ""))
                {

                    listBox1.Items.Add($"{item.Show(item.Id_agendamento)}");
                }
            }
        }
    }
}
