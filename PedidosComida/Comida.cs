
namespace PedidosComida
{
    public class Comida
    {
        #region Atributos
        private string nombre;
        private float precio;
        private byte stock;
        private string descripicion;
        
        #endregion

        #region Propiedades
        public string Nombre { get => nombre; set => nombre = value; }
        public float Precio { get => precio; set => precio = value; }
        public byte Stock { get => stock; set => stock = value; }
        public string Descripicion { get => descripicion; set => descripicion = value; }
        #endregion

        #region Constructor
        public Comida(string nombre, float precio, byte stock, string descripicion)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            Descripicion = descripicion;
        }
        #endregion

    }
}
