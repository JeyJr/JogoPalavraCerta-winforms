using JogoPalavraCerta.Forms.FormsSetup;
using JogoPalavraCerta.Formularios;
using JogoPalavraCerta.Formularios.FormulariosSetup.MainScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoPalavraCerta.ControleUsuario
{
    public partial class MainScreen : UserControl
    {
        MainScreenSetup mainScreenSetup = null;

        public MainScreen()
        {
            InitializeComponent();
            btnJogar.Enabled = false;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            mainScreenSetup = new MainScreenSetup(comboBoxCategoria, comboBoxDificuldade, lblPontos, btnJogar);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            ControleInterfaces.Instance.EnableMainScreen(false);
        }


    }
}
