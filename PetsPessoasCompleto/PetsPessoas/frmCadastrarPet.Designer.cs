namespace PetsPessoas
{
    partial class frmCadastrarPet
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
            this.lblDono = new System.Windows.Forms.Label();
            this.cbxPessoas = new System.Windows.Forms.ComboBox();
            this.lblraca = new System.Windows.Forms.Label();
            this.cbxRaca = new System.Windows.Forms.ComboBox();
            this.lblRespNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblRespPeso = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblRespData = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDono
            // 
            this.lblDono.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDono.Location = new System.Drawing.Point(12, 9);
            this.lblDono.Name = "lblDono";
            this.lblDono.Size = new System.Drawing.Size(371, 35);
            this.lblDono.TabIndex = 14;
            this.lblDono.Text = "Dono:";
            this.lblDono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxPessoas
            // 
            this.cbxPessoas.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxPessoas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPessoas.FormattingEnabled = true;
            this.cbxPessoas.Location = new System.Drawing.Point(12, 47);
            this.cbxPessoas.MaxDropDownItems = 5;
            this.cbxPessoas.Name = "cbxPessoas";
            this.cbxPessoas.Size = new System.Drawing.Size(371, 29);
            this.cbxPessoas.TabIndex = 31;
            // 
            // lblraca
            // 
            this.lblraca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblraca.Location = new System.Drawing.Point(12, 79);
            this.lblraca.Name = "lblraca";
            this.lblraca.Size = new System.Drawing.Size(371, 35);
            this.lblraca.TabIndex = 33;
            this.lblraca.Text = "Raça:";
            this.lblraca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxRaca
            // 
            this.cbxRaca.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cbxRaca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRaca.FormattingEnabled = true;
            this.cbxRaca.Location = new System.Drawing.Point(12, 117);
            this.cbxRaca.MaxDropDownItems = 5;
            this.cbxRaca.Name = "cbxRaca";
            this.cbxRaca.Size = new System.Drawing.Size(371, 29);
            this.cbxRaca.TabIndex = 31;
            // 
            // lblRespNome
            // 
            this.lblRespNome.ForeColor = System.Drawing.Color.Red;
            this.lblRespNome.Location = new System.Drawing.Point(12, 219);
            this.lblRespNome.Name = "lblRespNome";
            this.lblRespNome.Size = new System.Drawing.Size(371, 19);
            this.lblRespNome.TabIndex = 36;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(12, 187);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(371, 29);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 149);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(371, 35);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "Nome: ";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPeso
            // 
            this.lblPeso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(12, 238);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(371, 35);
            this.lblPeso.TabIndex = 35;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(12, 276);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(371, 29);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // lblRespPeso
            // 
            this.lblRespPeso.ForeColor = System.Drawing.Color.Red;
            this.lblRespPeso.Location = new System.Drawing.Point(12, 308);
            this.lblRespPeso.Name = "lblRespPeso";
            this.lblRespPeso.Size = new System.Drawing.Size(371, 19);
            this.lblRespPeso.TabIndex = 36;
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 327);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(371, 35);
            this.lblData.TabIndex = 35;
            this.lblData.Text = "Data de Nascimento";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(12, 365);
            this.txtData.MaxLength = 10;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(371, 29);
            this.txtData.TabIndex = 3;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            // 
            // lblRespData
            // 
            this.lblRespData.ForeColor = System.Drawing.Color.Red;
            this.lblRespData.Location = new System.Drawing.Point(12, 397);
            this.lblRespData.Name = "lblRespData";
            this.lblRespData.Size = new System.Drawing.Size(371, 19);
            this.lblRespData.TabIndex = 36;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(202, 419);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(177, 34);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(12, 419);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(177, 34);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // frmCadastrarPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(395, 466);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblRespData);
            this.Controls.Add(this.lblRespPeso);
            this.Controls.Add(this.lblRespNome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblraca);
            this.Controls.Add(this.cbxRaca);
            this.Controls.Add(this.cbxPessoas);
            this.Controls.Add(this.lblDono);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarPet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Pet";
            this.Load += new System.EventHandler(this.frmCadastrarPet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDono;
        private System.Windows.Forms.ComboBox cbxPessoas;
        private System.Windows.Forms.Label lblraca;
        private System.Windows.Forms.ComboBox cbxRaca;
        private System.Windows.Forms.Label lblRespNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblRespPeso;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblRespData;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
    }
}