using JogoPalavraCerta.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.FormsSetup
{
    public sealed class MainScreenSetup
    {
        private ComboBox categoria;
        private ComboBox dificuldade;
        private Label pontos;

        public MainScreenSetup(ComboBox categoria, ComboBox dificuldade, Label pontos) 
        { 
            this.categoria = categoria;
            this.dificuldade = dificuldade;
            this.pontos = pontos;

            SetComboBoxValues();
        }

        private async void SetComboBoxValues()
        {
            await Task.Run(() => {

                categoria.Invoke((MethodInvoker)(() => {
                    foreach (var item in Enum.GetValues(typeof(Categoria)))
                        categoria.Items.Add(item);

                    categoria.SelectedIndex = 3;
                }));

                dificuldade.Invoke((MethodInvoker)(() => {
                    foreach (var item in Enum.GetValues(typeof(Dificuldade)))
                        dificuldade.Items.Add(item);

                    dificuldade.SelectedIndex = 2;
                }));
            });
        }


    }
}
