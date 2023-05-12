using JogoPalavraCerta.ControleUsuario;


namespace JogoPalavraCerta.Forms
{
    public partial class FrmMatch : Form
    {
        public FrmMatch()
        {
            InitializeComponent();
        }

        private void CriarMainScreen()
        {
            MainScreen mainScreen = new MainScreen();
            MatchScreen matchScreen = new MatchScreen();

            this.Size = matchScreen.Size;
            this.Controls.Add(matchScreen);
        }

        private void FrmMatch_Load(object sender, EventArgs e)
        {
            CriarMainScreen();
        }
    }
}
