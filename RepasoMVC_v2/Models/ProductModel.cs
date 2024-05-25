namespace RepasoMVC_v2.Models
{
    public class ProductModel
    {
        public Guid Id { get; set;}

        public string? Nombre { get; set;}

        public string? Marca { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }
    }

}