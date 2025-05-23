namespace InvestigadorAI_Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnGenerarPrompt = new Button();
            lblTitulo = new Label();
            txtTemaInvestigacion = new TextBox();
            lblTemaInvestigacion = new Label();
            lblEstado = new Label();
            rtbResultado = new RichTextBox();
            lblPromptPersonalizado = new Label();
            txtPromptPersonalizado = new TextBox();
            btnRealizarInvestigacion = new Button();
            btnGuardarEnBD = new Button();
            btnGenerarWord = new Button();
            btnAbrirCarpeta = new Button();
            btnGenerarPowerPoint = new Button();
            lblResultado = new Label();
            btnCerrar = new Button();
            pbLoading = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLoading).BeginInit();
            SuspendLayout();
            // 
            // btnGenerarPrompt
            // 
            btnGenerarPrompt.BackColor = Color.Gainsboro;
            btnGenerarPrompt.BackgroundImageLayout = ImageLayout.Center;
            btnGenerarPrompt.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarPrompt.Location = new Point(1032, 173);
            btnGenerarPrompt.Margin = new Padding(4, 3, 4, 3);
            btnGenerarPrompt.Name = "btnGenerarPrompt";
            btnGenerarPrompt.Size = new Size(144, 51);
            btnGenerarPrompt.TabIndex = 0;
            btnGenerarPrompt.Text = "Generar Prompt";
            btnGenerarPrompt.UseVisualStyleBackColor = false;
            btnGenerarPrompt.Click += btnGenerarPrompt_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Imprint MT Shadow", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(55, 9);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1196, 43);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Agente de Automatización de Investigación y Elaboración de Informes";
            // 
            // txtTemaInvestigacion
            // 
            txtTemaInvestigacion.Location = new Point(374, 109);
            txtTemaInvestigacion.Margin = new Padding(4, 3, 4, 3);
            txtTemaInvestigacion.Name = "txtTemaInvestigacion";
            txtTemaInvestigacion.Size = new Size(614, 28);
            txtTemaInvestigacion.TabIndex = 2;
            // 
            // lblTemaInvestigacion
            // 
            lblTemaInvestigacion.AutoSize = true;
            lblTemaInvestigacion.BackColor = Color.Transparent;
            lblTemaInvestigacion.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            lblTemaInvestigacion.Location = new Point(138, 109);
            lblTemaInvestigacion.Margin = new Padding(4, 0, 4, 0);
            lblTemaInvestigacion.Name = "lblTemaInvestigacion";
            lblTemaInvestigacion.Size = new Size(194, 20);
            lblTemaInvestigacion.TabIndex = 3;
            lblTemaInvestigacion.Text = "Tema de Investigación";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.Transparent;
            lblEstado.Location = new Point(436, 862);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(64, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // rtbResultado
            // 
            rtbResultado.Location = new Point(175, 261);
            rtbResultado.Margin = new Padding(4, 3, 4, 3);
            rtbResultado.Name = "rtbResultado";
            rtbResultado.Size = new Size(852, 261);
            rtbResultado.TabIndex = 5;
            rtbResultado.Text = "";
            rtbResultado.TextChanged += rtbResultado_TextChanged;
            // 
            // lblPromptPersonalizado
            // 
            lblPromptPersonalizado.AutoSize = true;
            lblPromptPersonalizado.BackColor = Color.Transparent;
            lblPromptPersonalizado.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            lblPromptPersonalizado.Location = new Point(138, 188);
            lblPromptPersonalizado.Margin = new Padding(4, 0, 4, 0);
            lblPromptPersonalizado.Name = "lblPromptPersonalizado";
            lblPromptPersonalizado.Size = new Size(190, 20);
            lblPromptPersonalizado.TabIndex = 6;
            lblPromptPersonalizado.Text = "Prompt Personalizado";
            // 
            // txtPromptPersonalizado
            // 
            txtPromptPersonalizado.Location = new Point(374, 185);
            txtPromptPersonalizado.Margin = new Padding(4, 3, 4, 3);
            txtPromptPersonalizado.Name = "txtPromptPersonalizado";
            txtPromptPersonalizado.Size = new Size(614, 28);
            txtPromptPersonalizado.TabIndex = 7;
            // 
            // btnRealizarInvestigacion
            // 
            btnRealizarInvestigacion.BackColor = Color.Gainsboro;
            btnRealizarInvestigacion.BackgroundImageLayout = ImageLayout.Center;
            btnRealizarInvestigacion.ForeColor = SystemColors.ActiveCaptionText;
            btnRealizarInvestigacion.Location = new Point(1032, 97);
            btnRealizarInvestigacion.Margin = new Padding(4, 3, 4, 3);
            btnRealizarInvestigacion.Name = "btnRealizarInvestigacion";
            btnRealizarInvestigacion.Size = new Size(144, 51);
            btnRealizarInvestigacion.TabIndex = 8;
            btnRealizarInvestigacion.Text = "Realizar Investigacion";
            btnRealizarInvestigacion.UseVisualStyleBackColor = false;
            btnRealizarInvestigacion.Click += btnRealizarInvestigacion_Click;
            // 
            // btnGuardarEnBD
            // 
            btnGuardarEnBD.BackColor = Color.Gainsboro;
            btnGuardarEnBD.BackgroundImageLayout = ImageLayout.Center;
            btnGuardarEnBD.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardarEnBD.Location = new Point(1044, 261);
            btnGuardarEnBD.Margin = new Padding(4, 3, 4, 3);
            btnGuardarEnBD.Name = "btnGuardarEnBD";
            btnGuardarEnBD.Size = new Size(144, 51);
            btnGuardarEnBD.TabIndex = 9;
            btnGuardarEnBD.Text = "Guardar En BD";
            btnGuardarEnBD.UseVisualStyleBackColor = false;
            btnGuardarEnBD.Click += btnGuardarEnBD_Click_1;
            // 
            // btnGenerarWord
            // 
            btnGenerarWord.BackColor = Color.Gainsboro;
            btnGenerarWord.BackgroundImageLayout = ImageLayout.Center;
            btnGenerarWord.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarWord.Location = new Point(1044, 329);
            btnGenerarWord.Margin = new Padding(4, 3, 4, 3);
            btnGenerarWord.Name = "btnGenerarWord";
            btnGenerarWord.Size = new Size(144, 51);
            btnGenerarWord.TabIndex = 10;
            btnGenerarWord.Text = "Generar En Word";
            btnGenerarWord.UseVisualStyleBackColor = false;
            btnGenerarWord.Click += btnGenerarWord_Click_1;
            // 
            // btnAbrirCarpeta
            // 
            btnAbrirCarpeta.BackColor = Color.Gainsboro;
            btnAbrirCarpeta.BackgroundImageLayout = ImageLayout.Center;
            btnAbrirCarpeta.ForeColor = SystemColors.ActiveCaptionText;
            btnAbrirCarpeta.Location = new Point(1044, 471);
            btnAbrirCarpeta.Margin = new Padding(4, 3, 4, 3);
            btnAbrirCarpeta.Name = "btnAbrirCarpeta";
            btnAbrirCarpeta.Size = new Size(144, 51);
            btnAbrirCarpeta.TabIndex = 11;
            btnAbrirCarpeta.Text = "Abrir Carpeta";
            btnAbrirCarpeta.UseVisualStyleBackColor = false;
            btnAbrirCarpeta.Click += btnAbrirCarpeta_Click;
            // 
            // btnGenerarPowerPoint
            // 
            btnGenerarPowerPoint.BackColor = Color.Gainsboro;
            btnGenerarPowerPoint.BackgroundImageLayout = ImageLayout.Center;
            btnGenerarPowerPoint.ForeColor = SystemColors.ActiveCaptionText;
            btnGenerarPowerPoint.Location = new Point(1044, 397);
            btnGenerarPowerPoint.Margin = new Padding(4, 3, 4, 3);
            btnGenerarPowerPoint.Name = "btnGenerarPowerPoint";
            btnGenerarPowerPoint.Size = new Size(144, 51);
            btnGenerarPowerPoint.TabIndex = 12;
            btnGenerarPowerPoint.Text = "Generar En PowerPoint";
            btnGenerarPowerPoint.UseVisualStyleBackColor = false;
            btnGenerarPowerPoint.Click += btnGenerarPowerPoint_Click_1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            lblResultado.Location = new Point(175, 238);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 20);
            lblResultado.TabIndex = 13;
            lblResultado.Text = "Resultado";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Gainsboro;
            btnCerrar.BackgroundImageLayout = ImageLayout.Center;
            btnCerrar.ForeColor = SystemColors.ActiveCaptionText;
            btnCerrar.Location = new Point(1044, 799);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(144, 51);
            btnCerrar.TabIndex = 14;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pbLoading
            // 
            pbLoading.Image = (Image)resources.GetObject("pbLoading.Image");
            pbLoading.Location = new Point(436, 544);
            pbLoading.Name = "pbLoading";
            pbLoading.Size = new Size(397, 315);
            pbLoading.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLoading.TabIndex = 15;
            pbLoading.TabStop = false;
            pbLoading.Click += pbLoading_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = Properties.Resources.background_6556411;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1325, 891);
            Controls.Add(pbLoading);
            Controls.Add(btnCerrar);
            Controls.Add(lblResultado);
            Controls.Add(btnGenerarPowerPoint);
            Controls.Add(btnAbrirCarpeta);
            Controls.Add(btnGenerarWord);
            Controls.Add(btnGuardarEnBD);
            Controls.Add(btnRealizarInvestigacion);
            Controls.Add(txtPromptPersonalizado);
            Controls.Add(lblPromptPersonalizado);
            Controls.Add(rtbResultado);
            Controls.Add(lblEstado);
            Controls.Add(lblTemaInvestigacion);
            Controls.Add(txtTemaInvestigacion);
            Controls.Add(lblTitulo);
            Controls.Add(btnGenerarPrompt);
            Font = new Font("Maiandra GD", 10.2F, FontStyle.Bold);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerarPrompt;
        private Label lblTitulo;
        private TextBox txtTemaInvestigacion;
        private Label lblTemaInvestigacion;
        private Label lblEstado;
        private RichTextBox rtbResultado;
        private Label lblPromptPersonalizado;
        private TextBox txtPromptPersonalizado;
        private Button btnRealizarInvestigacion;
        private Button btnGuardarEnBD;
        private Button btnGenerarWord;
        private Button btnAbrirCarpeta;
        private Button btnGenerarPowerPoint;
        private Label lblResultado;
        private Button btnCerrar;
        private PictureBox pbLoading;
    }
}
