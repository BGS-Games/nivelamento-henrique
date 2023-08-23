using DamageSystem.Character;

namespace DamageSystem.Tests
{
    internal class CharacterMockBuilder
    {
        public static CharacterController Simple() => new(new CharacterAttributes("simple", 10, 10, 10));

        public static CharacterController Dead() => new(new CharacterAttributes("dead", 0, 10, 10));
    }
}
