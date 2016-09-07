namespace BuscaIntegrada
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
            this.BuscasListBox = new System.Windows.Forms.ListBox();
            this.NovoButton = new System.Windows.Forms.Button();
            this.ExcluirButton = new System.Windows.Forms.Button();
            this.FecharButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscasListBox
            // 
            this.BuscasListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.BuscasListBox.FormattingEnabled = true;
            this.BuscasListBox.Location = new System.Drawing.Point(0, 0);
            this.BuscasListBox.Name = "BuscasListBox";
            this.BuscasListBox.ScrollAlwaysVisible = true;
            this.BuscasListBox.Size = new System.Drawing.Size(370, 238);
            this.BuscasListBox.TabIndex = 0;
            // 
            // NovoButton
            // 
            this.NovoButton.Location = new System.Drawing.Point(376, 12);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(75, 23);
            this.NovoButton.TabIndex = 1;
            this.NovoButton.Text = "&Novo...";
            this.NovoButton.UseVisualStyleBackColor = true;
            this.NovoButton.Click += new System.EventHandler(this.NovoButton_Click);
            // 
            // ExcluirButton
            // 
            this.ExcluirButton.Location = new System.Drawing.Point(376, 41);
            this.ExcluirButton.Name = "ExcluirButton";
            this.ExcluirButton.Size = new System.Drawing.Size(75, 23);
            this.ExcluirButton.TabIndex = 2;
            this.ExcluirButton.Text = "E&xcluir";
            this.ExcluirButton.UseVisualStyleBackColor = true;
            this.ExcluirButton.Click += new System.EventHandler(this.ExcluirButton_Click);
            // 
            // FecharButton
            // 
            this.FecharButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.FecharButton.Location = new System.Drawing.Point(376, 203);
            this.FecharButton.Name = "FecharButton";
            this.FecharButton.Size = new System.Drawing.Size(75, 23);
            this.FecharButton.TabIndex = 3;
            this.FecharButton.Text = "&Fechar";
            this.FecharButton.UseVisualStyleBackColor = true;
            this.FecharButton.Click += new System.EventHandler(this.FecharButton_Click);
            // 
            // ConfiguracoesForm
            // 
            this.AcceptButton = this.NovoButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FecharButton;
            this.ClientSize = new System.Drawing.Size(462, 238);
            this.Controls.Add(this.FecharButton);
            this.Controls.Add(this.ExcluirButton);
            this.Controls.Add(this.NovoButton);
            this.Controls.Add(this.BuscasListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfiguracoesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.ConfiguracoesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BuscasListBox;
        private System.Windows.Forms.Button NovoButton;
        private System.Windows.Forms.Button ExcluirButton;
        private System.Windows.Forms.Button FecharButton;
    }
}