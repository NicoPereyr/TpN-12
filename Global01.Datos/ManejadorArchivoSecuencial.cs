using Global01.Entidades;

namespace Global01.Datos
{
    public class ManejadorArchivoSecuencial:IArchivo<Publicacion>
    {
        private string? archivo = "Publicaciones.txt";
        private string? nombreArchivo;
        private string? path = AppDomain.CurrentDomain.BaseDirectory;
        public ManejadorArchivoSecuencial()
        {
            nombreArchivo=Path.Combine(path, archivo);
        }
        public void Guardar(List<Publicacion> entidades)
        {
            using (var writer=new StreamWriter(nombreArchivo))
            {
                foreach (var item in entidades)
                {
                    var linea = ConstruirLinea(item);
                    writer.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(Publicacion item)
        {
            string linea=$"{item.Nombre}|{item.Stock}|{item.Importe}";
            if(item.GetType()==typeof(Comic))
            {
                linea += $"{item.EsColor}";
            }
            return linea;
        }

        public List<Publicacion> Leer()
        {
            List<Publicacion> lista= new List<Publicacion>();
            if (!File.Exists(nombreArchivo)) {
                using (var reader=new StreamReader(nombreArchivo))
                {
                    while (!reader.EndOfStream)
                    {
                        var lineaLeida = reader.ReadLine();
                        Publicacion publicacion=ConstuirPublicacion(lineaLeida);
                        lista.Add(publicacion);
                    }
                } 
            }
            return lista;
        }

        private Publicacion ConstuirPublicacion(string? lineaLeida)
        {
            var campos = lineaLeida.Split('|');
            var nombre = campos[0];
            var stock=int.Parse(campos[1]);
            var importe=float.Parse(campos[2]);
            if (campos.Length > 3) {
                var esColor = bool.Parse(campos[3]);
                return new Comic(importe,nombre,stock,esColor);
            }
            return new Biografia(importe, nombre, stock);
        }
    }
}
