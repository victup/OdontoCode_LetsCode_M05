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
    public partial class frmAtualizarDentista : Form
    {
        private readonly IDentistaService _dentistaService;
        Dentista dentista;

        public frmAtualizarDentista(IDentistaService dentistaService)
        {
            InitializeComponent();
            _dentistaService = dentistaService;
        }

        private async void btnEncontrarDentista_Click(object sender, EventArgs e)
        {
            
            if ((String.IsNullOrEmpty(txtNomeDentistaAtualizar.Text)) &&
                (String.IsNullOrEmpty(txtDentistaCpfAtualizar.Text)) &&
                (String.IsNullOrEmpty(txtCroDentistaAtualizar.Text))
                )
            {
                MessageBox.Show($"Espera-se pelo menos um campo preenchido para realizar a busca.", "Nenhum parâmetro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                

                string busca = "";

                if (!String.IsNullOrEmpty(txtCroDentistaAtualizar.Text))
                    busca = txtCroDentistaAtualizar.Text;
                else
                if (!String.IsNullOrEmpty(txtDentistaCpfAtualizar.Text))
                    busca = txtDentistaCpfAtualizar.Text;
                else
                    busca = txtNomeDentistaAtualizar.Text;


                await CarregarBusca();
                dentista = _dentistaService.BuscarDentista(busca);

                if (dentista.CPF != null)
                {
                    btnEncontrarDentista.Visible = false;
                    btnAtualizarDentista.Visible = true;
                    lblTelefoneDentista.Visible = true;
                    txtTelefoneDentistaAtualizar.Visible = true;

                    txtCroDentistaAtualizar.Text = dentista.CRO;
                    txtNomeDentistaAtualizar.Text = dentista.Nome;
                    txtTelefoneDentistaAtualizar.Text = dentista.Telefone;
                    txtDentistaCpfAtualizar.Text = dentista.CPF;
                }
                else
                {
                    MessageBox.Show($"Não encontramos nenhum dentista com os valores fornecidos.");
                    btnEncontrarDentista.Visible = true;
                    
                }

            }
                

           
            
        }

        private async void btnAtualizarDentista_Click(object sender, EventArgs e)
        {
            if (dentista != null)
            {
                string cpfAntigo = dentista.CPF;
                
                dentista.Nome = txtNomeDentistaAtualizar.Text;
                dentista.CRO = txtCroDentistaAtualizar.Text;
                dentista.CPF = txtDentistaCpfAtualizar.Text;
                dentista.Telefone = txtTelefoneDentistaAtualizar.Text;

                btnAtualizarDentista.Visible = false;
                btnEncontrarDentista.Visible = true;

                _dentistaService.AlterarDentista(cpfAntigo, dentista);

                await CarregarAtualizacao(dentista.Nome);

                txtNomeDentistaAtualizar.Text = String.Empty;
                txtCroDentistaAtualizar.Text = String.Empty;
                txtTelefoneDentistaAtualizar.Text = String.Empty;
                txtDentistaCpfAtualizar.Text = String.Empty;

                
            }

        }

        private void menuPaginaInicial_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja sair? Procedimentos não confirmados poderão ser perdidos.", "Voltar para Tela Principal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                this.Close();
        }

        public async Task CarregarAtualizacao(string dentista)
        {
            lblMensagem.Visible = true;

            lblMensagem.Text = $"Aguarde enquanto atualizamos o dentista {dentista}!";
            lblMensagem.ForeColor = Color.Red;


            await Task.Delay(TimeSpan.FromSeconds(3));

            MessageBox.Show($"Dentista {dentista} atualizado com sucesso");

            lblMensagem.Visible = false;
        }

        public async Task CarregarBusca()
        {
            lblMensagem.Visible = true;

            lblMensagem.Text = $"Aguarde enquanto realizamos sua busca!";
            lblMensagem.ForeColor = Color.Red;


            await Task.Delay(TimeSpan.FromSeconds(3));

            lblMensagem.Text = $"Busca finalizada!";
            lblMensagem.ForeColor = Color.Green;
            await Task.Delay(TimeSpan.FromSeconds(1));
            lblMensagem.Visible = false;
        }
    }
}
