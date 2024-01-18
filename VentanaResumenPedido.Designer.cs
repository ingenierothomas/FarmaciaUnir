namespace FarmaciaUnir
{
    partial class VentanaResumenPedido
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
            lblTextoMedicamento = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTextoDireccion = new System.Windows.Forms.Label();
            btnCancelarPedido = new System.Windows.Forms.Button();
            btnEnviarPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTextoMedicamento
            // 
            lblTextoMedicamento.AutoSize = true;
            lblTextoMedicamento.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTextoMedicamento.Location = new System.Drawing.Point(12, 109);
            lblTextoMedicamento.Name = "lblTextoMedicamento";
            lblTextoMedicamento.Size = new System.Drawing.Size(179, 28);
            lblTextoMedicamento.TabIndex = 0;
            lblTextoMedicamento.Text = "TextoMedicamento";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Unir_2021_logo;
            pictureBox1.Location = new System.Drawing.Point(108, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(607, 94);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // lblTextoDireccion
            // 
            lblTextoDireccion.AutoSize = true;
            lblTextoDireccion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTextoDireccion.Location = new System.Drawing.Point(12, 153);
            lblTextoDireccion.Name = "lblTextoDireccion";
            lblTextoDireccion.Size = new System.Drawing.Size(140, 28);
            lblTextoDireccion.TabIndex = 14;
            lblTextoDireccion.Text = "TextoDirección";
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Location = new System.Drawing.Point(531, 220);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new System.Drawing.Size(125, 23);
            btnCancelarPedido.TabIndex = 15;
            btnCancelarPedido.Text = "Cancelar Pedido";
            btnCancelarPedido.UseVisualStyleBackColor = true;
            btnCancelarPedido.Click += btnCancelarPedido_Click;
            // 
            // btnEnviarPedido
            // 
            btnEnviarPedido.Location = new System.Drawing.Point(662, 220);
            btnEnviarPedido.Name = "btnEnviarPedido";
            btnEnviarPedido.Size = new System.Drawing.Size(124, 23);
            btnEnviarPedido.TabIndex = 16;
            btnEnviarPedido.Text = "Enviar Pedido";
            btnEnviarPedido.UseVisualStyleBackColor = true;
            btnEnviarPedido.Click += btnEnviarPedido_Click;
            // 
            // VentanaResumenPedido
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(798, 255);
            Controls.Add(btnEnviarPedido);
            Controls.Add(btnCancelarPedido);
            Controls.Add(lblTextoDireccion);
            Controls.Add(pictureBox1);
            Controls.Add(lblTextoMedicamento);
            Name = "VentanaResumenPedido";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTextoMedicamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTextoDireccion;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnEnviarPedido;
    }
}