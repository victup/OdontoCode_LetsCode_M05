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
        
        
    }
}
