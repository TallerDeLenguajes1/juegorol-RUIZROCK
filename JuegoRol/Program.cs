using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using System.IO;
/*
using System.Text.Json;
using System.Text.Json.Serialization;
*/
namespace JuegoRol
{
    static class Program
    {
        
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            List<string> namePersonajes = new List<string>();
            Application.Run(new CrearPlayer(namePersonajes));
        }

    }
}

