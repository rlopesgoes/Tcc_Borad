using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput;

namespace tcc
{
    public static class MediaPlayer
    {
         public static void executarComandoMediaPlayer(string cmd)
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
                voltarMusica();
            }
            if (cmd == "RIGHT")
            {
                avancarMusica();
            }

            if (cmd == "DOWNUP")
            {
                selecionar();
            }


            if (cmd == "RIGHTLEFTRIGHT")
            {
               abrirEmail();
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
             InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_DOWN);
         }
         private static void avancarMusica()
         {
             MessageForm frm = new MessageForm("img\\basic\\blue\\button-ff.png", true);
             frm.Show();
             InputSimulator.SimulateKeyPress(VirtualKeyCode.MEDIA_NEXT_TRACK);
         }

         private static void play()
         {
             MessageForm frm = new MessageForm("img\\basic\\blue\\button-play.png", true);
             frm.Show();
             InputSimulator.SimulateKeyPress(VirtualKeyCode.MEDIA_PLAY_PAUSE);
         }

         private static void voltarMusica()
         {
             MessageForm frm = new MessageForm("img\\basic\\blue\\button-rew.png", true);
             frm.Show();
             InputSimulator.SimulateKeyPress(VirtualKeyCode.MEDIA_PREV_TRACK);
         }

         private static void selecionar()
         {
             MessageForm frm = new MessageForm("img\\basic\\blue\\music.png", true);
             frm.Show();
             InputSimulator.SimulateKeyPress(VirtualKeyCode.LAUNCH_MEDIA_SELECT);
         }

    }
}
