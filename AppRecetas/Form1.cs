using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppRecetas.Controles;
using AppRecetas.Modelos;
namespace AppRecetas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Recetario miRecetario = new Recetario();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            panelAcciones.Controls.Clear();
            UC_AgregarReceta control = new UC_AgregarReceta();
            control.Recetario = miRecetario;
            panelAcciones.Controls.Add(control);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelAcciones.Controls.Clear();
            UC_ListaRecetas control = new UC_ListaRecetas();
            control.Recetario = miRecetario;
            panelAcciones.Controls.Add(control);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            miRecetario.Cargar();
            miRecetario.RecetaAgregada += MiRecetario_RecetaAgregada;
        }

        private void MiRecetario_RecetaAgregada(object sender, RecetaEventArgs e)
        {
            miRecetario.Guardar();
            panelAcciones.Controls.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            panelAcciones.Controls.Clear();
            UC_Editar control = new UC_Editar();
            control.Recetario = miRecetario;
            control.RecetaSeleccionada += Control_RecetaSeleccionada;
            panelAcciones.Controls.Add(control);

        }

        private void Control_RecetaSeleccionada(object sender, RecetaEventArgs e)
        {
            panelAcciones.Controls.Clear();
            UC_EditarReceta control = new UC_EditarReceta();
            control.Editando = e.Receta;
            control.Recetario = miRecetario;
            control.RecetaActualizada += Control_RecetaActualizada;
            panelAcciones.Controls.Add(control);

        }

        private void Control_RecetaActualizada(object sender, RecetaEventArgs e)
        {
            miRecetario.Guardar();
            panelAcciones.Controls.Clear();
        }
    }
}
