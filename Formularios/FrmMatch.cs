using JogoPalavraCerta.ControleUsuario;
using JogoPalavraCerta.Formularios;
using System.Diagnostics;

namespace JogoPalavraCerta.Forms
{
    public partial class FrmMatch : Form
    {
        public FrmMatch()
        {
            InitializeComponent();
            ControleInterfaces.Instance.SetMainForm(this);
        }


        private void FrmMatch_Load(object sender, EventArgs e)
        {
            ControleInterfaces.Instance.EnableMainScreen(true);
        }
    }
}
