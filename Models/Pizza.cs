namespace PizzaPie.Models
{
    public record Pizza
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Double? Price { get; set; }
    }
}
