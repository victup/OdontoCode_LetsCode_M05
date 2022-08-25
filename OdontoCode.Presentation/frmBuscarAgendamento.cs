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

        private void btnEncontrarPaciente_Click(object sender, EventArgs e)
        {

        }
    }
}
