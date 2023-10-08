namespace Dotnet6_DesignPattern.FactoryMethod.SalesDiscount
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }

        public override string ToString() => GetType().Name;
    }

    /// <summary>
    /// ConcreteProduct 1
    /// </summary>
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryCode;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryCode = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryCode)
                {
                    // This countries gets a better discount XD
                    case "PH":
                    case "PE":
                        return 20;
                    default:
                        return 10;
                }
            }
        }
    }

    /// <summary>
    /// /// ConcreteProduct 1
    /// </summary>
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;
        public CodeDiscountService(Guid code)
        {
            _code = code;
        }

        public override int DiscountPercentage
        {
            // This is an example, but here we can add additional validations
            // for check that the code is only used once.
            get => 15;
        }
    }

    //======================================================================//

    /// <summary>
    /// Creator
    /// </summary>
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    /// <summary>
    /// ConcreteCreator 1
    /// </summary>
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;
        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    /// <summary>
    /// ConcreteCreator 2
    /// </summary>
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;
        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }






}
