using JogoPalavraCerta.Database;
using JogoPalavraCerta.Setup;
using System.Data.SqlClient;

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
            Teste();

            //SetFilePath();
            //SetComboBoxValues();
        }

        //SQL Server
        private void Teste()
        {
            string connString = StringConnection.UserPlayer;

            using(var conn = new SqlConnection(connString))
            {
                conn.Open();
                var sql = "SELECT count(*) FROM carros";
                
                using(var cmd = new SqlCommand(sql, conn))
                {
                    int result = (int)cmd.ExecuteScalar();
                    InvokeLabelPontos(result);
                }

                conn.Close();
            }
        }
        private void InvokeLabelPontos(int result)
        {
            pontos.Invoke((MethodInvoker)(() =>
            {
                pontos.Text = "Pontos: " + result;
            }));
        }


        //Database local
        private void SetFilePath()
        {
            tempFolderPath = Path.GetTempPath();
            tempFilePath = Path.Combine(tempFolderPath, "dataG.txt");
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
                try
                {
                    if (!File.Exists(tempFilePath))
                    {
                        using (var write = new StreamWriter(tempFilePath))
                        {
                            write.WriteLine("0");
                        }
                    }

                    using (var read = new StreamReader(tempFilePath))
                    {
                        pontos.Text = "Pontos: " + read.ReadLine();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Arquivo nao encontrado!");
                    throw;
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
