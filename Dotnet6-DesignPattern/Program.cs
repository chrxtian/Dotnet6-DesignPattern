using Dotnet6_DesignPattern.FactoryMethod.SalesDiscount;
using Dotnet6_DesignPattern.FactoryMethod.StarWarsCharacters;

namespace Dotnet6_DesignPattern
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Factory Method");
        //    Console.WriteLine("--------------");

        //    var factories = new List<DiscountFactory>
        //    {
        //        new CodeDiscountFactory(Guid.NewGuid()),
        //        new CountryDiscountFactory("PE")
        //    };

        //    foreach (var factory in factories)
        //    {
        //        var discountService = factory.CreateDiscountService();

        //        Console.WriteLine($"{discountService.DiscountPercentage}% of discount from {discountService}");
        //    }
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("Factory Method");
            Console.WriteLine("--------------");

            CharacterFactory factory = new RebelSoldierFactory();
            Character rebelSoldier = factory.CreateCharacter();
            rebelSoldier.Introduce();

            factory = new SithLordFactory();
            Character sithLord = factory.CreateCharacter();
            sithLord.Introduce();

        }
    }
}