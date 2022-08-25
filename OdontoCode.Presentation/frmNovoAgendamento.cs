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
    public partial class frmNovoAgendamento : Form
    {
        private readonly IAgendamentoService _agendamentoService;
        public frmNovoAgendamento(IAgendamentoService _agendamento)
        {
            InitializeComponent();
            _agendamentoService = _agendamento;
        }

        private void frmNovoAgendamento_Load(object sender, EventArgs e)
        {
            
        }

        private void GetInfos()
        {
            var aService = new AgendamentoService();
            //var data = (forms campo data)
            //var ds_consulta = (forms campo descrição consulta)
            //var nomePaciente = (forms campo nome paciente)
            //id_paciente = aService.SearchPacientIDForName(nomePaciente)
            //var nomeDentista = (forms campo nome dentista)
            //id_dentista = aService.SearchDentistID(nomeDentista)
        }

        private void NewApointment()
        {

            
        }
    }
}
