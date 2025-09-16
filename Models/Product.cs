namespace fractal_back.Models
{
	public class Product
    {
        public int Id { get; set; }             
        public string Name { get; set; } = string.Empty;  
        public decimal Price { get; set; }    
        public int Quantity { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }
}
