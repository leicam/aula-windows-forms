namespace aula_windows_forms
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarProduto
            // 
            this.btnListarProduto.Location = new System.Drawing.Point(12, 12);
            this.btnListarProduto.Name = "btnListarProduto";
            this.btnListarProduto.Size = new System.Drawing.Size(180, 74);
            this.btnListarProduto.TabIndex = 0;
            this.btnListarProduto.Text = "Listar Produto";
            this.btnListarProduto.UseVisualStyleBackColor = true;
            this.btnListarProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarProduto);
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarProduto;
    }
}

