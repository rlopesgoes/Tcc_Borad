namespace tcc
{
    partial class ConfiguracoesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracoesForm));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.saveBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.Largura = new System.Windows.Forms.Label();
            this.heigthTxt = new System.Windows.Forms.TextBox();
            this.widthTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maxAngUp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tamUp = new System.Windows.Forms.NumericUpDown();
            this.toolbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAngUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamUp)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveBtn});
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(455, 25);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolStrip1";
            // 
            // saveBtn
            // 
            this.saveBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveBtn.Image")));
            this.saveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(58, 22);
            this.saveBtn.Text = "Salvar";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Largura);
            this.groupBox1.Controls.Add(this.heigthTxt);
            this.groupBox1.Controls.Add(this.widthTxt);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resolução da tela";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(78, 80);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(95, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Obter do sistema...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Altura";
            // 
            // Largura
            // 
            this.Largura.AutoSize = true;
            this.Largura.Location = new System.Drawing.Point(24, 34);
            this.Largura.Name = "Largura";
            this.Largura.Size = new System.Drawing.Size(43, 13);
            this.Largura.TabIndex = 2;
            this.Largura.Text = "Largura";
            // 
            // heigthTxt
            // 
            this.heigthTxt.Location = new System.Drawing.Point(73, 57);
            this.heigthTxt.Name = "heigthTxt";
            this.heigthTxt.Size = new System.Drawing.Size(100, 20);
            this.heigthTxt.TabIndex = 1;
            // 
            // widthTxt
            // 
            this.widthTxt.Location = new System.Drawing.Point(73, 31);
            this.widthTxt.Name = "widthTxt";
            this.widthTxt.Size = new System.Drawing.Size(100, 20);
            this.widthTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.maxAngUp);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tamUp);
            this.groupBox2.Location = new System.Drawing.Point(207, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reconhecimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Erro máximo em graus";
            // 
            // maxAngUp
            // 
            this.maxAngUp.Location = new System.Drawing.Point(171, 61);
            this.maxAngUp.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.maxAngUp.Name = "maxAngUp";
            this.maxAngUp.Size = new System.Drawing.Size(59, 20);
            this.maxAngUp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho minimo do segmento";
            // 
            // tamUp
            // 
            this.tamUp.Location = new System.Drawing.Point(171, 36);
            this.tamUp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tamUp.Name = "tamUp";
            this.tamUp.Size = new System.Drawing.Size(59, 20);
            this.tamUp.TabIndex = 0;
            // 
            // ConfiguracoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 148);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracoesForm";
            this.ShowInTaskbar = false;
            this.Text = "Configurações do sistema";
            this.Load += new System.EventHandler(this.ConfiguracoesForm_Load_1);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxAngUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton saveBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Largura;
        private System.Windows.Forms.TextBox heigthTxt;
        private System.Windows.Forms.TextBox widthTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tamUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown maxAngUp;
    }
}