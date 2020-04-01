namespace SIGECLI.Ciudades
{
    partial class FFiltroCiudad
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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.rdbHabilitado = new System.Windows.Forms.RadioButton();
            this.rdbDeshabilitado = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escriba el nombre de la ciudad";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(14, 25);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(308, 20);
            this.txtFiltro.TabIndex = 1;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(14, 64);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(307, 21);
            this.cmbDepartamento.TabIndex = 2;
            this.cmbDepartamento.Text = "Seleccione el departamento";
            // 
            // rdbHabilitado
            // 
            this.rdbHabilitado.AutoSize = true;
            this.rdbHabilitado.Checked = true;
            this.rdbHabilitado.Location = new System.Drawing.Point(14, 91);
            this.rdbHabilitado.Name = "rdbHabilitado";
            this.rdbHabilitado.Size = new System.Drawing.Size(72, 17);
            this.rdbHabilitado.TabIndex = 3;
            this.rdbHabilitado.TabStop = true;
            this.rdbHabilitado.Text = "Habilitado";
            this.rdbHabilitado.UseVisualStyleBackColor = true;
            // 
            // rdbDeshabilitado
            // 
            this.rdbDeshabilitado.AutoSize = true;
            this.rdbDeshabilitado.Location = new System.Drawing.Point(131, 91);
            this.rdbDeshabilitado.Name = "rdbDeshabilitado";
            this.rdbDeshabilitado.Size = new System.Drawing.Size(89, 17);
            this.rdbDeshabilitado.TabIndex = 4;
            this.rdbDeshabilitado.Text = "Deshabilitado";
            this.rdbDeshabilitado.UseVisualStyleBackColor = true;
            // 
            // rdbTodos
            // 
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(265, 91);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(55, 17);
            this.rdbTodos.TabIndex = 5;
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 182);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el departamento";
            // 
            // FFiltroCiudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 313);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbTodos);
            this.Controls.Add(this.rdbDeshabilitado);
            this.Controls.Add(this.rdbHabilitado);
            this.Controls.Add(this.cmbDepartamento);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.label1);
            this.Name = "FFiltroCiudad";
            this.Text = "FFiltroCiudad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.RadioButton rdbHabilitado;
        private System.Windows.Forms.RadioButton rdbDeshabilitado;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}