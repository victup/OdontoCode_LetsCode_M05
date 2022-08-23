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
    public partial class frmMenu : Form
    {
        private readonly IDentistaService _dentistService;
        public frmMenu(IDentistaService _dentists)
        {
            InitializeComponent();

            _dentistService = _dentists;
        }

        private void menuDentistaBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarDentista frmBuscar = new frmBuscarDentista(_dentistService);
            frmBuscar.ShowDialog();
        }

        private void menuDentistaDesligar_Click(object sender, EventArgs e)
        {
            frmDesligarDentista frmDesligar = new frmDesligarDentista(_dentistService);
            frmDesligar.ShowDialog();
        }
    }
}
