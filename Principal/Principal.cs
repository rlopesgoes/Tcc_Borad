using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Diagnostics;
using System.Runtime.InteropServices;
//using Microsoft.Office.Interop.PowerPoint;


namespace tcc
{
    public partial class Principal : Form
    {
        public static Microsoft.Office.Interop.PowerPoint.ApplicationClass ppt;
        private bool menuExpandido;

        private Timer timerClose;
   
        #region "Captura do mouse"

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        private static bool inCapture;
        private static FiltroDeMensagens filtro;
        private static NotifyIcon nf;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                inCapture = true;
                filtro = new FiltroDeMensagens();
                filtro.iniciarAquisicao(hookStruct.pt.x, hookStruct.pt.y);
                System.Drawing.Icon ic = new Icon("img\\operando.ico");
                nf.Icon = ic;                
            }

            if (nCode >= 0 && MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam && inCapture )
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                filtro.verificarMovimento(hookStruct.pt.x, hookStruct.pt.y);
            }

            if (nCode >= 0 && MouseMessages.WM_LBUTTONUP == (MouseMessages)wParam && inCapture)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                inCapture = false;              
                filtro.finalizarAquisicao ();//hookStruct.pt.x, hookStruct.pt.y);
                System.Drawing.Icon ic = new Icon("img\\play.ico");
                nf.Icon = ic;                
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        private const int WH_MOUSE_LL = 14;
        
        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion

        private int _modoAtual; //Inteiro que define o modo atual de operação. 0 - iniciado
                                // 1 - parado
        public Principal()
        {
            InitializeComponent();
            nf = this.trayIcon;
            _hookID = SetHook(_proc);
           // Slide sl = new Slide();
           // ppt = new Microsoft.Office.Interop.PowerPoint.ApplicationClass();
           //// ppt.Activate();
            Auxiliar.modoDeOperacao = Auxiliar.ModoDeOperacao.UNK ;
        }

        public void reiniciarOperacao()
        {
            this._modoAtual = 0;
            System.Windows.Forms.Application.Restart();
        }

        public void pausarOperacao()
        {
            this._modoAtual = 1;
            this.reiniciarOSistemaToolStripMenuItem.Visible = true;
            this.pausarOSistemaToolStripMenuItem.Visible = false;
            System.Drawing.Icon ic = new Icon("pause.ico");
            this.trayIcon.Icon = ic;
            UnhookWindowsHookEx(_hookID);   
        }

        #region "diversas"
        private void desenharLinha(Point inicio, Point fim)
        {           
            Graphics g = this.colorPal.CreateGraphics();       
            //g.DrawLine(new Pen(Color.Red, 2), new Point(10,10), new Point(400, 450));          
            g.DrawLine(new Pen(Color.Red, 2), inicio, fim);          
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  this.Width = 273;
            int c = Screen.PrimaryScreen.BitsPerPixel;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;           
            this.scroll(w,0);
        }

        /// <summary>
        /// Efeito de scroll 
        /// </summary>
        /// <param name="valor">Largura do form</param>
        /// <param name="op">Tipo da operação. 0->Aumentar; 1->diminuir</param>
        private void scroll(int valor, int op)
        {
            if(op ==0)
            while (this.Width < valor)           
                this.Width = this.Width + 1;
            else
                while (this.Width > valor)
                    this.Width = this.Width -  1;         
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            if (!this.menuExpandido)
            {
                //this.Width = this.Width * 2;
                int c = Screen.PrimaryScreen.BitsPerPixel;
                int w = Screen.PrimaryScreen.Bounds.Width;
                int h = Screen.PrimaryScreen.Bounds.Height;
                this.menuExpandido = true;

                this.scroll(w, 0);
            }
            else {
                this.scroll(91, 1);
                this.menuExpandido = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this. ppt = new ApplicationClass();
            //this.isPowerPoint = true;
            //this.powerPointPanel.Visible = true;
            //ppt.Activate(); 
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            //this.Width = 14;
            this.scroll(91, 1);
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            int c = Screen.PrimaryScreen.BitsPerPixel;
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Width = 92;
            this.Height = 85;
            this.SetDesktopBounds(0, h - this.Height, this.Width, this.Height);
            this.TopMost = true;
        }


        private void button8_Click(object sender, EventArgs e)
        {
//this.desenharLinha(this.start, this.end );
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            ////this.desenharLinha(this.start, this.end);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ConfiguracoesForm frm = new ConfiguracoesForm();
            frm.ShowDialog();
        }

        private void trayIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                this.trayMenu.Show(); 
        }

        private void configMenu_Click(object sender, EventArgs e)
        {
            ConfiguracoesForm frm = new ConfiguracoesForm();
            frm.ShowDialog();
        }

        private void pausarOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pausarOperacao();
        }

        private void fecharOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reiniciarOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reiniciarOperacao();
        }

        private void mpModeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.mpModeBtn.BackColor = Color.Coral;
            this.pwerPntBtn.BackColor = Color.Black;
            this.browserModeBtn.BackColor = Color.Black;
            Auxiliar.modoDeOperacao = Auxiliar.ModoDeOperacao.MEDIAPLAYER;
            this.colorPal.Visible = false;
            MessageForm frm = new MessageForm("Media Player Mode");
            frm.Show();
        }

        private void pwerPntBtn_MouseEnter(object sender, EventArgs e)
        {
            this.mpModeBtn.BackColor = Color.Black;
            this.pwerPntBtn.BackColor = Color.Coral;
            this.browserModeBtn.BackColor = Color.Black;
            Auxiliar.modoDeOperacao = Auxiliar.ModoDeOperacao.POWERPOINT;
            this.colorPal.Visible = false;
            MessageForm frm = new MessageForm("Presentation Mode");
            Principal.ppt = new Microsoft.Office.Interop.PowerPoint.ApplicationClass();
            frm.Show();
        }

        private void browserModeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.mpModeBtn.BackColor = Color.Black;
            this.pwerPntBtn.BackColor = Color.Black;
            this.browserModeBtn.BackColor = Color.Coral;
            Auxiliar.modoDeOperacao = Auxiliar.ModoDeOperacao.BROWSER;
            this.colorPal.Visible = false;
            MessageForm frm = new MessageForm("Browser Mode");
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Slide ppt = new Slide();
            ppt.iniciarPowerPoint();
        }

        private void blackBoardBtn_MouseEnter(object sender, EventArgs e)
        {
            this.mpModeBtn.BackColor = Color.Black;
            this.blackBoardBtn.BackColor = Color.Coral;
            this.browserModeBtn.BackColor = Color.Black;
            this.pwerPntBtn.BackColor = Color.Black;
            Auxiliar.modoDeOperacao = Auxiliar.ModoDeOperacao.BLACKBOARD ;
            this.colorPal.Visible = true;
            MessageForm frm = new MessageForm("BlackBoard Mode");
            Principal.ppt = new Microsoft.Office.Interop.PowerPoint.ApplicationClass();
            frm.Show();

        }

        #region "Paleta de cores"

        private void whitePenBtn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerColor.RGB = System.Drawing.Color.White.ToArgb();
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = Microsoft.Office.Interop.PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen;
            }
            catch { }
        }

        private void redPenBtn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerColor.RGB = System.Drawing.Color.Red.ToArgb();
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = Microsoft.Office.Interop.PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen;
            }
            catch { }
        }

        private void yellowPenBtn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerColor.RGB = System.Drawing.Color.Yellow.ToArgb();
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = Microsoft.Office.Interop.PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen;
            }
            catch { }
        }

        #endregion

        private void eraseBtn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Principal.ppt.Presentations[1].SlideShowWindow.View.EraseDrawing();
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = Microsoft.Office.Interop.PowerPoint.PpSlideShowPointerType.ppSlideShowPointerEraser;
            }
            catch { }
        }

        private void penBtn_MouseEnter(object sender, EventArgs e)
        {
            try
            {
                Principal.ppt.Presentations[1].SlideShowWindow.View.PointerType = Microsoft.Office.Interop.PowerPoint.PpSlideShowPointerType.ppSlideShowPointerPen;
            }
            catch { }
        }

    }
}
