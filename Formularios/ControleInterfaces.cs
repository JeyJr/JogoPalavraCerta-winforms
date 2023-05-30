using JogoPalavraCerta.ControleUsuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Formularios
{
    /// <summary>
    /// Singleton: Controlar mainScreen e matchScreen
    /// </summary>
    public class ControleInterfaces
    {
        //Fazer a troca das telas ou habilitar e desabilitar a main/match screen
        private MainScreen mainScreen = new MainScreen();
        private MatchScreen matchScreen = new MatchScreen();

        public MainScreen MainScreen { get => mainScreen; }
        public MatchScreen MatchScreen { get => matchScreen; }

        private static ControleInterfaces instance = new ControleInterfaces();
        public static ControleInterfaces Instance = instance ?? new ControleInterfaces();
        private ControleInterfaces()
        {

        }

        public Form MainForm { get; private set; } = null;
        public void SetMainForm(Form mainForm)
        {
            MainForm = mainForm;
            MainForm.Controls.Add(mainScreen);
            MainForm.Controls.Add(matchScreen);
        }

        /// <summary>
        /// Habilita ou desabilita os controles de usuario MainScreen e MatchScreen no Form
        /// Modifica o tamanho do form para o tamanho do controle de usuario
        /// </summary>
        /// <param name="enable">Verdadeiro, habilita MainScreen. Falso, habilita matchScreen</param>
        public void EnableMainScreen(bool enable)
        {
            mainScreen.Visible = enable;
            matchScreen.Visible = !mainScreen.Visible;

            SetMainFormSize(enable ? mainScreen.Size : matchScreen.Size);
        }
        private void SetMainFormSize(Size size) => MainForm.Size = size;
    }
}
