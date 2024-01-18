
namespace FarmaciaUnir
{
    partial class frmPedido
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
            lblNombreMedicamento = new System.Windows.Forms.Label();
            lblTipoMedicamento = new System.Windows.Forms.Label();
            lblCantidad = new System.Windows.Forms.Label();
            lblDistribuidor = new System.Windows.Forms.Label();
            lblSucursal = new System.Windows.Forms.Label();
            txtNombreMedicamento = new System.Windows.Forms.TextBox();
            txtCantidad = new System.Windows.Forms.TextBox();
            cmbTipoMedicamento = new System.Windows.Forms.ComboBox();
            cmbDistribuidor = new System.Windows.Forms.ComboBox();
            chkPrincipal = new System.Windows.Forms.CheckBox();
            chkSecundaria = new System.Windows.Forms.CheckBox();
            btnBorrar = new System.Windows.Forms.Button();
            btnConfirmar = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblErrorNombre = new System.Windows.Forms.Label();
            lblErrorTipo = new System.Windows.Forms.Label();
            lblErrorCantidad = new System.Windows.Forms.Label();
            lblErrorDistribuidor = new System.Windows.Forms.Label();
            lblErrorSucursal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblNombreMedicamento.Location = new System.Drawing.Point(12, 105);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new System.Drawing.Size(156, 15);
            lblNombreMedicamento.TabIndex = 0;
            lblNombreMedicamento.Text = "Nombre del medicamento:";
            // 
            // lblTipoMedicamento
            // 
            lblTipoMedicamento.AutoSize = true;
            lblTipoMedicamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTipoMedicamento.Location = new System.Drawing.Point(12, 160);
            lblTipoMedicamento.Name = "lblTipoMedicamento";
            lblTipoMedicamento.Size = new System.Drawing.Size(131, 15);
            lblTipoMedicamento.TabIndex = 1;
            lblTipoMedicamento.Text = "Tipo de medicamento:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblCantidad.Location = new System.Drawing.Point(12, 214);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new System.Drawing.Size(58, 15);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblDistribuidor
            // 
            lblDistribuidor.AutoSize = true;
            lblDistribuidor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblDistribuidor.Location = new System.Drawing.Point(12, 266);
            lblDistribuidor.Name = "lblDistribuidor";
            lblDistribuidor.Size = new System.Drawing.Size(159, 15);
            lblDistribuidor.TabIndex = 3;
            lblDistribuidor.Text = "Distribuidaor farmacéutico:";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSucursal.Location = new System.Drawing.Point(12, 312);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new System.Drawing.Size(136, 15);
            lblSucursal.TabIndex = 4;
            lblSucursal.Text = "Sucursal de la farmacia:";
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new System.Drawing.Point(189, 102);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new System.Drawing.Size(391, 23);
            txtNombreMedicamento.TabIndex = 1;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new System.Drawing.Point(189, 211);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new System.Drawing.Size(391, 23);
            txtCantidad.TabIndex = 3;
            // 
            // cmbTipoMedicamento
            // 
            cmbTipoMedicamento.FormattingEnabled = true;
            cmbTipoMedicamento.Items.AddRange(new object[] { "Analgésico", "Analéctico", "Anestésico", "Antiácido", "Antidepresivo", "Antibióticos" });
            cmbTipoMedicamento.Location = new System.Drawing.Point(189, 157);
            cmbTipoMedicamento.Name = "cmbTipoMedicamento";
            cmbTipoMedicamento.Size = new System.Drawing.Size(391, 23);
            cmbTipoMedicamento.TabIndex = 2;
            // 
            // cmbDistribuidor
            // 
            cmbDistribuidor.FormattingEnabled = true;
            cmbDistribuidor.Items.AddRange(new object[] { "Cofarma", "Empsephar", "Cemefar" });
            cmbDistribuidor.Location = new System.Drawing.Point(189, 263);
            cmbDistribuidor.Name = "cmbDistribuidor";
            cmbDistribuidor.Size = new System.Drawing.Size(391, 23);
            cmbDistribuidor.TabIndex = 4;
            // 
            // chkPrincipal
            // 
            chkPrincipal.AutoSize = true;
            chkPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkPrincipal.Location = new System.Drawing.Point(189, 311);
            chkPrincipal.Name = "chkPrincipal";
            chkPrincipal.Size = new System.Drawing.Size(73, 19);
            chkPrincipal.TabIndex = 5;
            chkPrincipal.Text = "Principal";
            chkPrincipal.UseVisualStyleBackColor = true;
            // 
            // chkSecundaria
            // 
            chkSecundaria.AutoSize = true;
            chkSecundaria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            chkSecundaria.Location = new System.Drawing.Point(317, 311);
            chkSecundaria.Name = "chkSecundaria";
            chkSecundaria.Size = new System.Drawing.Size(87, 19);
            chkSecundaria.TabIndex = 6;
            chkSecundaria.Text = "Secundaria";
            chkSecundaria.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBorrar.Location = new System.Drawing.Point(421, 357);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(75, 23);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConfirmar.Location = new System.Drawing.Point(505, 357);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new System.Drawing.Size(75, 23);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Unir_2021_logo;
            pictureBox1.Location = new System.Drawing.Point(115, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(381, 65);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            lblErrorNombre.Location = new System.Drawing.Point(189, 128);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new System.Drawing.Size(143, 15);
            lblErrorNombre.TabIndex = 13;
            lblErrorNombre.Text = "Este campo es obligatorio";
            lblErrorNombre.Visible = false;
            // 
            // lblErrorTipo
            // 
            lblErrorTipo.AutoSize = true;
            lblErrorTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorTipo.ForeColor = System.Drawing.Color.Red;
            lblErrorTipo.Location = new System.Drawing.Point(189, 183);
            lblErrorTipo.Name = "lblErrorTipo";
            lblErrorTipo.Size = new System.Drawing.Size(230, 15);
            lblErrorTipo.TabIndex = 14;
            lblErrorTipo.Text = "Debe seleccionar un tipo de medicamento";
            lblErrorTipo.Visible = false;
            // 
            // lblErrorCantidad
            // 
            lblErrorCantidad.AutoSize = true;
            lblErrorCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorCantidad.ForeColor = System.Drawing.Color.Red;
            lblErrorCantidad.Location = new System.Drawing.Point(189, 237);
            lblErrorCantidad.Name = "lblErrorCantidad";
            lblErrorCantidad.Size = new System.Drawing.Size(215, 15);
            lblErrorCantidad.TabIndex = 15;
            lblErrorCantidad.Text = "Debe digitar un número entero positivo";
            lblErrorCantidad.Visible = false;
            // 
            // lblErrorDistribuidor
            // 
            lblErrorDistribuidor.AutoSize = true;
            lblErrorDistribuidor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorDistribuidor.ForeColor = System.Drawing.Color.Red;
            lblErrorDistribuidor.Location = new System.Drawing.Point(189, 289);
            lblErrorDistribuidor.Name = "lblErrorDistribuidor";
            lblErrorDistribuidor.Size = new System.Drawing.Size(245, 15);
            lblErrorDistribuidor.TabIndex = 16;
            lblErrorDistribuidor.Text = "Debe seleccionar el distribuidor farmacéutico";
            lblErrorDistribuidor.Visible = false;
            // 
            // lblErrorSucursal
            // 
            lblErrorSucursal.AutoSize = true;
            lblErrorSucursal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblErrorSucursal.ForeColor = System.Drawing.Color.Red;
            lblErrorSucursal.Location = new System.Drawing.Point(188, 333);
            lblErrorSucursal.Name = "lblErrorSucursal";
            lblErrorSucursal.Size = new System.Drawing.Size(216, 15);
            lblErrorSucursal.TabIndex = 17;
            lblErrorSucursal.Text = "Debe seleccionar al menos una sucursal";
            lblErrorSucursal.Visible = false;
            // 
            // frmPedido
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(595, 392);
            Controls.Add(lblErrorSucursal);
            Controls.Add(lblErrorDistribuidor);
            Controls.Add(lblErrorCantidad);
            Controls.Add(lblErrorTipo);
            Controls.Add(lblErrorNombre);
            Controls.Add(pictureBox1);
            Controls.Add(btnConfirmar);
            Controls.Add(btnBorrar);
            Controls.Add(chkSecundaria);
            Controls.Add(chkPrincipal);
            Controls.Add(cmbDistribuidor);
            Controls.Add(cmbTipoMedicamento);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombreMedicamento);
            Controls.Add(lblSucursal);
            Controls.Add(lblDistribuidor);
            Controls.Add(lblCantidad);
            Controls.Add(lblTipoMedicamento);
            Controls.Add(lblNombreMedicamento);
            MaximizeBox = false;
            Name = "frmPedido";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombreMedicamento;
        private System.Windows.Forms.Label lblTipoMedicamento;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblDistribuidor;
        private System.Windows.Forms.Label lblSucursal;
        private System.Windows.Forms.TextBox txtNombreMedicamento;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbTipoMedicamento;
        private System.Windows.Forms.ComboBox cmbDistribuidor;
        private System.Windows.Forms.CheckBox chkPrincipal;
        private System.Windows.Forms.CheckBox chkSecundaria;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorTipo;
        private System.Windows.Forms.Label lblErrorCantidad;
        private System.Windows.Forms.Label lblErrorDistribuidor;
        private System.Windows.Forms.Label lblErrorSucursal;
    }
}

