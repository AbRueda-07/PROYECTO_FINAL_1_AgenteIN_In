namespace InvestigadorAI_Final.Forms
{
    partial class FormMenuPrincipal
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
            btnInvestigar = new Button();
            lblMenu = new Label();
            btnVerRegistros = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnInvestigar
            // 
            btnInvestigar.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold);
            btnInvestigar.Location = new Point(179, 186);
            btnInvestigar.Name = "btnInvestigar";
            btnInvestigar.Size = new Size(431, 51);
            btnInvestigar.TabIndex = 0;
            btnInvestigar.Text = "INVESTIGAR  🔎";
            btnInvestigar.UseVisualStyleBackColor = true;
            btnInvestigar.Click += btnInvestigar_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BackColor = Color.Transparent;
            lblMenu.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenu.Location = new Point(131, 58);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(479, 37);
            lblMenu.TabIndex = 1;
            lblMenu.Text = "MENÚ PRINCIPAL DEL SISTEMA";
            // 
            // btnVerRegistros
            // 
            btnVerRegistros.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold);
            btnVerRegistros.Location = new Point(179, 274);
            btnVerRegistros.Name = "btnVerRegistros";
            btnVerRegistros.Size = new Size(431, 51);
            btnVerRegistros.TabIndex = 2;
            btnVerRegistros.Text = "VER REGISTROS  📝";
            btnVerRegistros.UseVisualStyleBackColor = true;
            btnVerRegistros.Click += btnVerRegistros_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.upscalemedia_transformed;
            pictureBox1.Location = new Point(198, 502);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Perpetua Titling MT", 16.2F, FontStyle.Bold);
            btnSalir.Location = new Point(179, 366);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(431, 51);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Cerrar el Programa 🔒";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_6556413_1920;
            ClientSize = new Size(852, 761);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnVerRegistros);
            Controls.Add(lblMenu);
            Controls.Add(btnInvestigar);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInvestigar;
        private Label lblMenu;
        private Button btnVerRegistros;
        private PictureBox pictureBox1;
        private Button btnSalir;
    }
}