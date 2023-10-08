using Dotnet6_DesignPattern.FactoryMethod.Discount;

namespace Dotnet6_DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            Console.WriteLine("--------------");

            var factories = new List<DiscountFactory>
            {
                new CodeDiscountFactory(Guid.NewGuid()),
                new CountryDiscountFactory("PE")
            };

            foreach (var factory in factories)
            {
                var discountService = factory.CreateDiscountService();

                Console.WriteLine($"{discountService.DiscountPercentage}% of discount from {discountService}");
            }
        }
    }
}