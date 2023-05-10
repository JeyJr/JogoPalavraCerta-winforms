using JogoPalavraCerta.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.FormsSetup
{
    public sealed class MainScreenSetup
    {
        private ComboBox categoria;
        private ComboBox dificuldade;
        private Label pontos;


        string tempFolderPath = "";
        string tempFilePath = "";

        public MainScreenSetup(ComboBox categoria, ComboBox dificuldade, Label pontos) 
        { 
            this.categoria = categoria;
            this.dificuldade = dificuldade;
            this.pontos = pontos;


            tempFolderPath = Path.GetTempPath();
            tempFilePath = Path.Combine(tempFolderPath, "dataG.txt");

            SetComboBoxValues();
        }

        private async void SetComboBoxValues()
        {
            await Task.Run(() =>
            {
                InvokeComboBoxCategoria();
                InvokeComboBoxDificuldade();
                InvokeLabelPontos();
            });
        }

        private void InvokeLabelPontos()
        {
            pontos.Invoke((MethodInvoker)(() =>
            {
                if (!File.Exists(tempFilePath))
                {
                    using(var write = new StreamWriter(tempFilePath))
                    {
                        write.WriteLine("0");
                    }
                }

                using (var read = new StreamReader(tempFilePath))
                {
                    pontos.Text = "Pontos: " + read.ReadLine();
                }
                
            }));
        }

        private void InvokeComboBoxCategoria()
        {
            categoria.Invoke((MethodInvoker)(() =>
            {
                foreach (var item in Enum.GetValues(typeof(Categoria)))
                    categoria.Items.Add(item);

                categoria.SelectedIndex = 3;
            }));
        }
        private void InvokeComboBoxDificuldade()
        {
            dificuldade.Invoke((MethodInvoker)(() =>
            {
                foreach (var item in Enum.GetValues(typeof(Dificuldade)))
                    dificuldade.Items.Add(item);

                dificuldade.SelectedIndex = 2;
            }));
        }
    }
}
