namespace Dotnet6_DesignPattern.FactoryMethod.StarWarsCharacters
{
    // Base class for characters (Product)
    public abstract class Character
    {
        public abstract void Introduce();
    }

    // Concrete character classes for Rebels

        // (Concrete Product 1)
        public class RebelSoldier : Character
        {
            public override void Introduce()
            {
                Console.WriteLine("Rebel soldier ready for battle!");
            }
        }

        // (Concrete Product 2)
        public class RebelPilot : Character
        {
            public override void Introduce()
            {
            Console.WriteLine("Rebel pilot reporting for duty!");
            }
        }


    // Concrete character classes for the Empire

        // (Concrete Product 3)
        public class Stormtrooper : Character
        {
            public override void Introduce()
                {
                Console.WriteLine("Imperial stormtrooper standing guard.");
            }
        }

        // (Concrete Product 4)
        public class SithLord : Character
        {
            public override void Introduce()
            {
                Console.WriteLine("Sith Lord wielding the dark side of the Force.");
            }
        }

    //===========================================================================//

    // Interface for character factories (Creator)
    public interface CharacterFactory
    {
        Character CreateCharacter();
    }


    // Concrete factories for Rebels

        // (ConcreateCreator 1)
        public class RebelSoldierFactory : CharacterFactory
        {
            public Character CreateCharacter()
            {
                return new RebelSoldier();
            }
        }

        // (ConcreateCreator 2)
        public class RebelPilotFactory : CharacterFactory
        {
            public Character CreateCharacter()
            {
                return new RebelPilot();
            }
        }


    // Concrete factories for the Empire

        // (ConcreateCreator 3)
        public class StormtrooperFactory : CharacterFactory
        {
            public Character CreateCharacter()
            {
                return new Stormtrooper();
            }
        }

        // (ConcreateCreator 4)
        public class SithLordFactory : CharacterFactory
        {
            public Character CreateCharacter()
            {
                return new SithLord();
            }
        }
}
