namespace testGithub.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; } = null!;

        public Product Product { get; set; } = null!;

    }
}