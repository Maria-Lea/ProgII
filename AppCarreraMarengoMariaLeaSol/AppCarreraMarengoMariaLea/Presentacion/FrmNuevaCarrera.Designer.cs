namespace AppCarreraMarengoMariaLea
{
    partial class FrmNuevaCarrera
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
            this.lblCarreraNro = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.rbt1erCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbt2doCuatrimestre = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpAnioCursado = new System.Windows.Forms.DateTimePicker();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Location = new System.Drawing.Point(38, 31);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(56, 13);
            this.lblCarreraNro.TabIndex = 0;
            this.lblCarreraNro.Text = "Carrera Nº";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(122, 69);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(122, 109);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(57, 13);
            this.lblAsignatura.TabIndex = 2;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Location = new System.Drawing.Point(122, 148);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(83, 13);
            this.lblAnioCursado.TabIndex = 3;
            this.lblAnioCursado.Text = "Año de Cursado";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(122, 182);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 4;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(238, 66);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(254, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(238, 101);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(254, 21);
            this.cboAsignatura.TabIndex = 6;
            // 
            // rbt1erCuatrimestre
            // 
            this.rbt1erCuatrimestre.AutoSize = true;
            this.rbt1erCuatrimestre.Location = new System.Drawing.Point(238, 180);
            this.rbt1erCuatrimestre.Name = "rbt1erCuatrimestre";
            this.rbt1erCuatrimestre.Size = new System.Drawing.Size(101, 17);
            this.rbt1erCuatrimestre.TabIndex = 7;
            this.rbt1erCuatrimestre.TabStop = true;
            this.rbt1erCuatrimestre.Text = "1er Cuatrimestre";
            this.rbt1erCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbt2doCuatrimestre
            // 
            this.rbt2doCuatrimestre.AutoSize = true;
            this.rbt2doCuatrimestre.Location = new System.Drawing.Point(407, 180);
            this.rbt2doCuatrimestre.Name = "rbt2doCuatrimestre";
            this.rbt2doCuatrimestre.Size = new System.Drawing.Size(104, 17);
            this.rbt2doCuatrimestre.TabIndex = 8;
            this.rbt2doCuatrimestre.TabStop = true;
            this.rbt2doCuatrimestre.Text = "2do Cuatrimestre";
            this.rbt2doCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(589, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(238, 406);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(372, 406);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.Location = new System.Drawing.Point(238, 141);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(254, 20);
            this.dtpAnioCursado.TabIndex = 12;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAsignacion,
            this.ColAnioCursado,
            this.ColCuatrimestre,
            this.ColAccion});
            this.dgvDetalle.Location = new System.Drawing.Point(125, 219);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(539, 150);
            this.dgvDetalle.TabIndex = 13;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // ColAsignacion
            // 
            this.ColAsignacion.HeaderText = "Asignacion";
            this.ColAsignacion.Name = "ColAsignacion";
            this.ColAsignacion.ReadOnly = true;
            this.ColAsignacion.Width = 150;
            // 
            // ColAnioCursado
            // 
            this.ColAnioCursado.HeaderText = "Año de Cursado";
            this.ColAnioCursado.Name = "ColAnioCursado";
            this.ColAnioCursado.ReadOnly = true;
            this.ColAnioCursado.Width = 115;
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            this.ColCuatrimestre.ReadOnly = true;
            this.ColCuatrimestre.Width = 115;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Width = 115;
            // 
            // FrmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbt2doCuatrimestre);
            this.Controls.Add(this.rbt1erCuatrimestre);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarreraNro);
            this.Name = "FrmNuevaCarrera";
            this.Text = "FrmNuevaCarrera";
            this.Load += new System.EventHandler(this.FrmNuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.RadioButton rbt1erCuatrimestre;
        private System.Windows.Forms.RadioButton rbt2doCuatrimestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpAnioCursado;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAnioCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
    }
}