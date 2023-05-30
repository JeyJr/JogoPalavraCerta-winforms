using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Forms.FormsSetup
{
    public class MatchSetup
    {
        private List<Button> btns = new List<Button>();
        private char[] alfabet = new char[26];

        private readonly UserControl userControl;
        private readonly ICharacterClickHandler characterClickHandler;


        public MatchSetup(ICharacterClickHandler characterClickHandler, UserControl userControl)
        {
            this.characterClickHandler = characterClickHandler;
            this.userControl = userControl;

            SetAlfabetCharacters();
            CreateBtns();

        }

        private void SetAlfabetCharacters()
        {
            for (int i = 0; i < 26; i++)
                alfabet[i] = (char)('A' + i);
        }


        private void CreateBtns()
        {
            int x = 30;
            int y = 320;

            for (int i = 0; i < 13; i++)
            {
                Button btn = new Button();
                btn.Text = alfabet[i].ToString();
                btn.Click += characterClickHandler.btnSelectCharacter_Click;

                btns.Add(btn);

                btn.Location = new Point(x, y);
                btn.Width = 30;
                btn.Height = 30;

                x += btn.Width + 5;

                userControl.Controls.Add(btn);
            }
            x = 30;
            y += 40;

            for (int i = 13; i < 26; i++)
            {
                Button btn = new Button();
                btn.Text = alfabet[i].ToString();
                btn.Click += characterClickHandler.btnSelectCharacter_Click;

                btns.Add(btn);

                btn.Location = new Point(x, y);
                btn.Width = 30;
                btn.Height = 30;

                x += btn.Width + 5;

                userControl.Controls.Add(btn);
            }
        }


    }
}
