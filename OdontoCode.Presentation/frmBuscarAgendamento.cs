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
            DateTime buscaD = DateTime.MinValue;

            if (!String.IsNullOrEmpty(txtNomePaciente.Text))
                busca = txtNomePaciente.Text;
            else if (!String.IsNullOrEmpty(txtCpfPaciente.Text))
                busca = txtCpfPaciente.Text;
            else if (!String.IsNullOrEmpty(txtNomeDentista.Text))
                busca = txtNomeDentista.Text;
            else if (!String.IsNullOrEmpty(txtDataEHora.Text))
                buscaD = Convert.ToDateTime(txtDataEHora.Text);
            else
                busca = txtDescricao.Text;

            //agendamento = _agendamentoService.SearchForApointment(busca,busca,busca,busca,buscaD); 


            /*public void label1_Click(object sender, EventArgs e)
            {

            }

            public void btnLimpar_Click(object sender, EventArgs e)
            {
                txtNomePaciente.Text = String.Empty;
                txtCpfPaciente.Text = String.Empty;
                txtNomeDentista.Text = String.Empty;
                txtDataEHora.Text = String.Empty;
                txtDescricao.Text = String.Empty;
            }*/
        }
    }
}
