namespace tcc
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorPal = new System.Windows.Forms.Panel();
            this.penBtn = new System.Windows.Forms.Button();
            this.eraseBtn = new System.Windows.Forms.Button();
            this.yellowPenBtn = new System.Windows.Forms.Button();
            this.redPenBtn = new System.Windows.Forms.Button();
            this.whitePenBtn = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.pausarOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mpModeBtn = new System.Windows.Forms.Button();
            this.pwerPntBtn = new System.Windows.Forms.Button();
            this.browserModeBtn = new System.Windows.Forms.Button();
            this.blackBoardBtn = new System.Windows.Forms.Button();
            this.colorPal.SuspendLayout();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 81);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(893, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(10, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            // 
            // colorPal
            // 
            this.colorPal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.colorPal.Controls.Add(this.penBtn);
            this.colorPal.Controls.Add(this.eraseBtn);
            this.colorPal.Controls.Add(this.yellowPenBtn);
            this.colorPal.Controls.Add(this.redPenBtn);
            this.colorPal.Controls.Add(this.whitePenBtn);
            this.colorPal.Location = new System.Drawing.Point(482, 3);
            this.colorPal.Name = "colorPal";
            this.colorPal.Size = new System.Drawing.Size(405, 79);
            this.colorPal.TabIndex = 4;
            this.colorPal.Visible = false;
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.penBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("penBtn.BackgroundImage")));
            this.penBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.penBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penBtn.ForeColor = System.Drawing.Color.White;
            this.penBtn.Location = new System.Drawing.Point(254, 2);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(71, 73);
            this.penBtn.TabIndex = 4;
            this.penBtn.UseVisualStyleBackColor = false;
            this.penBtn.MouseEnter += new System.EventHandler(this.penBtn_MouseEnter);
            // 
            // eraseBtn
            // 
            this.eraseBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eraseBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraseBtn.BackgroundImage")));
            this.eraseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraseBtn.ForeColor = System.Drawing.Color.White;
            this.eraseBtn.Location = new System.Drawing.Point(331, 2);
            this.eraseBtn.Name = "eraseBtn";
            this.eraseBtn.Size = new System.Drawing.Size(71, 73);
            this.eraseBtn.TabIndex = 3;
            this.eraseBtn.UseVisualStyleBackColor = false;
            this.eraseBtn.MouseEnter += new System.EventHandler(this.eraseBtn_MouseEnter);
            // 
            // yellowPenBtn
            // 
            this.yellowPenBtn.BackColor = System.Drawing.Color.Yellow;
            this.yellowPenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowPenBtn.ForeColor = System.Drawing.Color.White;
            this.yellowPenBtn.Location = new System.Drawing.Point(157, 2);
            this.yellowPenBtn.Name = "yellowPenBtn";
            this.yellowPenBtn.Size = new System.Drawing.Size(71, 73);
            this.yellowPenBtn.TabIndex = 2;
            this.yellowPenBtn.UseVisualStyleBackColor = false;
            this.yellowPenBtn.MouseEnter += new System.EventHandler(this.yellowPenBtn_MouseEnter);
            // 
            // redPenBtn
            // 
            this.redPenBtn.BackColor = System.Drawing.Color.Red;
            this.redPenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redPenBtn.ForeColor = System.Drawing.Color.White;
            this.redPenBtn.Location = new System.Drawing.Point(80, 2);
            this.redPenBtn.Name = "redPenBtn";
            this.redPenBtn.Size = new System.Drawing.Size(71, 73);
            this.redPenBtn.TabIndex = 1;
            this.redPenBtn.UseVisualStyleBackColor = false;
            this.redPenBtn.MouseEnter += new System.EventHandler(this.redPenBtn_MouseEnter);
            // 
            // whitePenBtn
            // 
            this.whitePenBtn.BackColor = System.Drawing.Color.White;
            this.whitePenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.whitePenBtn.ForeColor = System.Drawing.Color.White;
            this.whitePenBtn.Location = new System.Drawing.Point(3, 2);
            this.whitePenBtn.Name = "whitePenBtn";
            this.whitePenBtn.Size = new System.Drawing.Size(71, 73);
            this.whitePenBtn.TabIndex = 0;
            this.whitePenBtn.Text = "button2";
            this.whitePenBtn.UseVisualStyleBackColor = false;
            this.whitePenBtn.MouseEnter += new System.EventHandler(this.whitePenBtn_MouseEnter);
            // 
            // trayIcon
            // 
            this.trayIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.trayIcon.BalloonTipText = "Sistema virtual";
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Aula";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configMenu,
            this.toolStripMenuItem2,
            this.pausarOSistemaToolStripMenuItem,
            this.reiniciarOSistemaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fecharOSistemaToolStripMenuItem});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.trayMenu.Size = new System.Drawing.Size(185, 104);
            // 
            // configMenu
            // 
            this.configMenu.Name = "configMenu";
            this.configMenu.Size = new System.Drawing.Size(184, 22);
            this.configMenu.Text = "Configurar o sistema";
            this.configMenu.Click += new System.EventHandler(this.configMenu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 6);
            // 
            // pausarOSistemaToolStripMenuItem
            // 
            this.pausarOSistemaToolStripMenuItem.Name = "pausarOSistemaToolStripMenuItem";
            this.pausarOSistemaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.pausarOSistemaToolStripMenuItem.Text = "Pausar o sistema";
            this.pausarOSistemaToolStripMenuItem.Click += new System.EventHandler(this.pausarOSistemaToolStripMenuItem_Click);
            // 
            // reiniciarOSistemaToolStripMenuItem
            // 
            this.reiniciarOSistemaToolStripMenuItem.Name = "reiniciarOSistemaToolStripMenuItem";
            this.reiniciarOSistemaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.reiniciarOSistemaToolStripMenuItem.Text = "Reiniciar o sistema";
            this.reiniciarOSistemaToolStripMenuItem.Visible = false;
            this.reiniciarOSistemaToolStripMenuItem.Click += new System.EventHandler(this.reiniciarOSistemaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(181, 6);
            // 
            // fecharOSistemaToolStripMenuItem
            // 
            this.fecharOSistemaToolStripMenuItem.Name = "fecharOSistemaToolStripMenuItem";
            this.fecharOSistemaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.fecharOSistemaToolStripMenuItem.Text = "Fechar o sistema";
            this.fecharOSistemaToolStripMenuItem.Click += new System.EventHandler(this.fecharOSistemaToolStripMenuItem_Click);
            // 
            // mpModeBtn
            // 
            this.mpModeBtn.BackColor = System.Drawing.Color.Black;
            this.mpModeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mpModeBtn.BackgroundImage")));
            this.mpModeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mpModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mpModeBtn.Location = new System.Drawing.Point(96, 1);
            this.mpModeBtn.Name = "mpModeBtn";
            this.mpModeBtn.Size = new System.Drawing.Size(88, 81);
            this.mpModeBtn.TabIndex = 5;
            this.mpModeBtn.UseVisualStyleBackColor = false;
            this.mpModeBtn.MouseEnter += new System.EventHandler(this.mpModeBtn_MouseEnter);
            // 
            // pwerPntBtn
            // 
            this.pwerPntBtn.BackColor = System.Drawing.Color.Black;
            this.pwerPntBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pwerPntBtn.BackgroundImage")));
            this.pwerPntBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwerPntBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pwerPntBtn.Location = new System.Drawing.Point(190, 1);
            this.pwerPntBtn.Name = "pwerPntBtn";
            this.pwerPntBtn.Size = new System.Drawing.Size(88, 81);
            this.pwerPntBtn.TabIndex = 6;
            this.pwerPntBtn.UseVisualStyleBackColor = false;
            this.pwerPntBtn.MouseEnter += new System.EventHandler(this.pwerPntBtn_MouseEnter);
            // 
            // browserModeBtn
            // 
            this.browserModeBtn.BackColor = System.Drawing.Color.Black;
            this.browserModeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browserModeBtn.BackgroundImage")));
            this.browserModeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browserModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browserModeBtn.Location = new System.Drawing.Point(284, 3);
            this.browserModeBtn.Name = "browserModeBtn";
            this.browserModeBtn.Size = new System.Drawing.Size(88, 81);
            this.browserModeBtn.TabIndex = 7;
            this.browserModeBtn.UseVisualStyleBackColor = false;
            this.browserModeBtn.MouseEnter += new System.EventHandler(this.browserModeBtn_MouseEnter);
            // 
            // blackBoardBtn
            // 
            this.blackBoardBtn.BackColor = System.Drawing.Color.Black;
            this.blackBoardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("blackBoardBtn.BackgroundImage")));
            this.blackBoardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blackBoardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blackBoardBtn.Location = new System.Drawing.Point(378, 3);
            this.blackBoardBtn.Name = "blackBoardBtn";
            this.blackBoardBtn.Size = new System.Drawing.Size(88, 81);
            this.blackBoardBtn.TabIndex = 8;
            this.blackBoardBtn.UseVisualStyleBackColor = false;
            this.blackBoardBtn.MouseEnter += new System.EventHandler(this.blackBoardBtn_MouseEnter);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(1202, 85);
            this.Controls.Add(this.blackBoardBtn);
            this.Controls.Add(this.browserModeBtn);
            this.Controls.Add(this.colorPal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pwerPntBtn);
            this.Controls.Add(this.mpModeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.colorPal.ResumeLayout(false);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel colorPal;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem configMenu;
        private System.Windows.Forms.ToolStripMenuItem pausarOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fecharOSistemaToolStripMenuItem;
        private System.Windows.Forms.Button mpModeBtn;
        private System.Windows.Forms.Button pwerPntBtn;
        private System.Windows.Forms.Button browserModeBtn;
        private System.Windows.Forms.Button blackBoardBtn;
        private System.Windows.Forms.Button redPenBtn;
        private System.Windows.Forms.Button whitePenBtn;
        private System.Windows.Forms.Button yellowPenBtn;
        private System.Windows.Forms.Button eraseBtn;
        private System.Windows.Forms.Button penBtn;
    }
}

