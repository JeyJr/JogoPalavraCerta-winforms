using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Database.SQL
{
    public static class SQLcomandos
    {
        public static string ContagemGeral => "SELECT (SELECT COUNT(*) FROM animais) + (SELECT COUNT(*) FROM carros);";

    }
}
