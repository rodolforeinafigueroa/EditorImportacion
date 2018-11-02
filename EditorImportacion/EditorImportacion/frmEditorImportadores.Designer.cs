namespace EditorImportacion
{
    partial class frmEditorImportacion
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
            this.grpBoxFiltro = new System.Windows.Forms.GroupBox();
            this.numOrdenProceso = new System.Windows.Forms.NumericUpDown();
            this.numVersion = new System.Windows.Forms.NumericUpDown();
            this.numSubtipo = new System.Windows.Forms.NumericUpDown();
            this.numTipo = new System.Windows.Forms.NumericUpDown();
            this.txtIndDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipoProceso = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnActualizarScript = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btlGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEditor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgrdCampos = new System.Windows.Forms.DataGridView();
            this.f662_campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_tipo_dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_posicion_inicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_tipo_dato_sql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_ind_obligatorio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.f662_ind_complemento = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.f662_ind_select_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_orden_select_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_ind_signo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_nro_enteros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f662_nro_decimales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtGrdSubtipos = new System.Windows.Forms.DataGridView();
            this.chkDatosFiltro = new System.Windows.Forms.CheckBox();
            this.grpBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdenProceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubtipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).BeginInit();
            this.tabEditor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCampos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSubtipos)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxFiltro
            // 
            this.grpBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpBoxFiltro.Controls.Add(this.chkDatosFiltro);
            this.grpBoxFiltro.Controls.Add(this.numOrdenProceso);
            this.grpBoxFiltro.Controls.Add(this.numVersion);
            this.grpBoxFiltro.Controls.Add(this.numSubtipo);
            this.grpBoxFiltro.Controls.Add(this.numTipo);
            this.grpBoxFiltro.Controls.Add(this.txtIndDocumento);
            this.grpBoxFiltro.Controls.Add(this.label7);
            this.grpBoxFiltro.Controls.Add(this.txtTipoProceso);
            this.grpBoxFiltro.Controls.Add(this.label6);
            this.grpBoxFiltro.Controls.Add(this.label5);
            this.grpBoxFiltro.Controls.Add(this.btnActualizarScript);
            this.grpBoxFiltro.Controls.Add(this.txtDescripcion);
            this.grpBoxFiltro.Controls.Add(this.label4);
            this.grpBoxFiltro.Controls.Add(this.btlGuardar);
            this.grpBoxFiltro.Controls.Add(this.btnBuscar);
            this.grpBoxFiltro.Controls.Add(this.label3);
            this.grpBoxFiltro.Controls.Add(this.label2);
            this.grpBoxFiltro.Controls.Add(this.label1);
            this.grpBoxFiltro.Location = new System.Drawing.Point(12, 10);
            this.grpBoxFiltro.Name = "grpBoxFiltro";
            this.grpBoxFiltro.Size = new System.Drawing.Size(162, 381);
            this.grpBoxFiltro.TabIndex = 0;
            this.grpBoxFiltro.TabStop = false;
            // 
            // numOrdenProceso
            // 
            this.numOrdenProceso.Location = new System.Drawing.Point(98, 190);
            this.numOrdenProceso.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numOrdenProceso.Name = "numOrdenProceso";
            this.numOrdenProceso.Size = new System.Drawing.Size(58, 20);
            this.numOrdenProceso.TabIndex = 5;
            // 
            // numVersion
            // 
            this.numVersion.Location = new System.Drawing.Point(97, 68);
            this.numVersion.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numVersion.Name = "numVersion";
            this.numVersion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numVersion.Size = new System.Drawing.Size(59, 20);
            this.numVersion.TabIndex = 3;
            this.numVersion.Enter += new System.EventHandler(this.numVersion_Enter);
            // 
            // numSubtipo
            // 
            this.numSubtipo.Location = new System.Drawing.Point(97, 43);
            this.numSubtipo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSubtipo.Name = "numSubtipo";
            this.numSubtipo.Size = new System.Drawing.Size(59, 20);
            this.numSubtipo.TabIndex = 2;
            this.numSubtipo.Enter += new System.EventHandler(this.numSubtipo_Enter);
            // 
            // numTipo
            // 
            this.numTipo.Location = new System.Drawing.Point(97, 18);
            this.numTipo.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numTipo.Name = "numTipo";
            this.numTipo.Size = new System.Drawing.Size(59, 20);
            this.numTipo.TabIndex = 1;
            this.numTipo.Enter += new System.EventHandler(this.numTipo_Enter);
            // 
            // txtIndDocumento
            // 
            this.txtIndDocumento.Location = new System.Drawing.Point(97, 232);
            this.txtIndDocumento.Name = "txtIndDocumento";
            this.txtIndDocumento.Size = new System.Drawing.Size(59, 20);
            this.txtIndDocumento.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ind. Documento";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTipoProceso
            // 
            this.txtTipoProceso.Location = new System.Drawing.Point(97, 210);
            this.txtTipoProceso.Name = "txtTipoProceso";
            this.txtTipoProceso.Size = new System.Drawing.Size(59, 20);
            this.txtTipoProceso.TabIndex = 6;
            this.txtTipoProceso.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo proceso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Orden proceso";
            // 
            // btnActualizarScript
            // 
            this.btnActualizarScript.Location = new System.Drawing.Point(9, 347);
            this.btnActualizarScript.Name = "btnActualizarScript";
            this.btnActualizarScript.Size = new System.Drawing.Size(147, 23);
            this.btnActualizarScript.TabIndex = 10;
            this.btnActualizarScript.Text = "Ver Script de importación";
            this.btnActualizarScript.UseVisualStyleBackColor = true;
            this.btnActualizarScript.Click += new System.EventHandler(this.btnActualizarScript_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(6, 116);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 64);
            this.txtDescripcion.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Descripción";
            // 
            // btlGuardar
            // 
            this.btlGuardar.Location = new System.Drawing.Point(9, 318);
            this.btlGuardar.Name = "btlGuardar";
            this.btlGuardar.Size = new System.Drawing.Size(147, 23);
            this.btlGuardar.TabIndex = 9;
            this.btlGuardar.Text = "Generar script campos";
            this.btlGuardar.UseVisualStyleBackColor = true;
            this.btlGuardar.Click += new System.EventHandler(this.btlGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(6, 260);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(150, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subtipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabEditor
            // 
            this.tabEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEditor.Controls.Add(this.tabPage1);
            this.tabEditor.Controls.Add(this.tabPage2);
            this.tabEditor.Location = new System.Drawing.Point(180, 16);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.SelectedIndex = 0;
            this.tabEditor.Size = new System.Drawing.Size(391, 375);
            this.tabEditor.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dtgrdCampos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Campos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(273, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 22);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reordenar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dtgrdCampos
            // 
            this.dtgrdCampos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrdCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.f662_campo,
            this.f662_tipo_dato,
            this.f662_posicion_inicial,
            this.f662_tamano,
            this.f662_tipo_dato_sql,
            this.f662_ind_obligatorio,
            this.f662_ind_complemento,
            this.f662_ind_select_final,
            this.f662_orden_select_final,
            this.f662_descripcion,
            this.f662_observacion,
            this.f662_ind_signo,
            this.f662_nro_enteros,
            this.f662_nro_decimales});
            this.dtgrdCampos.Location = new System.Drawing.Point(3, 3);
            this.dtgrdCampos.Name = "dtgrdCampos";
            this.dtgrdCampos.Size = new System.Drawing.Size(377, 314);
            this.dtgrdCampos.TabIndex = 2;
            this.dtgrdCampos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdCampos_CellContentClick);
            // 
            // f662_campo
            // 
            this.f662_campo.DataPropertyName = "f662_campo";
            this.f662_campo.HeaderText = "Campo";
            this.f662_campo.Name = "f662_campo";
            // 
            // f662_tipo_dato
            // 
            this.f662_tipo_dato.DataPropertyName = "f662_tipo_dato";
            this.f662_tipo_dato.HeaderText = "Tipo de dato";
            this.f662_tipo_dato.Name = "f662_tipo_dato";
            this.f662_tipo_dato.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.f662_tipo_dato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // f662_posicion_inicial
            // 
            this.f662_posicion_inicial.DataPropertyName = "f662_posicion_inicial";
            this.f662_posicion_inicial.HeaderText = "Posicion inicial";
            this.f662_posicion_inicial.Name = "f662_posicion_inicial";
            // 
            // f662_tamano
            // 
            this.f662_tamano.DataPropertyName = "f662_tamano";
            this.f662_tamano.HeaderText = "Tamaño";
            this.f662_tamano.Name = "f662_tamano";
            // 
            // f662_tipo_dato_sql
            // 
            this.f662_tipo_dato_sql.DataPropertyName = "f662_tipo_dato_sql";
            this.f662_tipo_dato_sql.HeaderText = "Tipo dato SQL";
            this.f662_tipo_dato_sql.Name = "f662_tipo_dato_sql";
            // 
            // f662_ind_obligatorio
            // 
            this.f662_ind_obligatorio.DataPropertyName = "f662_ind_obligatorio";
            this.f662_ind_obligatorio.HeaderText = "Obligatorio";
            this.f662_ind_obligatorio.Name = "f662_ind_obligatorio";
            // 
            // f662_ind_complemento
            // 
            this.f662_ind_complemento.DataPropertyName = "f662_ind_complemento";
            this.f662_ind_complemento.HeaderText = "Complemento";
            this.f662_ind_complemento.Name = "f662_ind_complemento";
            // 
            // f662_ind_select_final
            // 
            this.f662_ind_select_final.DataPropertyName = "f662_ind_select_final";
            this.f662_ind_select_final.HeaderText = "Select final";
            this.f662_ind_select_final.Name = "f662_ind_select_final";
            // 
            // f662_orden_select_final
            // 
            this.f662_orden_select_final.DataPropertyName = "f662_orden_select_final";
            this.f662_orden_select_final.HeaderText = "Orden select final";
            this.f662_orden_select_final.Name = "f662_orden_select_final";
            // 
            // f662_descripcion
            // 
            this.f662_descripcion.DataPropertyName = "f662_descripcion";
            this.f662_descripcion.HeaderText = "Descripcion";
            this.f662_descripcion.Name = "f662_descripcion";
            // 
            // f662_observacion
            // 
            this.f662_observacion.DataPropertyName = "f662_observacion";
            this.f662_observacion.HeaderText = "Observacion";
            this.f662_observacion.Name = "f662_observacion";
            // 
            // f662_ind_signo
            // 
            this.f662_ind_signo.DataPropertyName = "f662_ind_signo";
            this.f662_ind_signo.HeaderText = "Signo";
            this.f662_ind_signo.Name = "f662_ind_signo";
            // 
            // f662_nro_enteros
            // 
            this.f662_nro_enteros.DataPropertyName = "f662_nro_enteros";
            this.f662_nro_enteros.HeaderText = "Nro. Enteros";
            this.f662_nro_enteros.Name = "f662_nro_enteros";
            // 
            // f662_nro_decimales
            // 
            this.f662_nro_decimales.DataPropertyName = "f662_nro_decimales";
            this.f662_nro_decimales.HeaderText = "Nro. Decimales";
            this.f662_nro_decimales.Name = "f662_nro_decimales";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtGrdSubtipos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 316);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subtipos con script";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtGrdSubtipos
            // 
            this.dtGrdSubtipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdSubtipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGrdSubtipos.Location = new System.Drawing.Point(3, 3);
            this.dtGrdSubtipos.Name = "dtGrdSubtipos";
            this.dtGrdSubtipos.Size = new System.Drawing.Size(377, 310);
            this.dtGrdSubtipos.TabIndex = 0;
            // 
            // chkDatosFiltro
            // 
            this.chkDatosFiltro.AutoSize = true;
            this.chkDatosFiltro.Location = new System.Drawing.Point(6, 295);
            this.chkDatosFiltro.Name = "chkDatosFiltro";
            this.chkDatosFiltro.Size = new System.Drawing.Size(153, 17);
            this.chkDatosFiltro.TabIndex = 16;
            this.chkDatosFiltro.Text = "Generar con datos del filtro";
            this.chkDatosFiltro.UseVisualStyleBackColor = true;
            // 
            // frmEditorImportacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 403);
            this.Controls.Add(this.tabEditor);
            this.Controls.Add(this.grpBoxFiltro);
            this.Name = "frmEditorImportacion";
            this.Text = "Editor de importadores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grpBoxFiltro.ResumeLayout(false);
            this.grpBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrdenProceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubtipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipo)).EndInit();
            this.tabEditor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdCampos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdSubtipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btlGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizarScript;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoProceso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIndDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabEditor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dtgrdCampos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown numVersion;
        private System.Windows.Forms.NumericUpDown numSubtipo;
        private System.Windows.Forms.NumericUpDown numTipo;
        private System.Windows.Forms.NumericUpDown numOrdenProceso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_tipo_dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_posicion_inicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_tamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_tipo_dato_sql;
        private System.Windows.Forms.DataGridViewCheckBoxColumn f662_ind_obligatorio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn f662_ind_complemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_ind_select_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_orden_select_final;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_observacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_ind_signo;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_nro_enteros;
        private System.Windows.Forms.DataGridViewTextBoxColumn f662_nro_decimales;
        private System.Windows.Forms.DataGridView dtGrdSubtipos;
        private System.Windows.Forms.CheckBox chkDatosFiltro;
    }
}

