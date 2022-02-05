using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace AppRecetas.Modelos
{
    [Serializable]
    public class Recetario
    {
        public event EventHandler<RecetaEventArgs> RecetaAgregada;
        public List<Receta> MisRecetas { get; private set; }

        /// <summary>
        /// Agregar una nueva receta al recetario
        /// </summary>
        /// <param name="receta">La receta a agregar</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void Agregar(Receta receta)
        {
            if (receta == null)
            {
                throw new ArgumentNullException();
            }
            if (MisRecetas == null)
            {
                MisRecetas = new List<Receta>();
            }
            if (MisRecetas.Any(r => r.Nombre == receta.Nombre))
            {
                throw new ArgumentException("Nombre de receta duplicado");
            }
            MisRecetas.Add(receta);
            RecetaAgregada?.Invoke(this, new RecetaEventArgs(receta));
        }


        public void Guardar()
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "recetario.dat");
            FileStream fs = new FileStream(ruta, FileMode.Create);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                bf.Serialize(fs, MisRecetas);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }
        public void Cargar()
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "recetario.dat");
            if (!File.Exists(ruta))
            {
                return;
            }
            FileStream fs = new FileStream(ruta, FileMode.Open);
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
#pragma warning disable SYSLIB0011 // El tipo o el miembro están obsoletos
                MisRecetas = (List<Receta>)bf.Deserialize(fs);
#pragma warning restore SYSLIB0011 // El tipo o el miembro están obsoletos
            }
            finally
            {
                fs.Close();
            }
        }
    }
    public class RecetaEventArgs : EventArgs
    {
        public Receta Receta { get; set; }
        public RecetaEventArgs(Receta receta)
        {
            this.Receta = receta;
        }
    }
}
