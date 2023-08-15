namespace DamageSystem.Tests
{
    internal class CharacterMockBuilder
    {
        public static Character Simple() => new(new CharacterAttributes(10, 10, 10));

        public static Character Dead() => new(new CharacterAttributes(0, 10, 10));
    }
}
