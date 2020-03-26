namespace SIGECLI.Departamentos
{
    partial class FFiltros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rabTodos = new System.Windows.Forms.RadioButton();
            this.rabDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rabHabilitado = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rabTodos);
            this.groupBox1.Controls.Add(this.rabDeshabilitado);
            this.groupBox1.Controls.Add(this.rabHabilitado);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // rabTodos
            // 
            this.rabTodos.AutoSize = true;
            this.rabTodos.Location = new System.Drawing.Point(498, 35);
            this.rabTodos.Name = "rabTodos";
            this.rabTodos.Size = new System.Drawing.Size(55, 17);
            this.rabTodos.TabIndex = 4;
            this.rabTodos.Text = "Todos";
            this.rabTodos.UseVisualStyleBackColor = true;
            this.rabTodos.CheckedChanged += new System.EventHandler(this.rabTodos_CheckedChanged);
            // 
            // rabDeshabilitado
            // 
            this.rabDeshabilitado.AutoSize = true;
            this.rabDeshabilitado.Location = new System.Drawing.Point(403, 35);
            this.rabDeshabilitado.Name = "rabDeshabilitado";
            this.rabDeshabilitado.Size = new System.Drawing.Size(89, 17);
            this.rabDeshabilitado.TabIndex = 3;
            this.rabDeshabilitado.Text = "Deshabilitado";
            this.rabDeshabilitado.UseVisualStyleBackColor = true;
            this.rabDeshabilitado.CheckedChanged += new System.EventHandler(this.rabDeshabilitado_CheckedChanged);
            // 
            // rabHabilitado
            // 
            this.rabHabilitado.AutoSize = true;
            this.rabHabilitado.Checked = true;
            this.rabHabilitado.Location = new System.Drawing.Point(325, 34);
            this.rabHabilitado.Name = "rabHabilitado";
            this.rabHabilitado.Size = new System.Drawing.Size(72, 17);
            this.rabHabilitado.TabIndex = 2;
            this.rabHabilitado.TabStop = true;
            this.rabHabilitado.Text = "Habilitado";
            this.rabHabilitado.UseVisualStyleBackColor = true;
            this.rabHabilitado.CheckedChanged += new System.EventHandler(this.rabHabilitado_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(6, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(300, 20);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el código o el nombre";
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.Location = new System.Drawing.Point(11, 19);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.Size = new System.Drawing.Size(544, 170);
            this.dgvDepartamentos.TabIndex = 1;
            this.dgvDepartamentos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDepartamentos);
            this.groupBox2.Location = new System.Drawing.Point(23, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 207);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista";
            // 
            // FFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 296);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FFiltros";
            this.Text = "FFiltros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rabTodos;
        private System.Windows.Forms.RadioButton rabDeshabilitado;
        private System.Windows.Forms.RadioButton rabHabilitado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}