using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRecetas.Modelos
{
    [Serializable]
    public class Receta
    {
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string Procedimiento { get; set; }
        public byte Dificultad { get; set; }
    }
}
