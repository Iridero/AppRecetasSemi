
namespace AppRecetas
{
    partial class UC_Editar
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgRecetas = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgRecetas
            // 
            this.dtgRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Editar});
            this.dtgRecetas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgRecetas.Location = new System.Drawing.Point(0, 0);
            this.dtgRecetas.Name = "dtgRecetas";
            this.dtgRecetas.RowHeadersWidth = 51;
            this.dtgRecetas.RowTemplate.Height = 29;
            this.dtgRecetas.Size = new System.Drawing.Size(400, 400);
            this.dtgRecetas.TabIndex = 0;
            this.dtgRecetas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgRecetas_CellMouseClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Text = "Editar";
            this.Editar.Width = 70;
            // 
            // UC_Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtgRecetas);
            this.Name = "UC_Editar";
            this.Size = new System.Drawing.Size(400, 400);
            this.Load += new System.EventHandler(this.UC_Editar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgRecetas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgRecetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
    }
}
