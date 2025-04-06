namespace Trabalho_3_Camadas
{
    partial class CadPetForm
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
            cbSexoPet = new ComboBox();
            lblSexoPet = new Label();
            txtSobrenomePet = new TextBox();
            txtIdadePet = new TextBox();
            txtNomePet = new TextBox();
            lblSobrenomePet = new Label();
            lblIdadePet = new Label();
            lblNomePet = new Label();
            Cancelar = new Button();
            Limpar = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // cbSexoPet
            // 
            cbSexoPet.Items.AddRange(new object[] { "----------", "Macho", "Femea" });
            cbSexoPet.Location = new Point(12, 215);
            cbSexoPet.Name = "cbSexoPet";
            cbSexoPet.Size = new Size(191, 28);
            cbSexoPet.TabIndex = 20;
            cbSexoPet.Text = "----------";
            // 
            // lblSexoPet
            // 
            lblSexoPet.AutoSize = true;
            lblSexoPet.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSexoPet.Location = new Point(12, 187);
            lblSexoPet.Name = "lblSexoPet";
            lblSexoPet.Size = new Size(80, 23);
            lblSexoPet.TabIndex = 18;
            lblSexoPet.Text = "SexoPet";
            lblSexoPet.Click += lblSexo_Click;
            // 
            // txtSobrenomePet
            // 
            txtSobrenomePet.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSobrenomePet.Location = new Point(12, 134);
            txtSobrenomePet.Name = "txtSobrenomePet";
            txtSobrenomePet.Size = new Size(397, 30);
            txtSobrenomePet.TabIndex = 15;
            // 
            // txtIdadePet
            // 
            txtIdadePet.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtIdadePet.Location = new Point(267, 213);
            txtIdadePet.Name = "txtIdadePet";
            txtIdadePet.Size = new Size(91, 30);
            txtIdadePet.TabIndex = 19;
            // 
            // txtNomePet
            // 
            txtNomePet.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNomePet.Location = new Point(12, 43);
            txtNomePet.Name = "txtNomePet";
            txtNomePet.Size = new Size(397, 30);
            txtNomePet.TabIndex = 14;
            // 
            // lblSobrenomePet
            // 
            lblSobrenomePet.AutoSize = true;
            lblSobrenomePet.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblSobrenomePet.Location = new Point(12, 108);
            lblSobrenomePet.Name = "lblSobrenomePet";
            lblSobrenomePet.Size = new Size(138, 23);
            lblSobrenomePet.TabIndex = 12;
            lblSobrenomePet.Text = "Sobrenome Pet";
            // 
            // lblIdadePet
            // 
            lblIdadePet.AutoSize = true;
            lblIdadePet.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblIdadePet.Location = new Point(267, 187);
            lblIdadePet.Name = "lblIdadePet";
            lblIdadePet.Size = new Size(91, 23);
            lblIdadePet.TabIndex = 11;
            lblIdadePet.Text = "Idade Pet";
            // 
            // lblNomePet
            // 
            lblNomePet.AutoSize = true;
            lblNomePet.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblNomePet.Location = new Point(12, 17);
            lblNomePet.Name = "lblNomePet";
            lblNomePet.Size = new Size(93, 23);
            lblNomePet.TabIndex = 10;
            lblNomePet.Text = "Nome Pet";
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(299, 282);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(94, 29);
            Cancelar.TabIndex = 23;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // Limpar
            // 
            Limpar.Location = new Point(162, 282);
            Limpar.Name = "Limpar";
            Limpar.Size = new Size(94, 29);
            Limpar.TabIndex = 22;
            Limpar.Text = "Limpar";
            Limpar.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(25, 282);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(94, 29);
            btnConfirmar.TabIndex = 21;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // CadPetForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 191, 167);
            ClientSize = new Size(420, 323);
            Controls.Add(Cancelar);
            Controls.Add(Limpar);
            Controls.Add(btnConfirmar);
            Controls.Add(cbSexoPet);
            Controls.Add(lblSexoPet);
            Controls.Add(txtSobrenomePet);
            Controls.Add(txtIdadePet);
            Controls.Add(txtNomePet);
            Controls.Add(lblSobrenomePet);
            Controls.Add(lblIdadePet);
            Controls.Add(lblNomePet);
            Name = "CadPetForm";
            Text = "CadPetForm";
            Load += CadPetForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSexoPet;
        private Label lblSexoPet;
        private TextBox txtSobrenomePet;
        private TextBox txtIdadePet;
        private TextBox txtNomePet;
        private Label lblSobrenomePet;
        private Label lblIdadePet;
        private Label lblNomePet;
        private Button Cancelar;
        private Button Limpar;
        private Button btnConfirmar;
    }
}