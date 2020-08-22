using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tcc
{
    public partial class MacroRecorder : Form
    {
        public MacroRecorder()
        {
            InitializeComponent();
        }
        private void popularComboDeComandos()
        {
            this.controlesCombo.Items.Add("Abrir powerpoint");
        
        }

        private void MacroRecorder_Load(object sender, EventArgs e)
        {

        }
    }
}
