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
    public partial class frmNovoDentista : Form
    {
        private readonly IDentistaService _dentistService;
        public frmNovoDentista(IDentistaService dentistaService)
        {
            InitializeComponent();

            _dentistService = dentistaService;  
        }

        private void btnCadastrarDentista_Click(object sender, EventArgs e)
        { 
            var entradaValida =  ValidaCamposNovoDentista();

            if( entradaValida)
            {
                _dentistService.RegistrarDentista(new Dentista(_dentistService.GerarId(), txtNomeDentista.Text, txtDentistaCPF.Text, txtCroDentista.Text, txtTelDentista.Text, true));

                MessageBox.Show($"Dentista {txtNomeDentista.Text} cadastrado com sucesso!");

                txtNomeDentista.Text = String.Empty;
                txtDentistaCPF.Text = String.Empty;
                txtCroDentista.Text = String.Empty;
                txtTelDentista.Text = String.Empty;

            }
            
        }

        private bool VerificarEntradaValidaCampo(TextBox campo, Label label)
        {
            if (campo.Text == String.Empty)
            {
                label.Visible = true;
                label.Text = "não pode ser vazio";
                label.ForeColor = Color.Red;

                return false;

            }
            else
            {
                label.Visible = false;
                return true;
            }     

        }

        private bool ValidaCamposNovoDentista()
        {
            bool resultado = true;

            bool nome = VerificarEntradaValidaCampo(txtNomeDentista, lblVerificaNome);
            bool cpf = VerificarEntradaValidaCampo(txtDentistaCPF, lblVerificaCpf);
            bool cro = VerificarEntradaValidaCampo(txtCroDentista, lblVerificaCro);
            bool telefone = VerificarEntradaValidaCampo(txtTelDentista, lblVerificaTelefone);

            if(nome == false || cpf == false || cro == false || telefone == false)
                resultado = false;
            else 
                resultado = true;

            return resultado;
        }
    }
}
