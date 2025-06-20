namespace DropDownsAnidadosMvc.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //foreign key
        public int SucursalId { get; set; }

        //Propiedad de navegacion
        public Sucursal Sucursal { get; set; }

        //Relacion uno a muchos con Producto
        public ICollection<Producto> Productos { get; set; }
    }
}
