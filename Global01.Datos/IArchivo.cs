namespace Global01.Datos
{
    public interface IArchivo<T> where T:class
    {
        void Guardar (List<T>entidades);
        List<T> Leer();
    }
}
