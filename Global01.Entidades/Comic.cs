namespace Global01.Entidades
{
    public class Comic : Publicacion
    {
        public bool EsColor { get; set; }
        public Comic(float importe, string nombre, int stock, bool esColor)
            : base(importe, nombre, stock)
        {
            EsColor = esColor;
        }

    }


}
