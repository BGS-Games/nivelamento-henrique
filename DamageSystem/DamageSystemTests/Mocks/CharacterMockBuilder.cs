namespace DamageSystem.Tests
{
    internal class CharacterMockBuilder
    {
        public static Character Simple() => new(new CharacterAttributes("simple", 10, 10, 10));

        public static Character Dead() => new(new CharacterAttributes("dead", 0, 10, 10));
    }
}
