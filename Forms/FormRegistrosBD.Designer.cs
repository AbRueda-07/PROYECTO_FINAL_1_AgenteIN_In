namespace InvestigadorAI_Final.Forms
{
    partial class FormRegistrosBD
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
            label1 = new Label();
            btnCerrar = new Button();
            btnEliminarResultadoPorId = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 22F, FontStyle.Bold);
            label1.Location = new Point(149, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(677, 46);
            label1.TabIndex = 2;
            label1.Text = "REGISTROS DE LA BASE DE DATOS";
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            btnCerrar.Location = new Point(997, 423);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(169, 65);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click_1;
            // 
            // btnEliminarResultadoPorId
            // 
            btnEliminarResultadoPorId.Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            btnEliminarResultadoPorId.Location = new Point(997, 326);
            btnEliminarResultadoPorId.Margin = new Padding(4, 3, 4, 3);
            btnEliminarResultadoPorId.Name = "btnEliminarResultadoPorId";
            btnEliminarResultadoPorId.Size = new Size(169, 76);
            btnEliminarResultadoPorId.TabIndex = 3;
            btnEliminarResultadoPorId.Text = "Eliminar Resultado Por ID";
            btnEliminarResultadoPorId.UseVisualStyleBackColor = true;
            btnEliminarResultadoPorId.Click += btnEliminarResultadoPorId_Click;
            // 
            // FormRegistrosBD
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_1839352_1920;
            ClientSize = new Size(1179, 610);
            Controls.Add(btnEliminarResultadoPorId);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Font = new Font("Rockwell", 10.2F, FontStyle.Bold);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormRegistrosBD";
            Text = "FormRegistrosBD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Prompt;
        private DataGridViewTextBoxColumn Resultado;
        private DataGridViewTextBoxColumn Fecha;
        private Label label1;
        private Button btnEliminarResultadoPorId;
    }
}