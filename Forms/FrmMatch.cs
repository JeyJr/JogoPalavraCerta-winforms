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

            this.Size = mainScreen.Size;
            this.Controls.Add(mainScreen);
        }

        private void FrmMatch_Load(object sender, EventArgs e)
        {
            CriarMainScreen();
        }
    }
}
