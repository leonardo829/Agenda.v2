namespace Agenda
{
    partial class Agenda
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnContactos = new System.Windows.Forms.Button();
            this.lblAgenda = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtTelefonoB = new System.Windows.Forms.TextBox();
            this.lblTelefonoB = new System.Windows.Forms.Label();
            this.btnNuevoContacto = new System.Windows.Forms.Button();
            this.lblNombreR = new System.Windows.Forms.Label();
            this.lblTelefonoR = new System.Windows.Forms.Label();
            this.lblMailR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContactos
            // 
            this.btnContactos.AutoEllipsis = true;
            this.btnContactos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContactos.BackColor = System.Drawing.Color.Black;
            this.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnContactos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactos.ForeColor = System.Drawing.Color.LightGray;
            this.btnContactos.Location = new System.Drawing.Point(0, 590);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(698, 64);
            this.btnContactos.TabIndex = 0;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.UseVisualStyleBackColor = false;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // lblAgenda
            // 
            this.lblAgenda.AutoEllipsis = true;
            this.lblAgenda.BackColor = System.Drawing.Color.Transparent;
            this.lblAgenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAgenda.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAgenda.Location = new System.Drawing.Point(55, 9);
            this.lblAgenda.Name = "lblAgenda";
            this.lblAgenda.Size = new System.Drawing.Size(588, 45);
            this.lblAgenda.TabIndex = 1;
            this.lblAgenda.Text = "Nuevo Contacto";
            this.lblAgenda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(81, 110);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(534, 38);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoEllipsis = true;
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(288, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 28);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoEllipsis = true;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTelefono.Location = new System.Drawing.Point(288, 171);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(107, 28);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Silver;
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(81, 202);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(534, 38);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoEllipsis = true;
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEmail.Location = new System.Drawing.Point(300, 256);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 28);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "e-Mail";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.Silver;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(81, 287);
            this.txtMail.Multiline = true;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(534, 38);
            this.txtMail.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregar.Location = new System.Drawing.Point(289, 331);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(106, 38);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 429);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoEllipsis = true;
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Gadugi", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(420, 495);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 38);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtTelefonoB
            // 
            this.txtTelefonoB.BackColor = System.Drawing.Color.Silver;
            this.txtTelefonoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonoB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoB.Location = new System.Drawing.Point(187, 494);
            this.txtTelefonoB.Name = "txtTelefonoB";
            this.txtTelefonoB.Size = new System.Drawing.Size(227, 39);
            this.txtTelefonoB.TabIndex = 13;
            // 
            // lblTelefonoB
            // 
            this.lblTelefonoB.AutoEllipsis = true;
            this.lblTelefonoB.AutoSize = true;
            this.lblTelefonoB.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefonoB.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoB.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTelefonoB.Location = new System.Drawing.Point(252, 463);
            this.lblTelefonoB.Name = "lblTelefonoB";
            this.lblTelefonoB.Size = new System.Drawing.Size(107, 28);
            this.lblTelefonoB.TabIndex = 14;
            this.lblTelefonoB.Text = "Telefono";
            // 
            // btnNuevoContacto
            // 
            this.btnNuevoContacto.AutoEllipsis = true;
            this.btnNuevoContacto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevoContacto.BackColor = System.Drawing.Color.Black;
            this.btnNuevoContacto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoContacto.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoContacto.ForeColor = System.Drawing.Color.LightGray;
            this.btnNuevoContacto.Location = new System.Drawing.Point(0, 592);
            this.btnNuevoContacto.Name = "btnNuevoContacto";
            this.btnNuevoContacto.Size = new System.Drawing.Size(698, 62);
            this.btnNuevoContacto.TabIndex = 15;
            this.btnNuevoContacto.Text = "Nuevo Contacto";
            this.btnNuevoContacto.UseVisualStyleBackColor = false;
            this.btnNuevoContacto.Click += new System.EventHandler(this.btnNuevoContacto_Click);
            // 
            // lblNombreR
            // 
            this.lblNombreR.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreR.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombreR.Location = new System.Drawing.Point(90, 548);
            this.lblNombreR.Name = "lblNombreR";
            this.lblNombreR.Size = new System.Drawing.Size(151, 27);
            this.lblNombreR.TabIndex = 16;
            this.lblNombreR.Visible = false;
            // 
            // lblTelefonoR
            // 
            this.lblTelefonoR.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoR.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefonoR.Location = new System.Drawing.Point(264, 548);
            this.lblTelefonoR.Name = "lblTelefonoR";
            this.lblTelefonoR.Size = new System.Drawing.Size(140, 27);
            this.lblTelefonoR.TabIndex = 17;
            this.lblTelefonoR.Visible = false;
            // 
            // lblMailR
            // 
            this.lblMailR.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailR.ForeColor = System.Drawing.Color.LightGray;
            this.lblMailR.Location = new System.Drawing.Point(434, 548);
            this.lblMailR.Name = "lblMailR";
            this.lblMailR.Size = new System.Drawing.Size(143, 27);
            this.lblMailR.TabIndex = 18;
            this.lblMailR.Visible = false;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Agenda.Properties.Resources.fondo_agenda;
            this.ClientSize = new System.Drawing.Size(698, 654);
            this.Controls.Add(this.lblMailR);
            this.Controls.Add(this.lblTelefonoR);
            this.Controls.Add(this.lblNombreR);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTelefonoB);
            this.Controls.Add(this.txtTelefonoB);
            this.Controls.Add(this.lblAgenda);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnContactos);
            this.Controls.Add(this.btnNuevoContacto);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Agenda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Label lblAgenda;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTelefonoB;
        private System.Windows.Forms.TextBox txtTelefonoB;
        private System.Windows.Forms.Button btnNuevoContacto;
        private System.Windows.Forms.Label lblMailR;
        private System.Windows.Forms.Label lblTelefonoR;
        private System.Windows.Forms.Label lblNombreR;
    }
}

