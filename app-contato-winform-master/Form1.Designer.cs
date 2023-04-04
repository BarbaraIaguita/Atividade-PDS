namespace AppContatoForm
{
    partial class MenuForm
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
            this.btnCadastro = new Sunny.UI.UIButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btListarContato = new Sunny.UI.UIButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastro
            // 
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastro.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btnCadastro.Location = new System.Drawing.Point(3, 3);
            this.btnCadastro.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Radius = 1;
            this.btnCadastro.Size = new System.Drawing.Size(245, 145);
            this.btnCadastro.TabIndex = 2;
            this.btnCadastro.Text = "Cadastro de Contato";
            this.btnCadastro.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnCadastro);
            this.flowLayoutPanel1.Controls.Add(this.btListarContato);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 11);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(777, 419);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // btListarContato
            // 
            this.btListarContato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btListarContato.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F);
            this.btListarContato.Location = new System.Drawing.Point(254, 3);
            this.btListarContato.MinimumSize = new System.Drawing.Size(1, 1);
            this.btListarContato.Name = "btListarContato";
            this.btListarContato.Radius = 1;
            this.btListarContato.Size = new System.Drawing.Size(245, 145);
            this.btListarContato.TabIndex = 4;
            this.btListarContato.Text = "Listar Contato";
            this.btListarContato.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btListarContato.Click += new System.EventHandler(this.btListarContato_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIButton btnCadastro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Sunny.UI.UIButton btListarContato;
    }
}

