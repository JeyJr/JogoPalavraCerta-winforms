using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace JogoPalavraCerta.Database
{
    public class EscolherPalavraSQL
    {
        public static string SelecionarPalavra(string tableName)
        {
            using(SqlConnection  conn = new SqlConnection(StringConnection.UserPlayer))
            {
                try
                {
                    conn.Open();
                    int count = GetTableCount(tableName, conn);
                    string palavra = GetTableItem(count, tableName, conn);
                    return palavra;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// Verificar o tamanho da tabela
        /// </summary>
        /// <param name="tableName"> Nome da tabela </param>
        /// <param name="conn">Conexão</param>
        /// <returns></returns>
        private static int GetTableCount(string tableName, SqlConnection conn)
        {
            string queryCount = $"SELECT COUNT(*) FROM {tableName}";
            SqlCommand commandCount = new SqlCommand(queryCount, conn);
            return (int)commandCount.ExecuteScalar();
        }

        private static string GetTableItem(int count, string tableName, SqlConnection conn)
        {
            Random random = new Random();
            int randomIndex = random.Next(1, count + 1);
            string querySelect = $"SELECT * FROM {tableName} ORDER BY(SELECT NULL) OFFSET {randomIndex - 1} ROWS FETCH NEXT 1 ROWS ONLY";
            SqlCommand commandSelect = new SqlCommand(querySelect, conn);
            string selectedName = (string)commandSelect.ExecuteScalar();

            return selectedName;
        }
    }
}
