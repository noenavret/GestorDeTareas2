using System;

namespace GestorTareas2
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; set; }

        public override string ToString()
        {
            return Completada ? "✔ " + Nombre : Nombre;
        }
    }
}
