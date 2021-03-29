using System.Drawing;

namespace qUsage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnMenu4 = new System.Windows.Forms.Button();
            this.btnMenuSettings = new System.Windows.Forms.Button();
            this.btnMenu3 = new System.Windows.Forms.Button();
            this.btnMenuTasks = new System.Windows.Forms.Button();
            this.btnMenu1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.nfyIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.nfyIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (24)))), ((int) (((byte) (30)))), ((int) (((byte) (54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnMenu4);
            this.panel1.Controls.Add(this.btnMenuSettings);
            this.panel1.Controls.Add(this.btnMenu3);
            this.panel1.Controls.Add(this.btnMenuTasks);
            this.panel1.Controls.Add(this.btnMenu1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 600);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 193);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 2;
            // 
            // btnMenu4
            // 
            this.btnMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu4.FlatAppearance.BorderSize = 0;
            this.btnMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMenu4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.btnMenu4.Image = ((System.Drawing.Image) (resources.GetObject("btnMenu4.Image")));
            this.btnMenu4.Location = new System.Drawing.Point(0, 294);
            this.btnMenu4.Name = "btnMenu4";
            this.btnMenu4.Size = new System.Drawing.Size(186, 42);
            this.btnMenu4.TabIndex = 4;
            this.btnMenu4.Text = "Dashboard";
            this.btnMenu4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu4.UseVisualStyleBackColor = true;
            this.btnMenu4.Leave += new System.EventHandler(this.ResetBackColor);
            this.btnMenu4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenu4_MouseUp);
            // 
            // btnMenuSettings
            // 
            this.btnMenuSettings.FlatAppearance.BorderSize = 0;
            this.btnMenuSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuSettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMenuSettings.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.btnMenuSettings.Image = ((System.Drawing.Image) (resources.GetObject("btnMenuSettings.Image")));
            this.btnMenuSettings.Location = new System.Drawing.Point(0, 535);
            this.btnMenuSettings.Name = "btnMenuSettings";
            this.btnMenuSettings.Size = new System.Drawing.Size(186, 42);
            this.btnMenuSettings.TabIndex = 5;
            this.btnMenuSettings.Text = "Settings";
            this.btnMenuSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenuSettings.UseVisualStyleBackColor = true;
            this.btnMenuSettings.Leave += new System.EventHandler(this.ResetBackColor);
            this.btnMenuSettings.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenuSettings_MouseUp);
            // 
            // btnMenu3
            // 
            this.btnMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu3.FlatAppearance.BorderSize = 0;
            this.btnMenu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMenu3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.btnMenu3.Image = ((System.Drawing.Image) (resources.GetObject("btnMenu3.Image")));
            this.btnMenu3.Location = new System.Drawing.Point(0, 252);
            this.btnMenu3.Name = "btnMenu3";
            this.btnMenu3.Size = new System.Drawing.Size(186, 42);
            this.btnMenu3.TabIndex = 3;
            this.btnMenu3.Text = "Dashboard";
            this.btnMenu3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu3.UseVisualStyleBackColor = true;
            this.btnMenu3.Leave += new System.EventHandler(this.ResetBackColor);
            this.btnMenu3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenu3_MouseUp);
            // 
            // btnMenuTasks
            // 
            this.btnMenuTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuTasks.FlatAppearance.BorderSize = 0;
            this.btnMenuTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTasks.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMenuTasks.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.btnMenuTasks.Image = ((System.Drawing.Image) (resources.GetObject("btnMenuTasks.Image")));
            this.btnMenuTasks.Location = new System.Drawing.Point(0, 210);
            this.btnMenuTasks.Name = "btnMenuTasks";
            this.btnMenuTasks.Size = new System.Drawing.Size(186, 42);
            this.btnMenuTasks.TabIndex = 2;
            this.btnMenuTasks.Text = "Tasks";
            this.btnMenuTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenuTasks.UseVisualStyleBackColor = true;
            this.btnMenuTasks.Leave += new System.EventHandler(this.ResetBackColor);
            this.btnMenuTasks.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenuTasks_MouseUp);
            // 
            // btnMenu1
            // 
            this.btnMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu1.FlatAppearance.BorderSize = 0;
            this.btnMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMenu1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.btnMenu1.Image = ((System.Drawing.Image) (resources.GetObject("btnMenu1.Image")));
            this.btnMenu1.Location = new System.Drawing.Point(0, 168);
            this.btnMenu1.Name = "btnMenu1";
            this.btnMenu1.Size = new System.Drawing.Size(186, 42);
            this.btnMenu1.TabIndex = 1;
            this.btnMenu1.Text = "Dashboard";
            this.btnMenu1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMenu1.UseVisualStyleBackColor = true;
            this.btnMenu1.Leave += new System.EventHandler(this.ResetBackColor);
            this.btnMenu1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMenu1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 168);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (158)))), ((int) (((byte) (161)))), ((int) (((byte) (178)))));
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Some text here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (126)))), ((int) (((byte) (249)))));
            this.label1.Location = new System.Drawing.Point(49, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (158)))), ((int) (((byte) (161)))), ((int) (((byte) (176)))));
            this.labelTitle.Location = new System.Drawing.Point(200, 17);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(74, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (74)))), ((int) (((byte) (79)))), ((int) (((byte) (99)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (200)))), ((int) (((byte) (200)))), ((int) (((byte) (200)))));
            this.textBox1.Location = new System.Drawing.Point(570, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 25);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Serch here";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(914, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.HideToTray);
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(186, 70);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(814, 530);
            this.panelFormLoader.TabIndex = 4;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "I\'m still running in the Background.\r\nDouble click or right click the tray icon\r\n" + "for more options.";
            this.notifyIcon.BalloonTipTitle = "qUsage";
            this.notifyIcon.ContextMenuStrip = this.nfyIconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon) (resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Text";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OpenFromTray);
            // 
            // nfyIconContextMenu
            // 
            this.nfyIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exitToolStripMenuItem});
            this.nfyIconContextMenu.Name = "nfyIconContextMenu";
            this.nfyIconContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.nfyIconContextMenu.ShowImageMargin = false;
            this.nfyIconContextMenu.Size = new System.Drawing.Size(69, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (46)))), ((int) (((byte) (51)))), ((int) (((byte) (73)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.nfyIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ContextMenuStrip nfyIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

        private System.Windows.Forms.NotifyIcon notifyIcon;

        private System.Windows.Forms.Panel panelFormLoader;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label labelTitle;

        private System.Windows.Forms.Panel pnlNav;

        private System.Windows.Forms.Button btnMenuTasks;
        private System.Windows.Forms.Button btnMenu3;
        private System.Windows.Forms.Button btnMenu4;
        private System.Windows.Forms.Button btnMenuSettings;

        private System.Windows.Forms.Button btnMenu1;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;
        
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}
