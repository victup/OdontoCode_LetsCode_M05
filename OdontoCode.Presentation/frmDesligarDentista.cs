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
    public partial class frmDesligarDentista : Form
    {
        private readonly IDentistaService _dentistService;

        Dentista dentista;
        public frmDesligarDentista(IDentistaService dentistaService)
        {
            InitializeComponent();

            _dentistService = dentistaService;

        }

        private void btnEncontrarDentista_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNomeDesligarDentista.Text) ||
                !String.IsNullOrEmpty(txtCroDentistaDesligar.Text) ||
                !String.IsNullOrEmpty(txtDentistaCpfDesligar.Text)
                )
            {
                btnEncontrarDentista.Visible = false;
                btnDesligarDentista.Visible = true;
                lblMensagem.Visible = false;
                

                string busca = "";

                if (!String.IsNullOrEmpty(txtCroDentistaDesligar.Text))
                    busca = txtCroDentistaDesligar.Text;
                else
                if (!String.IsNullOrEmpty(txtDentistaCpfDesligar.Text))
                    busca = txtDentistaCpfDesligar.Text;
                else
                    busca = txtNomeDesligarDentista.Text;


                dentista = _dentistService.BuscarDentista(busca);

                if (dentista.CPF != null)
                {
                    lblTelefoneDesligarDentista.Visible = true;
                    txtTelefoneDesligarDentista.Visible = true;
                    txtCroDentistaDesligar.Text = dentista.CRO;
                    txtNomeDesligarDentista.Text = dentista.Nome;
                    txtTelefoneDesligarDentista.Text = dentista.Telefone;
                    txtDentistaCpfDesligar.Text = dentista.CPF;

                    btnDesligarDentista.Visible = true;
                }
                else
                {
                    MessageBox.Show($"Não encontramos nenhum dentista com os valores fornecidos.");
                    btnEncontrarDentista.Visible = true;
                    btnDesligarDentista.Visible = false;
                }

            }
            else
            {
                MessageBox.Show($"Espera-se pelo menos um campo preenchido para realizar a busca.", "Nenhum parâmetro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDesligarDentista_Click(object sender, EventArgs e)
        {
            await CarregarDesligamento(dentista.Nome);

            _dentistService.DesligarDentista(dentista);
            

            txtCroDentistaDesligar.Text = String.Empty;
            txtNomeDesligarDentista.Text = String.Empty;
            txtTelefoneDesligarDentista.Text = String.Empty;
            txtDentistaCpfDesligar.Text = String.Empty;
            btnDesligarDentista.Visible = false;
            btnEncontrarDentista.Visible = true;
            

       
        }

        private void menuHomePage_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja sair? Procedimentos não confirmados poderão ser perdidos.", "Voltar para Tela Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resposta == DialogResult.Yes)
                this.Close();
        }

        public async Task CarregarDesligamento(string dentista)
        {
            lblMensagem.Visible = true;

            lblMensagem.Text = $"Aguarde enquanto desligamos o dentista {dentista}!";
            lblMensagem.ForeColor = Color.Red;


            await Task.Delay(TimeSpan.FromSeconds(3));

            MessageBox.Show($"Dentista {dentista} desligado com sucesso");

            lblMensagem.Visible = false;
        }
    }
}
