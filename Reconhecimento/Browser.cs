using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsInput;

namespace tcc
{
    public static class Browser
    {
        public static void executarComandoBrowser(string cmd)
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
                abrirHome ();
            }
            if (cmd == "LEFT")
            {
                voltarPagina();
            }
            if (cmd == "RIGHT")
            {
                avancarPagina();
            }
            if (cmd == "UPDOWN")
            {
                abrirFavoritos ();
            }
            if (cmd == "DOWNUP")
            {
                pesquisar ();
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
        private static void avancarPagina()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\navigation-right.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BROWSER_FORWARD);
        }

        private static void voltarPagina()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\navigation-left.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BROWSER_BACK);
        }

        private static void abrirHome()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\home.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BROWSER_HOME);
        }

        private static void abrirFavoritos()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\heart.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BROWSER_FAVORITES);
        }

        private static void pesquisar()
        {
            MessageForm frm = new MessageForm("img\\basic\\blue\\search.png", true);
            frm.Show();
            InputSimulator.SimulateKeyPress(VirtualKeyCode.BROWSER_SEARCH);
        }

    }
}
