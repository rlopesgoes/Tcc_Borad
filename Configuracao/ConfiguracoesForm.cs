using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tcc
{
    public partial class ConfiguracoesForm : Form
    {
        public ConfiguracoesForm()
        {
            InitializeComponent();
        }

        private void lerConfiguracoes()
        {
            try
            {
                this.tamUp.Value = Convert.ToInt32(Properties.Settings.Default.tam_segmento);
            }
            catch
            {
                MessageBox.Show("O valor ainda não foi setado...");
            }
        }

        private void salvarArquivo()
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("conf.cfg");
            sw.WriteLine("largura=" + this.widthTxt.Text);
            sw.WriteLine("altura=" + this.heigthTxt.Text);
            sw.Flush();
            sw.Close();

        }

        private void salvarConfig()
        {
            Properties.Settings.Default.tam_segmento = Convert.ToString(this.tamUp.Value);//Salva o tamanho do segmento 
            Properties.Settings.Default.max_angulo  = Convert.ToString(this.maxAngUp.Value);//Salva o tamanho do segmento 
            Properties.Settings.Default.Save();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.widthTxt.Text = Convert.ToString(w);
            this.heigthTxt.Text = Convert.ToString(h);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.salvarArquivo();
            this.salvarConfig();
            MessageBox.Show("Arquivo salvo...");
            this.Close();
        }

        private void ConfiguracoesForm_Load(object sender, EventArgs e)
        {
            this.lerConfiguracoes();
        }

        private void ConfiguracoesForm_Load_1(object sender, EventArgs e)
        {
        //    this.lerConfiguracoes();
        }
    }
}
