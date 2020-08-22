using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
namespace tcc
{
    public static class BlackBoard
    {
        private static bool isPen = false;
        public static void executarComandoPowerPoint(string cmd)
        {

            if (cmd == "LEFTUP")
            {
                aumentarVolume();
            }
            if (cmd == "LEFTDOWN")
            {
                abaixarVolume();
            }
            if (cmd == "DOWNRIGHTUP")
            {
                play();
            }
            if (cmd == "LEFT")
            {
                voltarSlide();
            }
            if (cmd == "RIGHT")
            {
                avancarSlide();
            }
            if (cmd == "DOWNUP")
            {
                selecionar();
            }
            if (cmd == "RIGHTLEFTRIGHT")
            {
                if (!isPen)
                {
                    isPen = true;
                    selecionarPincel();
                }
                else
                {
                    isPen = false;
                }

            }
        }

        private static void abrirEmail()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\mail.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.LAUNCH_MAIL);
        }

        private static void aumentarVolume()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\speaker.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_UP);
        }

        private static void abaixarVolume()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\speaker.png", true);
            frm.Show();
        }

        private static void avancarSlide()
        {
            //MessageForm frm = new MessageForm("img\\basic\\blue\\button-ff.png", true);
            //frm.Show();
            //Principal.ppt.Presentations[1].SlideShowWindow.View.PointerColor.RGB = System.Drawing.Color.Brown.ToArgb();
            //Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = PpSlideShowPointerType.ppSlideShowPointerPen;
        }

        private static void selecionarCursor()
        {
            Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = PpSlideShowPointerType.ppSlideShowPointerArrow;        
        }
        
        private static void selecionarPincel()
        {
            MessageForm frm = new MessageForm("img\\pen.png", true);
            frm.Show();
            Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = PpSlideShowPointerType.ppSlideShowPointerPen;
        }
        private static void play()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\presentation.png", true);
            frm.Show();
            try
            {
                Principal.ppt.Activate();
                Principal.ppt.Presentations.Open("c:\\tcc\\black_board.ppt", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);
                Principal.ppt.Presentations[1].SlideShowSettings.Run();
            }
            catch (Exception ex)
            {
                Auxiliar.mostrarErro(ex.Message);
            }
        }

        private static void voltarSlide()
        {
            //MessageForm frm = new MessageForm("img\\basic\\blue\\button-rew.png", true);
            //frm.Show();
            //Principal.ppt.Presentations[1].SlideShowWindow.View.PointerColor.RGB = System.Drawing.Color.White.ToArgb();
            //Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = PpSlideShowPointerType.ppSlideShowPointerPen;
        }

        private static void selecionar()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\music.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
        }
    }
}
