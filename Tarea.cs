using System;

namespace GestorTareas2
{
    public class Tarea
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Completada { get; set; }
        public bool PrioridadAlta { get; set; }
        public string Categoria { get; set; }

        public override string ToString()
        {
            string prioridad = PrioridadAlta ? "🔥 " : "";
            string estado = Completada ? "✔ " : "";

            return $"{estado}{prioridad}{Nombre} ({Categoria})";
        }
    }
}