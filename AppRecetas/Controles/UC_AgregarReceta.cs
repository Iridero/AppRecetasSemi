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
    public partial class UC_AgregarReceta : UserControl
    {
        public UC_AgregarReceta()
        {
            InitializeComponent();
        }
        public Recetario Recetario { get; set; }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Recetario!=null)
            {
                Receta nueva = new Receta()
                {
                    Nombre = txtNombre.Text,
                    Ingredientes = txtIngredientes.Text,
                    Procedimiento = txtProcedimiento.Text,
                    Dificultad = (byte)nmrDificultad.Value
                };
                try
                {
                    Recetario.Agregar(nueva);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("El nombre ya esta registrado");
                }
            }
        }

        private void UC_AgregarReceta_Load(object sender, EventArgs e)
        {
           
        }
    }
}
