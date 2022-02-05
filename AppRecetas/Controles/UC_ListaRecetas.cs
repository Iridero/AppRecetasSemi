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
    public partial class UC_ListaRecetas : UserControl
    {
        public Recetario Recetario { get;  set; }
        public UC_ListaRecetas()
        {
            InitializeComponent();
        }

        private void UC_ListaRecetas_Load(object sender, EventArgs e)
        {
            if (Recetario != null)
            {
                lstRecetas.DataSource = Recetario.MisRecetas;
                lstRecetas.DisplayMember = "Nombre";
            }
        }
    }
}
