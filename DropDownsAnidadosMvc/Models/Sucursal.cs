namespace DropDownsAnidadosMvc.Models
{
    public class Sucursal
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        //Relacion uno a muchos con Categoria
        public ICollection<Categoria> Categorias { get; set; }
    }
}
