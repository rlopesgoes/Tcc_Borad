using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

/*********************************************************************
 *          PROGRAMA PARA RECONHECIMENTO DE GESTOS COM MOUSE
 * 
 * AUTOR: RICARDO LOPES DE GÓES 
 * PROJETO: TCC FEI 2011
 * TODO: MELHORAR SISTEMA DE RECONHECIMENTO
 *       VER SE O CALCULO ESTA SENDO REALIZADO CORRETAMENTE
 * ********************************************************************/
namespace tcc
{
    public class Segmento
    {
        private DirecaoSegmento _direcao;  
     
        public enum DirecaoSegmento
        {
            UNK,
            LEFT,
            RIGHT,
            UP,
            DOWN
        };

        //Direção do movimento
        public DirecaoSegmento getDirecao()
        {
            return this._direcao;
        }

        public static void reconhecerMovimento(List<Segmento> segmentos)
        {
            List<DirecaoSegmento> sg = new List<DirecaoSegmento>();
            string val="";
            int i;
            i = 0;
            foreach(Segmento s in segmentos)
            {
                    if (s.getDirecao() != DirecaoSegmento.UNK)
                    {
                        if (sg.Count < 1)
                        {
                            sg.Add(s.getDirecao());
                            i++;
                        }
                        else
                        {
                            if (sg[i - 1] != s.getDirecao())
                            {
                                sg.Add(s.getDirecao());//Impede repetição do movimento seguida
                                i++;
                            }
                        }                       
                    }                
            }

            foreach (DirecaoSegmento sd in sg)
            {
                val = val + Convert.ToString(sd);
            }
            //MessageBox.Show(val);
            Comando cmd = new Comando();
            cmd.executarComando(val); 
        }

        public static double obterDistancia(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static double obterDistancia(int x1, int x2, int y1, int y2)
        {
            int dx = x2 - x1;
            int dy = y2- y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        public static DirecaoSegmento obterDirecao(int deltaX, int deltaY)
        {
            double erroMaximoAngulo;
            try
            {
                erroMaximoAngulo = Convert.ToDouble(Properties.Settings.Default.max_angulo);
            }
            catch
            {
                 erroMaximoAngulo = 30;
               // MessageBox.Show("O ângulo de erro máximo não foi setado. Utilizando 30° por default...", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Calcula a hipotenusa
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            //Calcula o seno e cosseno
            double sin = deltaX / length;
            double cos = deltaY / length;
            
            //Calcula o angulo
            double angulo = Math.Asin(Math.Abs(sin)) * 180 / Math.PI;
            //Coloca os valores no quadrante
            if ((sin >= 0) && (cos < 0))
                angulo = 180 - angulo;
            else if ((sin < 0) && (cos < 0))
                angulo = angulo + 180;
            else if ((sin < 0) && (cos >= 0))
                angulo = 360 - angulo;

            //RECONHECIMENTO DA DIREÇÃO
            if ((angulo > 360 - erroMaximoAngulo) || (angulo < 0 + erroMaximoAngulo))
                return DirecaoSegmento.DOWN;
            else if ((angulo > 90 - erroMaximoAngulo) && (angulo < 90 + erroMaximoAngulo))
                return DirecaoSegmento.RIGHT;
            else if ((angulo > 180 - erroMaximoAngulo) && (angulo < 180 + erroMaximoAngulo))
                return DirecaoSegmento.UP ;
            else if ((angulo > 270 - erroMaximoAngulo) && (angulo < 270 + erroMaximoAngulo))
                return DirecaoSegmento.LEFT ;
            else return DirecaoSegmento.UNK;
        }
          
        public Segmento(Point p1, Point p2)
        {
            this._direcao  = obterDirecao(p2.X - p1.X, p1.Y - p2.Y);
        }

        public Segmento(int x1, int x2,int y1, int y2)
        {
            this._direcao = obterDirecao(x2-x1, y2-y1);
        }
    }
}
