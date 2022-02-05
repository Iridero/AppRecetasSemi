using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRecetas.Modelos;

namespace AppRecetas
{
    public partial class UC_Editar : UserControl
    {
        public event EventHandler<RecetaEventArgs> RecetaSeleccionada;
        public UC_Editar()
        {
            InitializeComponent();
        }
        public Recetario Recetario { get; set; }
        private void UC_Editar_Load(object sender, EventArgs e)
        {
            dtgRecetas.AutoGenerateColumns = false;
            dtgRecetas.DataSource = Recetario.MisRecetas;
        }

        private void dtgRecetas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                Receta seleccionada = (Receta)dtgRecetas.Rows[e.RowIndex].DataBoundItem;
                RecetaSeleccionada?.Invoke(this, new RecetaEventArgs(seleccionada));
            }
        }

        
    }
    
}
