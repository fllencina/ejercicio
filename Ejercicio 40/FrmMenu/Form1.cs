using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralTelefonica;
using FrmLlamador;

namespace FrmMenu
{
    public partial class Central_Telefonica : Form
    {
        public Central_Telefonica()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Central_Telefonica_Load(object sender, EventArgs e)
        {
            Centralita centralita = new Centralita();
        }

        private void Btn_Generar_Llamada_Click(object sender, EventArgs e)
        {
            Frm_Llamador llamador = new Frm_Llamador();
            llamador.Show(IWin32Window) ;
        }
    }
}
