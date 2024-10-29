using Global01.Entidades;

namespace Global01.Datos
{
    public class Serializador:IArchivo<Venta>
    {
        private string? archivo = "Publicaciones.txt";
        private string? nombreArchivo;
        private string? path = AppDomain.CurrentDomain.BaseDirectory;
        public Serializador()
        {
            nombreArchivo = Path.Combine(path, archivo);
        }

        public void Guardar(List<Venta> entidades)
        {
            throw new NotImplementedException();
        }

        public List<Venta> Leer()
        {
            throw new NotImplementedException();
        }
    }
}
