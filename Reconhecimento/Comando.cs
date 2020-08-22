using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.PowerPoint;
using System.Resources;
using System.Reflection;
using WindowsInput;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace tcc
{
    public class Comando
    {
        private void salvarComandos(string cmd)
        {
            System.IO.StreamWriter wr = new System.IO.StreamWriter("log.txt",true);
            wr.WriteLine(cmd);
            wr.Flush();
            wr.Close();
        }
       
        private void mostrarModoNaoSetado()
        {
            MessageForm frm = new MessageForm("MODO NÃO SETADO");
            frm.Show();
        }

        public void executarComando(string cmd)
        {
            switch (Auxiliar.modoDeOperacao)
            {
                case Auxiliar.ModoDeOperacao.UNK :
                    { this.mostrarModoNaoSetado(); break; }
                case Auxiliar.ModoDeOperacao.MEDIAPLAYER:
                    { MediaPlayer.executarComandoMediaPlayer(cmd); break; }
                case Auxiliar.ModoDeOperacao.BROWSER:
                    { Browser.executarComandoBrowser(cmd); break; }
                case Auxiliar.ModoDeOperacao.POWERPOINT:
                    { PowerPoint.executarComandoPowerPoint(cmd); break; }
                case Auxiliar.ModoDeOperacao.BLACKBOARD:
                    { BlackBoard.executarComandoPowerPoint(cmd); break; }  
            }          
        }
    }
}
