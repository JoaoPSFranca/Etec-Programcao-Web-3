namespace PetsPessoas
{
    partial class frmVerPets
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
            this.cbxPets = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDono = new System.Windows.Forms.TextBox();
            this.lblDono = new System.Windows.Forms.Label();
            this.txtRaca = new System.Windows.Forms.TextBox();
            this.lblraca = new System.Windows.Forms.Label();
            this.lblRespPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblRespData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblPets = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxPets
            // 
            this.cbxPets.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxPets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPets.FormattingEnabled = true;
            this.cbxPets.Location = new System.Drawing.Point(12, 49);
            this.cbxPets.MaxDropDownItems = 5;
            this.cbxPets.Name = "cbxPets";
            this.cbxPets.Size = new System.Drawing.Size(331, 29);
            this.cbxPets.TabIndex = 21;
            this.cbxPets.SelectedIndexChanged += new System.EventHandler(this.cbxPets_SelectedIndexChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(12, 383);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 34);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(264, 383);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "&Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(141, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDono
            // 
            this.txtDono.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDono.Location = new System.Drawing.Point(12, 119);
            this.txtDono.Name = "txtDono";
            this.txtDono.ReadOnly = true;
            this.txtDono.Size = new System.Drawing.Size(371, 29);
            this.txtDono.TabIndex = 1;
            this.txtDono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDono
            // 
            this.lblDono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDono.Location = new System.Drawing.Point(12, 81);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(371, 35);
            this.lblDono.TabIndex = 30;
            this.lblDono.Text = "Dono: ";
            this.lblDono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRaca
            // 
            this.txtRaca.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtRaca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRaca.Location = new System.Drawing.Point(12, 189);
            this.txtRaca.Name = "txtRaca";
            this.txtRaca.ReadOnly = true;
            this.txtRaca.Size = new System.Drawing.Size(371, 29);
            this.txtRaca.TabIndex = 2;
            this.txtRaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblraca
            // 
            this.lblraca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraca.Location = new System.Drawing.Point(12, 151);
            this.lblraca.Name = "lblraca";
            this.lblraca.Size = new System.Drawing.Size(371, 35);
            this.lblraca.TabIndex = 32;
            this.lblraca.Text = "Raça:";
            this.lblraca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRespPeso
            // 
            this.lblRespPeso.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRespPeso.ForeColor = System.Drawing.Color.Red;
            this.lblRespPeso.Location = new System.Drawing.Point(12, 291);
            this.lblRespPeso.Name = "lblRespPeso";
            this.lblRespPeso.Size = new System.Drawing.Size(371, 19);
            this.lblRespPeso.TabIndex = 35;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(12, 259);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(371, 29);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(12, 221);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(371, 35);
            this.lblPeso.TabIndex = 34;
            this.lblPeso.Text = "Peso: ";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRespData
            // 
            this.lblRespData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRespData.ForeColor = System.Drawing.Color.Red;
            this.lblRespData.Location = new System.Drawing.Point(12, 361);
            this.lblRespData.Name = "lblRespData";
            this.lblRespData.Size = new System.Drawing.Size(371, 19);
            this.lblRespData.TabIndex = 38;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(12, 329);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(371, 29);
            this.txtData.TabIndex = 4;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 291);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(371, 35);
            this.lblData.TabIndex = 37;
            this.lblData.Text = "Data de Nascimento:";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPets
            // 
            this.lblPets.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPets.Location = new System.Drawing.Point(16, 9);
            this.lblPets.Name = "lblPets";
            this.lblPets.Size = new System.Drawing.Size(367, 35);
            this.lblPets.TabIndex = 27;
            this.lblPets.Text = "Pet:";
            this.lblPets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(349, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 34);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmVerPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 425);
            this.Controls.Add(this.lblRespData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblRespPeso);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtRaca);
            this.Controls.Add(this.lblraca);
            this.Controls.Add(this.txtDono);
            this.Controls.Add(this.lblDono);
            this.Controls.Add(this.lblPets);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxPets);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerPets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pets";
            this.Load += new System.EventHandler(this.frmVerPets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxPets;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDono;
        private System.Windows.Forms.Label lblDono;
        private System.Windows.Forms.TextBox txtRaca;
        private System.Windows.Forms.Label lblraca;
        private System.Windows.Forms.Label lblRespPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblRespData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblPets;
        private System.Windows.Forms.Button btnAdd;
    }
}