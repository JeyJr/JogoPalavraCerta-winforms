using JogoPalavraCerta.Database.TentativasSetup;
using JogoPalavraCerta.Formularios;

namespace JogoPalavraCerta.Database.GameOver
{
    public class GameOver
    {
        public static bool VerificarFimDeJogo()
        {
            if (TentativasControl.Instance.VerificarSeOJogoAcabou())
            {
                var result = MessageBox.Show("G A M E    O V E R", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                if(DialogResult.OK == result)
                {
                    ControleInterfaces.Instance.EnableMainScreen(true);
                }

                return true;
            }

            return false;
        }
    }
}
