using JogoPalavraCerta.ControleUsuario;
using System.Diagnostics;

namespace JogoPalavraCerta.Forms
{
    public partial class FrmMatch : Form
    {
        public FrmMatch()
        {
            InitializeComponent();
        }

        //Refatorar
        private void CriarMainScreen()
        {
            var mainScreen = new MainScreen();
            var matchScreen = new MatchScreen();



            this.Size = mainScreen.Size;
            this.Controls.Add(mainScreen);
            this.Controls.Add(matchScreen);

            matchScreen.Visible = false;
        }

        private void FrmMatch_Load(object sender, EventArgs e)
        {
            CriarMainScreen();
        }
    }
}
