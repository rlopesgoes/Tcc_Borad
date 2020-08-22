using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
/*********************************************************************
 * 
 *          PROGRAMA PARA RECONHECIMENTO DE GESTOS COM MOUSE
 * 
 * CLASSE FILTRO DE MENSAGENS
 * INTERCEPTA AS MENSAGENS DO SO E VERIFICA O MOUSEGESTURE
 * 
 * AUTOR: RICARDO LOPES DE GÓES
 * 
 * ********************************************************************/
namespace tcc
{
    class Filtro 
        : IMessageFilter //Implementa a interface IMessageFilter
    {
        //Guarda os segmentos obtidos
        private List<Segmento> segmentos;
        //Seta o status atual
        private bool adquirindo;
        //Variaveis onde são guardados os valores
        private int xIni, 
                    yIni, 
                    xFim, 
                    yFim, 
                    deltaX, 
                    deltaY;

       // private const uint mouseMoveSegmentLength = 50;//Define o tamanho minimo do segmento
  
        private int tamanhoMinimoSegmento;// = Convert.ToInt32(Properties.Settings.Default.tam_segmento);
   
   
        //Vetor que guarda o último ponto lido(x,y)
        private int[] ultimoPonto = new int[2];
        
        //Utiliza a função GetCursorPos da api do windows
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        public Filtro()
        {
            //Construtor padrão
            this.adquirindo = false;
            this.segmentos  = new List<Segmento>();
            try
            {
                this.tamanhoMinimoSegmento = Convert.ToInt32(Properties.Settings.Default.tam_segmento);
            }
            catch
            {
                tamanhoMinimoSegmento = 50;
            }
        }

        public enum MessageCode : int
        {
            //Códigos das mensagens do Windows
            WM_RBUTTONDOWN = 0x0204,//Botão direito down
            WM_RBUTTONUP = 0x0205,//Botão direito up
            WM_MOUSEMOVE = 0x0200,//Movimento do mouse
        }

        private void imprimirSegmentos()
        {
           string val="";
           foreach(Segmento seg in segmentos )
           {
               Segmento.DirecaoSegmento sg = seg.getDirecao();
               val = val + Convert.ToString(sg);
           }
           MessageBox.Show(val);         
        }
                
        private void iniciarAquisicao()
        {
            //Inicia a operação quando o evento
            //Botão direito - Down ocorre
            this.adquirindo = true;
            //Limpa os segmentos
            this.segmentos.Clear();
            Point lp = new Point();
            GetCursorPos(ref lp);
            this.xIni = lp.X;
            this.yIni = lp.Y;
            this.ultimoPonto[0] = lp.X;
            this.ultimoPonto[1] = lp.Y;
        }

        private void finalizarAquisicao()
        {
            if (this.adquirindo)
            {
                this.adquirindo = false;
                Point lp = new Point();
                Segmento.reconhecerMovimento(this.segmentos);
                GetCursorPos(ref lp);
                this.xFim = lp.X;
                this.yFim = lp.Y;
                this.deltaX = /*System.Math.Abs*/(this.xFim - xIni);
                this.deltaY = /*System.Math.Abs*/(this.yFim - yIni);
                Segmento.DirecaoSegmento sg;
                //Faz o reconhecimento do segmento
                sg = Segmento.obterDirecao(this.deltaX, this.deltaY);               
            }               
            this.segmentos.Clear();//Limpa a lista de segmentos
        }

        private void verificarMovimento()
        {
            if (this.adquirindo)
            {
                Point lp = new Point();
                GetCursorPos(ref lp);
                //Verifica se o tamanho do segmento é maior do que o minimo
                //if (MouseMoveSegment.obterDistancia(lastPoint, Cursor.Position) >= mouseMoveSegmentLength)
                if (Segmento.obterDistancia(this.ultimoPonto[0], this.ultimoPonto[1], lp.X , lp.Y ) >= tamanhoMinimoSegmento)
                {
                    Segmento segment = new Segmento(this.ultimoPonto[0],lp.X, this.ultimoPonto[1],lp.Y);
                    segmentos.Add(segment);
                    this.ultimoPonto[0] = lp.X;
                    this.ultimoPonto[1] = lp.Y;
                }
            }
        }

        //Implementação do filtro de mensagens
        public bool PreFilterMessage(ref Message m)
        {
            switch (m.Msg)
            {
                case ((int)MessageCode.WM_RBUTTONDOWN):
                    {
                        this.iniciarAquisicao();
                        return true;                    
                    }

                case ((int)MessageCode.WM_RBUTTONUP):
                    {
                        this.finalizarAquisicao();
                        return true;                        
                    }

                case ((int)MessageCode.WM_MOUSEMOVE):
                    {
                        this.verificarMovimento();
                        return true;
                    }  
            }
            return false;         
        }
    }
}
