using testGithub.Data;
using testGithub.Models;


namespace testGithub
{
    public class Program
    {
        static void Main(string[] args)
        {
            using ContosoPizzaContext context = new ContosoPizzaContext();
            var VeggiePizza = context.Products.Where(p => p.Name == "Veggie Special Pizza").FirstOrDefault();
            if (VeggiePizza is Product)
            {
                VeggiePizza.Price = 10.9M;
            }
            context.SaveChanges();


            var products = context.Products.Where(p => p.Price > 10.00M)
                                            .OrderBy(p => p.Id); 
            foreach (var p in products) 
            {
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Price);
                Console.WriteLine(new string('-',20));
            
            }
        }
    }
}