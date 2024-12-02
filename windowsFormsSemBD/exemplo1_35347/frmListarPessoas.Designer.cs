
namespace exemplo1_35347
{
    partial class frmListarPessoas
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
            this.cbxPessoas = new System.Windows.Forms.ComboBox();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxPessoas
            // 
            this.cbxPessoas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPessoas.FormattingEnabled = true;
            this.cbxPessoas.Location = new System.Drawing.Point(12, 12);
            this.cbxPessoas.MaxDropDownItems = 5;
            this.cbxPessoas.Name = "cbxPessoas";
            this.cbxPessoas.Size = new System.Drawing.Size(210, 34);
            this.cbxPessoas.TabIndex = 0;
            // 
            // btnAbrir
            // 
            this.btnAbrir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAbrir.Location = new System.Drawing.Point(228, 11);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(110, 34);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "&Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(344, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(40, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResp
            // 
            this.lblResp.Location = new System.Drawing.Point(12, 67);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(371, 45);
            this.lblResp.TabIndex = 2;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmListarPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 121);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.cbxPessoas);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pessoas e Pets";
            this.Load += new System.EventHandler(this.frmListarPessoas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxPessoas;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResp;
    }
}

