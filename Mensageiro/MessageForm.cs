using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tcc
{
    public partial class MessageForm : Form
    {
        Timer tmr = new Timer();
        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(string message)
        {
            InitializeComponent();
            this.tmr.Tick += new EventHandler(tmr_Tick);
            this.tmr.Interval = 2000;
            this.tmr.Enabled = true;
            this.imageBox.Visible = false;
            this.label1.Text = message; 
        }
        public MessageForm(string message, bool isImage)
        {
            InitializeComponent();
            this.tmr.Tick += new EventHandler(tmr_Tick);
            this.tmr.Interval = 2000;
            this.tmr.Enabled = true;
            this.label1.Visible = false;
            this.imageBox.Image = new Bitmap(message);
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            this.tmr.Enabled = false;
            this.Close();
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
