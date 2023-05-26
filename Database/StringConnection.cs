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
        public static string WindowsAuthentication { get; } = "Server=JJ\\SQLEXPRESS;Database=PalavraCerta;Trusted_Connection=True;";
        public static string UserSa { get; } = "Server=JJ\\SQLEXPRESS;Database=PalavraCerta;User Id=sa;Password=dbaP#@1990;";
        public static string UserPlayer { get; } = "Server=JJ\\SQLEXPRESS;Database=PalavraCerta;User Id=player;Password=dbaplayer@2023;";
    }

}
