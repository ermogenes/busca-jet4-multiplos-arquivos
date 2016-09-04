namespace BuscaBO
{
    partial class PrincipalForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscaProgressBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BuscaButton = new System.Windows.Forms.Button();
            this.BuscaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscaDataGridView = new System.Windows.Forms.DataGridView();
            this.ArquivoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChaveColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coluna2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.configuraçõesToolStripMenuItem,
            this.audaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.sairToolStripMenuItem.Text = "Sai&r...";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferênciasToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "&Configurações";
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.preferênciasToolStripMenuItem.Text = "&Preferências...";
            this.preferênciasToolStripMenuItem.Click += new System.EventHandler(this.preferenciasToolStripMenuItem_Click);
            // 
            // audaToolStripMenuItem
            // 
            this.audaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.audaToolStripMenuItem.Name = "audaToolStripMenuItem";
            this.audaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.audaToolStripMenuItem.Text = "A&juda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.sobreToolStripMenuItem.Text = "So&bre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // BuscaProgressBar
            // 
            this.BuscaProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BuscaProgressBar.Location = new System.Drawing.Point(0, 497);
            this.BuscaProgressBar.Name = "BuscaProgressBar";
            this.BuscaProgressBar.Size = new System.Drawing.Size(844, 23);
            this.BuscaProgressBar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BuscaButton);
            this.panel1.Controls.Add(this.BuscaTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 19);
            this.panel1.TabIndex = 2;
            // 
            // BuscaButton
            // 
            this.BuscaButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.BuscaButton.Location = new System.Drawing.Point(719, 0);
            this.BuscaButton.Name = "BuscaButton";
            this.BuscaButton.Size = new System.Drawing.Size(125, 19);
            this.BuscaButton.TabIndex = 2;
            this.BuscaButton.Text = "Buscar...";
            this.BuscaButton.UseVisualStyleBackColor = true;
            this.BuscaButton.Click += new System.EventHandler(this.BuscaButton_Click);
            // 
            // BuscaTextBox
            // 
            this.BuscaTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscaTextBox.Location = new System.Drawing.Point(43, 0);
            this.BuscaTextBox.Name = "BuscaTextBox";
            this.BuscaTextBox.Size = new System.Drawing.Size(801, 20);
            this.BuscaTextBox.TabIndex = 1;
            this.BuscaTextBox.Text = "0050/16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar:";
            // 
            // BuscaDataGridView
            // 
            this.BuscaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BuscaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArquivoColumn,
            this.ChaveColumn,
            this.Coluna1Column,
            this.Coluna2Column});
            this.BuscaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BuscaDataGridView.Location = new System.Drawing.Point(0, 43);
            this.BuscaDataGridView.Name = "BuscaDataGridView";
            this.BuscaDataGridView.Size = new System.Drawing.Size(844, 454);
            this.BuscaDataGridView.TabIndex = 3;
            // 
            // ArquivoColumn
            // 
            this.ArquivoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ArquivoColumn.HeaderText = "Pesquisa";
            this.ArquivoColumn.Name = "ArquivoColumn";
            this.ArquivoColumn.ReadOnly = true;
            // 
            // ChaveColumn
            // 
            this.ChaveColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChaveColumn.HeaderText = "Chave";
            this.ChaveColumn.Name = "ChaveColumn";
            this.ChaveColumn.Width = 63;
            // 
            // Coluna1Column
            // 
            this.Coluna1Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Coluna1Column.HeaderText = "Exibição 1";
            this.Coluna1Column.MinimumWidth = 250;
            this.Coluna1Column.Name = "Coluna1Column";
            this.Coluna1Column.Width = 250;
            // 
            // Coluna2Column
            // 
            this.Coluna2Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Coluna2Column.HeaderText = "Exibição 2";
            this.Coluna2Column.MinimumWidth = 250;
            this.Coluna2Column.Name = "Coluna2Column";
            this.Coluna2Column.ReadOnly = true;
            this.Coluna2Column.Width = 250;
            // 
            // PrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 520);
            this.Controls.Add(this.BuscaDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuscaProgressBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalForm";
            this.Text = "Busca Integrada - Univesp, PI bim 09";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrincipalForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ProgressBar BuscaProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BuscaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BuscaDataGridView;
        private System.Windows.Forms.Button BuscaButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArquivoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChaveColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna1Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coluna2Column;
    }
}

