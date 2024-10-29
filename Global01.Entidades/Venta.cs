namespace Global01.Entidades
{
    public class Venta
    {
        public int Cantidad { get; set; }
        public Publicacion Publicacion { set; get; }
        public Venta(int cantidad, Publicacion publicacion)
        {
            Cantidad = cantidad;
            Publicacion = publicacion;
        }
    }
}

