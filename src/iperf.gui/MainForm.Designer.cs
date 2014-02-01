namespace Iperf.Gui
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._serverModeTabPage = new System.Windows.Forms.TabPage();
            this._serverOutputTextBox = new System.Windows.Forms.TextBox();
            this._serverSettingsPanel = new System.Windows.Forms.Panel();
            this._serverPortCheckBox = new System.Windows.Forms.CheckBox();
            this._serverPortTextBox = new System.Windows.Forms.TextBox();
            this._serverWindowComboBox = new System.Windows.Forms.ComboBox();
            this._serverWindowCheckBox = new System.Windows.Forms.CheckBox();
            this._serverWindowTextBox = new System.Windows.Forms.TextBox();
            this._startServerButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._clientOutputTextBox = new System.Windows.Forms.TextBox();
            this._clientSettingsPanel = new System.Windows.Forms.Panel();
            this._clientWindowComboBox = new System.Windows.Forms.ComboBox();
            this._clientWindowCheckBox = new System.Windows.Forms.CheckBox();
            this._clientWindowTextBox = new System.Windows.Forms.TextBox();
            this._clientPortCheckBox = new System.Windows.Forms.CheckBox();
            this._clientPortTextBox = new System.Windows.Forms.TextBox();
            this._clientAddressCheckBox = new System.Windows.Forms.CheckBox();
            this._clientAddressTextBox = new System.Windows.Forms.TextBox();
            this._startClientButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this._serverModeTabPage.SuspendLayout();
            this._serverSettingsPanel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this._clientSettingsPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this._serverModeTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(487, 497);
            this.tabControl1.TabIndex = 0;
            // 
            // _serverModeTabPage
            // 
            this._serverModeTabPage.Controls.Add(this._serverOutputTextBox);
            this._serverModeTabPage.Controls.Add(this._serverSettingsPanel);
            this._serverModeTabPage.Controls.Add(this._startServerButton);
            this._serverModeTabPage.Location = new System.Drawing.Point(4, 25);
            this._serverModeTabPage.Name = "_serverModeTabPage";
            this._serverModeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this._serverModeTabPage.Size = new System.Drawing.Size(479, 468);
            this._serverModeTabPage.TabIndex = 0;
            this._serverModeTabPage.Text = "Server-Mode";
            this._serverModeTabPage.UseVisualStyleBackColor = true;
            // 
            // _serverOutputTextBox
            // 
            this._serverOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._serverOutputTextBox.Location = new System.Drawing.Point(0, 176);
            this._serverOutputTextBox.Multiline = true;
            this._serverOutputTextBox.Name = "_serverOutputTextBox";
            this._serverOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._serverOutputTextBox.Size = new System.Drawing.Size(479, 292);
            this._serverOutputTextBox.TabIndex = 6;
            // 
            // _serverSettingsPanel
            // 
            this._serverSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._serverSettingsPanel.Controls.Add(this._serverPortCheckBox);
            this._serverSettingsPanel.Controls.Add(this._serverPortTextBox);
            this._serverSettingsPanel.Controls.Add(this._serverWindowComboBox);
            this._serverSettingsPanel.Controls.Add(this._serverWindowCheckBox);
            this._serverSettingsPanel.Controls.Add(this._serverWindowTextBox);
            this._serverSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this._serverSettingsPanel.Name = "_serverSettingsPanel";
            this._serverSettingsPanel.Size = new System.Drawing.Size(479, 129);
            this._serverSettingsPanel.TabIndex = 4;
            // 
            // _serverPortCheckBox
            // 
            this._serverPortCheckBox.AutoSize = true;
            this._serverPortCheckBox.Location = new System.Drawing.Point(10, 22);
            this._serverPortCheckBox.Name = "_serverPortCheckBox";
            this._serverPortCheckBox.Size = new System.Drawing.Size(60, 21);
            this._serverPortCheckBox.TabIndex = 4;
            this._serverPortCheckBox.Text = "Port:";
            this._serverPortCheckBox.UseVisualStyleBackColor = true;
            this._serverPortCheckBox.CheckedChanged += new System.EventHandler(this.ServerPortCheckBox_CheckedChanged);
            // 
            // _serverPortTextBox
            // 
            this._serverPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._serverPortTextBox.Enabled = false;
            this._serverPortTextBox.Location = new System.Drawing.Point(130, 20);
            this._serverPortTextBox.Name = "_serverPortTextBox";
            this._serverPortTextBox.Size = new System.Drawing.Size(254, 22);
            this._serverPortTextBox.TabIndex = 5;
            this._serverPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _serverWindowComboBox
            // 
            this._serverWindowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._serverWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._serverWindowComboBox.Enabled = false;
            this._serverWindowComboBox.FormattingEnabled = true;
            this._serverWindowComboBox.Location = new System.Drawing.Point(390, 48);
            this._serverWindowComboBox.Name = "_serverWindowComboBox";
            this._serverWindowComboBox.Size = new System.Drawing.Size(81, 24);
            this._serverWindowComboBox.TabIndex = 3;
            // 
            // _serverWindowCheckBox
            // 
            this._serverWindowCheckBox.AutoSize = true;
            this._serverWindowCheckBox.Location = new System.Drawing.Point(10, 50);
            this._serverWindowCheckBox.Name = "_serverWindowCheckBox";
            this._serverWindowCheckBox.Size = new System.Drawing.Size(114, 21);
            this._serverWindowCheckBox.TabIndex = 1;
            this._serverWindowCheckBox.Text = "Window Size:";
            this._serverWindowCheckBox.UseVisualStyleBackColor = true;
            this._serverWindowCheckBox.CheckedChanged += new System.EventHandler(this.ServerWindowCheckBox_CheckedChanged);
            // 
            // _serverWindowTextBox
            // 
            this._serverWindowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._serverWindowTextBox.Enabled = false;
            this._serverWindowTextBox.Location = new System.Drawing.Point(130, 48);
            this._serverWindowTextBox.Name = "_serverWindowTextBox";
            this._serverWindowTextBox.Size = new System.Drawing.Size(254, 22);
            this._serverWindowTextBox.TabIndex = 2;
            this._serverWindowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _startServerButton
            // 
            this._startServerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._startServerButton.Location = new System.Drawing.Point(371, 135);
            this._startServerButton.Name = "_startServerButton";
            this._startServerButton.Size = new System.Drawing.Size(100, 32);
            this._startServerButton.TabIndex = 0;
            this._startServerButton.Text = "Start Server";
            this._startServerButton.UseVisualStyleBackColor = true;
            this._startServerButton.Click += new System.EventHandler(this.StartServerButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._clientOutputTextBox);
            this.tabPage2.Controls.Add(this._clientSettingsPanel);
            this.tabPage2.Controls.Add(this._startClientButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client-Mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _clientOutputTextBox
            // 
            this._clientOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clientOutputTextBox.Location = new System.Drawing.Point(0, 176);
            this._clientOutputTextBox.Multiline = true;
            this._clientOutputTextBox.Name = "_clientOutputTextBox";
            this._clientOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._clientOutputTextBox.Size = new System.Drawing.Size(513, 292);
            this._clientOutputTextBox.TabIndex = 7;
            // 
            // _clientSettingsPanel
            // 
            this._clientSettingsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clientSettingsPanel.Controls.Add(this._clientWindowComboBox);
            this._clientSettingsPanel.Controls.Add(this._clientWindowCheckBox);
            this._clientSettingsPanel.Controls.Add(this._clientWindowTextBox);
            this._clientSettingsPanel.Controls.Add(this._clientPortCheckBox);
            this._clientSettingsPanel.Controls.Add(this._clientPortTextBox);
            this._clientSettingsPanel.Controls.Add(this._clientAddressCheckBox);
            this._clientSettingsPanel.Controls.Add(this._clientAddressTextBox);
            this._clientSettingsPanel.Location = new System.Drawing.Point(0, 0);
            this._clientSettingsPanel.Name = "_clientSettingsPanel";
            this._clientSettingsPanel.Size = new System.Drawing.Size(513, 129);
            this._clientSettingsPanel.TabIndex = 6;
            // 
            // _clientWindowComboBox
            // 
            this._clientWindowComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._clientWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._clientWindowComboBox.Enabled = false;
            this._clientWindowComboBox.FormattingEnabled = true;
            this._clientWindowComboBox.Location = new System.Drawing.Point(424, 76);
            this._clientWindowComboBox.Name = "_clientWindowComboBox";
            this._clientWindowComboBox.Size = new System.Drawing.Size(81, 24);
            this._clientWindowComboBox.TabIndex = 10;
            // 
            // _clientWindowCheckBox
            // 
            this._clientWindowCheckBox.AutoSize = true;
            this._clientWindowCheckBox.Location = new System.Drawing.Point(10, 78);
            this._clientWindowCheckBox.Name = "_clientWindowCheckBox";
            this._clientWindowCheckBox.Size = new System.Drawing.Size(114, 21);
            this._clientWindowCheckBox.TabIndex = 8;
            this._clientWindowCheckBox.Text = "Window Size:";
            this._clientWindowCheckBox.UseVisualStyleBackColor = true;
            this._clientWindowCheckBox.CheckedChanged += new System.EventHandler(this._clientWindowCheckBox_CheckedChanged);
            // 
            // _clientWindowTextBox
            // 
            this._clientWindowTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clientWindowTextBox.Enabled = false;
            this._clientWindowTextBox.Location = new System.Drawing.Point(130, 76);
            this._clientWindowTextBox.Name = "_clientWindowTextBox";
            this._clientWindowTextBox.Size = new System.Drawing.Size(288, 22);
            this._clientWindowTextBox.TabIndex = 9;
            this._clientWindowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _clientPortCheckBox
            // 
            this._clientPortCheckBox.AutoSize = true;
            this._clientPortCheckBox.Location = new System.Drawing.Point(10, 50);
            this._clientPortCheckBox.Name = "_clientPortCheckBox";
            this._clientPortCheckBox.Size = new System.Drawing.Size(60, 21);
            this._clientPortCheckBox.TabIndex = 6;
            this._clientPortCheckBox.Text = "Port:";
            this._clientPortCheckBox.UseVisualStyleBackColor = true;
            this._clientPortCheckBox.CheckedChanged += new System.EventHandler(this._clientPortCheckBox_CheckedChanged);
            // 
            // _clientPortTextBox
            // 
            this._clientPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clientPortTextBox.Enabled = false;
            this._clientPortTextBox.Location = new System.Drawing.Point(130, 48);
            this._clientPortTextBox.Name = "_clientPortTextBox";
            this._clientPortTextBox.Size = new System.Drawing.Size(288, 22);
            this._clientPortTextBox.TabIndex = 7;
            this._clientPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // _clientAddressCheckBox
            // 
            this._clientAddressCheckBox.AutoSize = true;
            this._clientAddressCheckBox.Location = new System.Drawing.Point(10, 22);
            this._clientAddressCheckBox.Name = "_clientAddressCheckBox";
            this._clientAddressCheckBox.Size = new System.Drawing.Size(76, 21);
            this._clientAddressCheckBox.TabIndex = 1;
            this._clientAddressCheckBox.Text = "Server:";
            this._clientAddressCheckBox.UseVisualStyleBackColor = true;
            this._clientAddressCheckBox.CheckedChanged += new System.EventHandler(this._clientAddressCheckBox_CheckedChanged);
            // 
            // _clientAddressTextBox
            // 
            this._clientAddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clientAddressTextBox.Enabled = false;
            this._clientAddressTextBox.Location = new System.Drawing.Point(130, 20);
            this._clientAddressTextBox.Name = "_clientAddressTextBox";
            this._clientAddressTextBox.Size = new System.Drawing.Size(288, 22);
            this._clientAddressTextBox.TabIndex = 2;
            // 
            // _startClientButton
            // 
            this._startClientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._startClientButton.Location = new System.Drawing.Point(405, 135);
            this._startClientButton.Name = "_startClientButton";
            this._startClientButton.Size = new System.Drawing.Size(100, 32);
            this._startClientButton.TabIndex = 5;
            this._startClientButton.Text = "Start Client";
            this._startClientButton.UseVisualStyleBackColor = true;
            this._startClientButton.Click += new System.EventHandler(this.StartClientButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // _exitMenuItem
            // 
            this._exitMenuItem.Name = "_exitMenuItem";
            this._exitMenuItem.Size = new System.Drawing.Size(102, 24);
            this._exitMenuItem.Text = "Exit";
            this._exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Iperf Gui";
            this.tabControl1.ResumeLayout(false);
            this._serverModeTabPage.ResumeLayout(false);
            this._serverModeTabPage.PerformLayout();
            this._serverSettingsPanel.ResumeLayout(false);
            this._serverSettingsPanel.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this._clientSettingsPanel.ResumeLayout(false);
            this._clientSettingsPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _serverModeTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox _serverWindowComboBox;
        private System.Windows.Forms.TextBox _serverWindowTextBox;
        private System.Windows.Forms.CheckBox _serverWindowCheckBox;
        private System.Windows.Forms.Button _startServerButton;
        private System.Windows.Forms.Panel _serverSettingsPanel;
        private System.Windows.Forms.Panel _clientSettingsPanel;
        private System.Windows.Forms.CheckBox _clientAddressCheckBox;
        private System.Windows.Forms.TextBox _clientAddressTextBox;
        private System.Windows.Forms.Button _startClientButton;
        private System.Windows.Forms.CheckBox _serverPortCheckBox;
        private System.Windows.Forms.TextBox _serverPortTextBox;
        private System.Windows.Forms.CheckBox _clientPortCheckBox;
        private System.Windows.Forms.TextBox _clientPortTextBox;
        private System.Windows.Forms.ComboBox _clientWindowComboBox;
        private System.Windows.Forms.CheckBox _clientWindowCheckBox;
        private System.Windows.Forms.TextBox _clientWindowTextBox;
        private System.Windows.Forms.TextBox _serverOutputTextBox;
        private System.Windows.Forms.TextBox _clientOutputTextBox;
    }
}

