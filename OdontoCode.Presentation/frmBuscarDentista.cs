﻿using OdontoCode.Domain;
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
    public partial class frmBuscarDentista : Form
    {

        private readonly IDentistaService _dentistaService;

        Dentista dentista;
        public frmBuscarDentista(IDentistaService dentistaService)
        {
            InitializeComponent();
          
            _dentistaService = dentistaService;


        }
  

        private void btnEncontrarDentista_Click(object sender, EventArgs e)
        {

            

            if (!String.IsNullOrEmpty(txtNomeBuscarDentista.Text) ||
                !String.IsNullOrEmpty(txtCroDentistaBuscar.Text) ||
                !String.IsNullOrEmpty(txtDentistaCpfBuscar.Text)
                )
            {
                lblVerificaEntradas.Visible = false;

                string busca = "";

                if (!String.IsNullOrEmpty(txtCroDentistaBuscar.Text))
                    busca = txtCroDentistaBuscar.Text;
                else
                if (!String.IsNullOrEmpty(txtDentistaCpfBuscar.Text))
                    busca = txtDentistaCpfBuscar.Text;
                else
                    busca = txtNomeBuscarDentista.Text;



                dentista = _dentistaService.BuscarDentista(busca);

                if (dentista.CPF != null)
                {
                    btnEncontrarDentista.Visible = false;
                    btnLimparDentista.Visible = true;
                    lblTelefoneBuscarDentista.Visible = true;
                    txtTelefoneBuscarDentista.Visible = true;

                    txtCroDentistaBuscar.Text = dentista.CRO;
                    txtCroDentistaBuscar.Enabled = false;

                    txtNomeBuscarDentista.Text = dentista.Nome;
                    txtNomeBuscarDentista.Enabled = false;

                    txtTelefoneBuscarDentista.Text = dentista.Telefone;
                    txtTelefoneBuscarDentista.Enabled = false;

                    txtDentistaCpfBuscar.Text = dentista.CPF;
                    txtDentistaCpfBuscar.Enabled = false;

                    dentista.CPF = null;

                }
                else
                {
                    MessageBox.Show($"Não encontramos nenhum dentista com os valores fornecidos.");
                    btnEncontrarDentista.Visible = true;
                    btnLimparDentista.Visible = false;
                }

            }
            else
            {
                lblVerificaEntradas.Visible = true;
                lblVerificaEntradas.Text = $"Espera-se pelo menos um campo preenchido para realizar a busca.";
                lblVerificaEntradas.ForeColor = Color.Red;
            }
        }

        private void btnLimparDentista_Click(object sender, EventArgs e)
        {
            btnLimparDentista.Visible = false;
            btnEncontrarDentista.Visible = true;

            txtNomeBuscarDentista.Text = String.Empty;
            txtCroDentistaBuscar.Text = String.Empty;
            txtTelefoneBuscarDentista.Text = String.Empty;
            txtDentistaCpfBuscar.Text = String.Empty ;
            
            txtDentistaCpfBuscar.Enabled = true;
            txtTelefoneBuscarDentista.Enabled = true;
            txtNomeBuscarDentista.Enabled = true;
            txtCroDentistaBuscar.Enabled = true;
            
        }

       
    }
}
