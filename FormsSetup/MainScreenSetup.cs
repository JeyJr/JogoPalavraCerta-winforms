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
            SetTextLabelPontos();

            //SetFilePath();
            //SetComboBoxValues();
        }

        //SQL Server
        private void SetTextLabelPontos()
        {
            string connString = StringConnection.UserPlayer;

            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    var sql = "SELECT TOP 1 animais, carros, motos, frutas FROM PalavraCerta.dbo.pontos;";
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        long maxPoints = GetFromTablePointsAllValues(reader);
                        InvokeLabelPontos(maxPoints);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu uma exceção: " + ex.Message);
                MessageBox.Show("Ocorreu um erro ao recuperar os pontos. Por favor, tente novamente mais tarde.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private long GetFromTablePointsAllValues(SqlDataReader reader)
        {
            long maxPoints = 0;

            if (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (!reader.IsDBNull(i))
                    {
                        var value = reader.GetInt64(i);
                        maxPoints += value;
                    }
                }
            }

            return maxPoints;
        }
        private void InvokeLabelPontos(long result)
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
