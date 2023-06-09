﻿using JogoPalavraCerta.Database.PointsSetup;
using JogoPalavraCerta.Database.SQL;
using JogoPalavraCerta.Database.TentativasSetup;
using JogoPalavraCerta.Formularios;
using JogoPalavraCerta.Formularios.FormulariosSetup.MainScreen;

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
            //Capturar o objeto selecionado em categoria e dificuldade
            //Vai acessar o banco onde possui a tabela selecionada e ira sortear uma unica palavra desse db
            string tableName = ControleInterfaces.Instance.MainScreen.comboBoxCategoria.SelectedItem.ToString();
            string palavra = EscolherPalavraSQL.SelecionarPalavra(tableName);

            int indexDificuldade = ControleInterfaces.Instance.MainScreen.comboBoxDificuldade.SelectedIndex;
            TentativasControl.Instance.DefinirNumeroDeTentativas(indexDificuldade);

            PalavraSelecionada.Instance.Palavra = palavra;

            ControleInterfaces.Instance.EnableMainScreen(false);
        }

        private void MainScreen_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                lblPontos.Text = PointsControl.Instance.ObterPontosArquivosDePontuacao();
            }
        }
    }
}
