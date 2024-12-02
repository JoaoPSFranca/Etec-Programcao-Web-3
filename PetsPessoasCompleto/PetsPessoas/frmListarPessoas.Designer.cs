namespace PetsPessoas
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
            this.lblResp = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPessoa = new System.Windows.Forms.Button();
            this.cbxPessoas = new System.Windows.Forms.ComboBox();
            this.btnPets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResp
            // 
            this.lblResp.Location = new System.Drawing.Point(12, 89);
            this.lblResp.Name = "lblResp";
            this.lblResp.Size = new System.Drawing.Size(371, 50);
            this.lblResp.TabIndex = 5;
            this.lblResp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(264, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "&Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPessoa
            // 
            this.btnPessoa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPessoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPessoa.Location = new System.Drawing.Point(12, 52);
            this.btnPessoa.Name = "btnPessoa";
            this.btnPessoa.Size = new System.Drawing.Size(123, 34);
            this.btnPessoa.TabIndex = 1;
            this.btnPessoa.Text = "Ver &Pessoa";
            this.btnPessoa.UseVisualStyleBackColor = false;
            this.btnPessoa.Click += new System.EventHandler(this.btnPessoa_Click);
            // 
            // cbxPessoas
            // 
            this.cbxPessoas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPessoas.FormattingEnabled = true;
            this.cbxPessoas.Location = new System.Drawing.Point(12, 12);
            this.cbxPessoas.MaxDropDownItems = 5;
            this.cbxPessoas.Name = "cbxPessoas";
            this.cbxPessoas.Size = new System.Drawing.Size(371, 34);
            this.cbxPessoas.TabIndex = 3;
            // 
            // btnPets
            // 
            this.btnPets.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPets.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPets.Location = new System.Drawing.Point(141, 52);
            this.btnPets.Name = "btnPets";
            this.btnPets.Size = new System.Drawing.Size(117, 34);
            this.btnPets.TabIndex = 2;
            this.btnPets.Text = "&Ver Pets";
            this.btnPets.UseVisualStyleBackColor = false;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            // 
            // frmListarPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 149);
            this.Controls.Add(this.btnPets);
            this.Controls.Add(this.lblResp);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPessoa);
            this.Controls.Add(this.cbxPessoas);
            this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Pessoas";
            this.Load += new System.EventHandler(this.frmListarPessoas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblResp;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPessoa;
        private System.Windows.Forms.ComboBox cbxPessoas;
        private System.Windows.Forms.Button btnPets;
    }
}

