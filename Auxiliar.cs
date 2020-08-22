using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Microsoft.Office.Interop.PowerPoint; 

namespace tcc
{
    public static class Auxiliar
    {
        //public static ApplicationClass ppt;// = new ApplicationClass();
       // public static Microsoft.Office.Interop.PowerPoint.Application ppt;
        public enum ModoDeOperacao : int
        { 
           POWERPOINT,
           MEDIAPLAYER,
           BROWSER,
            BLACKBOARD,
            UNK
        }
        public static ModoDeOperacao modoDeOperacao;

        public static void mostrarErro(string err)
        {
            MessageBox.Show("Não sabemos como, mas ocorreu um erro...\n" + err, "Oooops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
