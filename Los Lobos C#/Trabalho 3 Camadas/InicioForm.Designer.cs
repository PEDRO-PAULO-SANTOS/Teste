namespace Trabalho_3_Camadas
{
    partial class InicioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioForm));
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            cadastrarClienteToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarPetToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.CheckOnClick = true;
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarClienteToolStripMenuItem1, cadastrarPetToolStripMenuItem });
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(65, 24);
            mENUToolStripMenuItem.Text = "MENU";
            // 
            // cadastrarClienteToolStripMenuItem1
            // 
            cadastrarClienteToolStripMenuItem1.AccessibleRole = AccessibleRole.MenuItem;
            cadastrarClienteToolStripMenuItem1.CheckOnClick = true;
            cadastrarClienteToolStripMenuItem1.Name = "cadastrarClienteToolStripMenuItem1";
            cadastrarClienteToolStripMenuItem1.ShortcutKeys = Keys.Alt | Keys.C;
            cadastrarClienteToolStripMenuItem1.Size = new Size(252, 26);
            cadastrarClienteToolStripMenuItem1.Text = "Cadastrar Cliente";
            cadastrarClienteToolStripMenuItem1.Click += cadastrarClienteToolStripMenuItem1_Click;
            // 
            // cadastrarPetToolStripMenuItem
            // 
            cadastrarPetToolStripMenuItem.Name = "cadastrarPetToolStripMenuItem";
            cadastrarPetToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.P;
            cadastrarPetToolStripMenuItem.Size = new Size(252, 26);
            cadastrarPetToolStripMenuItem.Text = "Cadastrar Pet";
            cadastrarPetToolStripMenuItem.Click += cadastrarPetToolStripMenuItem_Click;
            // 
            // InicioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 191, 167);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "InicioForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem cadastrarClienteToolStripMenuItem1;
        private ToolStripMenuItem cadastrarPetToolStripMenuItem;
    }
}
