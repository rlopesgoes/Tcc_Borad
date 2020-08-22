using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tcc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Filtro de mensagens para a aplicação
            //Substituido pelo bloco de filtro global
            //Application.AddMessageFilter(new Filtro());
            
            Application.Run(new Principal());
        }
    }
}
