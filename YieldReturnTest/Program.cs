namespace YieldReturnTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection products = new ProductCollection();

            products.Add(new Product() { Name = "Dzmeruk", Price = 100 });
            products.Add(new Product() { Name = "Bred", Price = 500 });
            products.Add(new Product() { Name = "Butter", Price = 1000 });
            products.Add(new Product() { Name = "Cheese", Price = 300 });

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}