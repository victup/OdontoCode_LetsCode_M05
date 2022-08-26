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

        private async void btnCadastrarDentista_Click(object sender, EventArgs e)
        { 
            var entradaValida =  ValidaCamposNovoDentista();

            if( entradaValida)
            {
               bool sucessoCadastro = _dentistService.RegistrarDentista(new Dentista(_dentistService.GerarId(), txtNomeDentista.Text, txtDentistaCPF.Text, txtCroDentista.Text, txtTelDentista.Text, true));

                if(!sucessoCadastro)
                    MessageBox.Show($"Já existe uma pessoa com o CPF {txtDentistaCPF.Text} ou CRO {txtCroDentista.Text} cadastrado!");
                else
                    await CarregarNovoRegistro(txtNomeDentista.Text);

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

        private void menuPaginaInicial_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja sair? Procedimentos não confirmados poderão ser perdidos.", "Voltar para Tela Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        public async Task CarregarNovoRegistro(string dentista)
        {
            lblMensagem.Visible = true;

            lblMensagem.Text = $"Aguarde enquanto registramos o novo dentista {dentista}!";
            lblMensagem.ForeColor = Color.Red;


            await Task.Delay(TimeSpan.FromSeconds(3));

            lblMensagem.Visible = false;
            MessageBox.Show($"Dentista {dentista} cadastrado com sucesso!");
        }
    }
}
