namespace Trabalho_3_Camadas
{
    partial class CadClienteForm
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
            lblNome = new Label();
            lblIdade = new Label();
            lblSobrenome = new Label();
            lblEmail = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtSobrenome = new TextBox();
            txtEmail = new TextBox();
            lblEndereco = new Label();
            lblSexo = new Label();
            txtEndereco = new TextBox();
            cbSexo = new ComboBox();
            cbStatus = new ComboBox();
            lblStatus = new Label();
            btnConfirmar = new Button();
            Limpar = new Button();
            Cancelar = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblNome.Location = new Point(12, 9);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(59, 23);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblIdade.Location = new Point(32, 191);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(57, 23);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "Idade";
            // 
            // lblSobrenome
            // 
            lblSobrenome.AutoSize = true;
            lblSobrenome.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSobrenome.Location = new Point(431, 9);
            lblSobrenome.Name = "lblSobrenome";
            lblSobrenome.Size = new Size(104, 23);
            lblSobrenome.TabIndex = 2;
            lblSobrenome.Text = "Sobrenome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEmail.Location = new Point(431, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(58, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(12, 35);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(397, 30);
            txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdade.Location = new Point(32, 217);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(211, 30);
            txtIdade.TabIndex = 8;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSobrenome.Location = new Point(431, 35);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(397, 30);
            txtSobrenome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(431, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(397, 30);
            txtEmail.TabIndex = 7;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblEndereco.Location = new Point(12, 100);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(90, 23);
            lblEndereco.TabIndex = 9;
            lblEndereco.Text = "Endereço";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSexo.Location = new Point(330, 191);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(51, 23);
            lblSexo.TabIndex = 8;
            lblSexo.Text = "Sexo";
            // 
            // txtEndereco
            // 
            txtEndereco.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEndereco.Location = new Point(12, 126);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(397, 30);
            txtEndereco.TabIndex = 6;
            // 
            // cbSexo
            // 
            cbSexo.Items.AddRange(new object[] { "----------", "Masculino", "Feminino" });
            cbSexo.Location = new Point(330, 219);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(191, 28);
            cbSexo.TabIndex = 9;
            cbSexo.Text = "----------";
            cbSexo.SelectedIndexChanged += cbSexo_SelectedIndexChanged;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cbStatus.Location = new Point(602, 219);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(191, 28);
            cbStatus.TabIndex = 10;
            cbStatus.Text = "--------";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblStatus.Location = new Point(602, 191);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 23);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(229, 320);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 11;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(366, 320);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(94, 29);
            Limpar.TabIndex = 12;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            Limpar.Click += Limpar_Click;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(503, 320);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 13;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            Cancelar.Click += Cancelar_Click;
            // 
            // CadClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 191, 167);
            ClientSize = new Size(834, 361);
            Controls.Add(Cancelar);
            Controls.Add(Limpar);
            Controls.Add(btnConfirmar);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cbSexo);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(lblSexo);
            Controls.Add(txtEmail);
            Controls.Add(txtSobrenome);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblSobrenome);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CadClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CadCliente";
            Load += CadClienteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblIdade;
        private Label lblSobrenome;
        private Label lblEmail;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtSobrenome;
        private TextBox txtEmail;
        private Label lblEndereco;
        private Label lblSexo;
        private TextBox txtEndereco;
        private ComboBox cbSexo;
        private ComboBox cbStatus;
        private Label lblStatus;
        private Button btnConfirmar;
        private Button Limpar;
        private Button Cancelar;
    }
}