using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace tcc
{
    public class FiltroDeMensagens
    {
         //Guarda os segmentos obtidos
        private List<Segmento> segmentos = new List<Segmento>();
        //Seta o status atual
        private bool adquirindo;
        //Variaveis onde são guardados os valores
        private int xIni, yIni;
     
        //Vetor que guarda o último ponto lido(x,y)
        private int[] ultimoPonto = new int[2];
        
        public void iniciarAquisicao(int x, int y)
        {
            //Inicia a operação quando o evento
            //Botão direito - Down ocorre
            this.adquirindo = true;
            //Limpa os segmentos
            this.segmentos.Clear();
            Point lp = new Point();
            this.xIni = x;
            this.yIni = y;
            this.ultimoPonto[0] = lp.X;
            this.ultimoPonto[1] = lp.Y;
        }

        public void finalizarAquisicao()
        {
            if (this.adquirindo)
            {
                this.adquirindo = false;              
                Segmento.reconhecerMovimento(this.segmentos);          
            }               
            this.segmentos.Clear();//Limpa a lista de segmentos
        }

        public void verificarMovimento(int x, int y)
        {
            if (this.adquirindo)
            {   
                //Verifica se o tamanho do segmento é maior do que o minimo

                //A divisão por 5 e um fator na verificação do tamanho
                double tam = (Segmento.obterDistancia(this.ultimoPonto[0], this.ultimoPonto[1], x, y)) / 5;
                if (tam >= (Convert.ToDouble (Properties.Settings.Default.tam_segmento)))//    tamanhoMinimoSegmento)
                {                   
                    Segmento segment = new Segmento(this.ultimoPonto[0],x, this.ultimoPonto[1],y);
                    segmentos.Add(segment);
                    this.ultimoPonto[0] = x;
                    this.ultimoPonto[1] = y;
                }
            }
        }

    }
}

