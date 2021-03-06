﻿namespace ProyectoTiempos.Vistas
{
    partial class FrmCrearSorteo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.dtgSorteo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbHabilitar = new System.Windows.Forms.RadioButton();
            this.rbDeshabilitar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSorteo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generar codigo de sorteo";
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.Location = new System.Drawing.Point(236, 42);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(46, 17);
            this.lblSerial.TabIndex = 2;
            this.lblSerial.Text = "label2";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(355, 34);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Sorteo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(224, 203);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista de Sorteos registrados";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(568, 159);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
          
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 137);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(268, 22);
            this.txtDescripcion.TabIndex = 11;
            // 
            // dtHora
            // 
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(173, 89);
            this.dtHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(169, 22);
            this.dtHora.TabIndex = 12;
            // 
            // dtgSorteo
            // 
            this.dtgSorteo.AllowUserToAddRows = false;
            this.dtgSorteo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSorteo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.name,
            this.phone,
            this.Estado,
            this.Codigo});
            this.dtgSorteo.Location = new System.Drawing.Point(13, 265);
            this.dtgSorteo.Margin = new System.Windows.Forms.Padding(4);
            this.dtgSorteo.Name = "dtgSorteo";
            this.dtgSorteo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSorteo.Size = new System.Drawing.Size(731, 320);
            this.dtgSorteo.TabIndex = 14;
            this.dtgSorteo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSorteo_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "descripcion";
            this.name.HeaderText = "Descripcion";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Fecha";
            this.phone.HeaderText = "Fecha";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDeshabilitar);
            this.panel1.Controls.Add(this.rbHabilitar);
            this.panel1.Location = new System.Drawing.Point(492, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 37);
            this.panel1.TabIndex = 15;
            // 
            // rbHabilitar
            // 
            this.rbHabilitar.AutoSize = true;
            this.rbHabilitar.Location = new System.Drawing.Point(3, 13);
            this.rbHabilitar.Name = "rbHabilitar";
            this.rbHabilitar.Size = new System.Drawing.Size(81, 21);
            this.rbHabilitar.TabIndex = 0;
            this.rbHabilitar.TabStop = true;
            this.rbHabilitar.Text = "Habilitar";
            this.rbHabilitar.UseVisualStyleBackColor = true;
            // 
            // rbDeshabilitar
            // 
            this.rbDeshabilitar.AutoSize = true;
            this.rbDeshabilitar.Location = new System.Drawing.Point(139, 13);
            this.rbDeshabilitar.Name = "rbDeshabilitar";
            this.rbDeshabilitar.Size = new System.Drawing.Size(104, 21);
            this.rbDeshabilitar.TabIndex = 1;
            this.rbDeshabilitar.TabStop = true;
            this.rbDeshabilitar.Text = "Deshabilitar";
            this.rbDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(514, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Habilite o deshabilite un Sorteo.";
            // 
            // FrmCrearSorteo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 588);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgSorteo);
            this.Controls.Add(this.dtHora);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblSerial);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCrearSorteo";
            this.Text = "FrmHabilitar";
            ((System.ComponentModel.ISupportInitialize)(this.dtgSorteo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.DataGridView dtgSorteo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDeshabilitar;
        private System.Windows.Forms.RadioButton rbHabilitar;
        private System.Windows.Forms.Label label5;
    }
}