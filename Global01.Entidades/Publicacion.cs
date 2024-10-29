using System.Text;

namespace Global01.Entidades
{
    public abstract class Publicacion
    {
        public bool EsColor { get; }
        public bool HayStock { get; }
        public float Importe { get; }
        public string Nombre { get; set; }
        public int Stock { get; set; }

        public int GetStock() => Stock;

        protected Publicacion(float importe, string nombre, int stock)
        {
            Nombre = nombre;
            Stock = stock;
            Importe = importe;
        }
        protected Publicacion(float importe, string nombre)
        {
            Nombre = nombre;
            Importe = importe;
        }
        protected Publicacion(string nombre)
        {
            Nombre = nombre;
        }
        public int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
        public virtual StringBuilder ObtenerInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: { Nombre}");
            sb.AppendLine($"Color: {EsColor}");
            sb.AppendLine($"Importe: {Importe}");
            sb.AppendLine($"Stock: {Stock}");
            return sb;
        }
        public bool Equals(Publicacion publicacion)
        {
            return true;
        }
    }
}
