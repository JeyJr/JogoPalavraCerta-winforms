using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoPalavraCerta.Database
{
    public static class StringConnection
    {
        //"Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;"
        // "Server=localhost\\SQLEXPRESS04;Database=PalavraCerta;User Id=player;Password=#foc*#23agYUJhs2;"
        public static string WindowsAuthentication { get; } = "Server=localhost\\SQLEXPRESS04;Database=PalavraCerta;Trusted_Connection=True;";
        public static string UserPlayer { get; } = "Server=localhost\\SQLEXPRESS04;Database=PalavraCerta;User Id=player;Password=#foc*#23agYUJhs2;";
    }

}
