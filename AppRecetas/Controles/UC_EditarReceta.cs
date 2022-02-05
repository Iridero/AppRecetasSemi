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

namespace AppRecetas.Controles
{
    public partial class UC_EditarReceta : UserControl
    {
        public event EventHandler<RecetaEventArgs> RecetaActualizada;
        public UC_EditarReceta()
        {
            InitializeComponent();
        }
        public Recetario Recetario { get; set; }
        public Receta Editando { get; set; }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Editando.Nombre = txtNombre.Text;
            Editando.Ingredientes = txtIngredientes.Text;
            Editando.Procedimiento = txtProcedimiento.Text;
            Editando.Dificultad = (byte)nmrDificultad.Value;
            RecetaActualizada?.Invoke(this, new RecetaEventArgs(Editando));
        }

        private void UC_EditarReceta_Load(object sender, EventArgs e)
        {
            if (Editando!=null)
            {
                txtNombre.Text = Editando.Nombre;
                txtIngredientes.Text = Editando.Ingredientes;
                txtProcedimiento.Text = Editando.Procedimiento;
                nmrDificultad.Value = Editando.Dificultad;
            }
        }
    }
}
